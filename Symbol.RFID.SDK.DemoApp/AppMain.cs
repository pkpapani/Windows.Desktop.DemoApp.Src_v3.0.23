using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Windows.Forms;
using Symbol.RFID.SDK.DemoApp.Entities;
using Symbol.RFID.SDK.DemoApp.Globals;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class frmMain : Form
    {
        #region Conts

        private const int MAX_OUTPUT_LINES = 100;

        #endregion

        #region Enum

        #endregion

        #region Private Fields

        private List<IRfidReader> readerList;
        private int outputLinePos = 0;
        private IRfidReader selectedReader;
        private RFIDReaderItem selectedItem;
        private Dictionary<string, TagInfo> tagList = new Dictionary<string, TagInfo>();
        private bool isStopPressed;
        private bool isConnected;

        private bool isWaitAnimation = false;
        private bool isConnectedManually = false;

        private bool isBluetoothWatcherInitialized = false;
        private bool isUsbWatcherInitialized = false;

        private string deviceIdWhichRunsInventory = string.Empty;
        private string deviceIdWhichRunsTagLocate = string.Empty;

        private WaitAnimation waitDialog;
        private System.Windows.Forms.Timer deviceStatusTimer;

        #endregion

        #region Private Fields

        public ReaderInfo ReaderInfo { private get; set; }

        #endregion

        #region Constructors

        public frmMain()
        {
            InitializeComponent();
            try
            {
                InitializeReaderWatcher();
            }
            catch (Exception ex)
            {
                //Print exception to log if Initializing ReaderWatcher failed
                OutputText(ex.Message);
                //Disable controls
                DisableControls();
            }
        }

        #endregion

        #region Form Event Handlers

        private void FrmAppMain_Load(object sender, EventArgs e)
        {
            if (isBluetoothWatcherInitialized || isUsbWatcherInitialized)
            {
                PopulateControls();

                FillRFIDReadersItems();
            }
        }

        private void ComboBoxReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedReader();

            UpdateUIControls(selectedReader.IsConnected);
        }

        private void btnManulConnect_Click(object sender, EventArgs e)
        {
            ManualConnect frmManual = new ManualConnect(this);
            frmManual.ShowDialog();

            ManualConnect();
        }

        private void BtnPairNew_Click(object sender, EventArgs e)
        {
            PairNewReader(this);
            FillRFIDReadersItems();
        }

        private void BtnConnectDisconnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (string.Equals(btnConnectDisconnect.Text, "CONNECT", StringComparison.OrdinalIgnoreCase))
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }


        private void BtnInventoryStart_Click(object sender, EventArgs e)
        {
            try
            {
                StartInventory();
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void BtnInventoryStop_Click(object sender, EventArgs e)
        {
            try
            {
                StopInventory();
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void BtnSaveConfig_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (selectedReader != null)
                {
                    RFIDLibraryUtility.SaveConfiguration(selectedReader);
                    OutputText("Save Configuration : Successful");
                }
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void BtnRestoreDefaults_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReader != null)
                {
                    BeginInvoke(new Action(delegate
                    {
                        DialogResult result = MessageBox.Show("This will reset the device to factory defaults and you may have to unpair and re-pair the device before using. Do you want to continue?",
                                                               "Important",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Warning,
                                                               MessageBoxDefaultButton.Button2);

                        if (result == DialogResult.Yes)
                        {
                            RFIDLibraryUtility.RestoreDefault(selectedReader);
                            OutputText("This will reset the device to factory defaults and you may have to unpair and re-pair the device before using");
                            UpdateUIControls(false, true);
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void FrmAppMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (selectedReader != null)
                {
                    if (selectedReader != null)
                    {
                        RFIDLibraryUtility.Disconnect(selectedReader);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About(selectedReader, this);
            frm.ShowDialog();
        }

        private void TriggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedReader != null)
            {
                try
                {
                    TriggersForm frmTrigger = new TriggersForm(this);
                    TriggersForm.triggerInfo = RFIDLibraryUtility.GetTriggerInformation(selectedReader);
                    if (frmTrigger.ShowDialog(this) == DialogResult.OK)
                    {
                        RFIDLibraryUtility.SetTriggerInformation(selectedReader, TriggersForm.triggerInfo);
                    }
                }
                catch (Exception ex)
                {
                    OutputText("Error getting/setting trigger information, exception :" + ex.Message);
                }
            }
        }

        private void Configurations_Click(object sender, EventArgs e)
        {
            ShowReaderConfiguration();
        }

        private void CapabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReaderCapabilities();
        }

        private void versionMenuItem_Click(object sender, EventArgs e)
        {
            ShowReaderVersionInfo();
        }

        private void SingulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSingulationDlg();
        }

        private void BtnPurgeTags_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReader != null)
                {
                    RFIDLibraryUtility.PurgeTags(selectedReader);
                    // Clean the inventory tag data list
                    ResetTagInfo();
                    OutputText("Purge Tags : Successful");
                }
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void TagReportingMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedReader != null)
            {
                try
                {
                    TagReportingForm frmTrigger = new TagReportingForm(this);
                    frmTrigger.Reader = selectedReader;
                    frmTrigger.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    OutputText("Error getting/setting tag report configuration, exception :" + ex.Message);
                }
            }
        }

        private void BtnTagLocateStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTagId.Text))
                {
                    MessageBox.Show("Please fill the tag id to locate", "Tag Locate", MessageBoxButtons.OK);
                    return;
                }
                StartTagLocate();
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void BtnTagLocateStop_Click(object sender, EventArgs e)
        {
            try
            {
                StopTagLocate();
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }

        private void tabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdTags.RowCount > 0)
            {
                var source = new AutoCompleteStringCollection();
                foreach (DataGridViewRow row in grdTags.Rows)
                {
                    source.Add(row.Cells[0].Value.ToString());
                }
                txtTagId.AutoCompleteCustomSource = source;
                txtTagPattern.AutoCompleteCustomSource = source;
                txtTagPatternLock.AutoCompleteCustomSource = source;
                txtTagPatternKill.AutoCompleteCustomSource = source;
            }
        }

        private void antennaConfiguration_Click(object sender, EventArgs e)
        {
            ShowReaderAntennaConfiguration();
        }

        private void regulatory_Click(object sender, EventArgs e)
        {
            ShowRegulatory(true);
        }

        private void preFilters_Click(object sender, EventArgs e)
        {
            ShowPreFilter();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadTagData();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteTagData();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            LockTagData();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            KillTag();
        }


        private void btnGetAttribute_Click(object sender, EventArgs e)
        {
            /*
            GetAttribute();
            */
        }

        private void btnSetAttribute_Click(object sender, EventArgs e)
        {
            /*
            SetAttribute();
            */
        }


        private void lblLog_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        #endregion

        #region RFIDReader EventHandlers

        /// <summary>
        /// Occurs when a new reader has appeared (paired).
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void ReaderAppearedHandler(object sender, ReaderStatusChangedEventArgs e)
        {
            var reader = readerList.Find(i => i.ID.Equals(e.RFIDReaderInfo.ID, StringComparison.OrdinalIgnoreCase));

            if (reader == null)
            {
                Task.Run(() => Invoke((MethodInvoker)delegate
                {
                    var deviceInfo = CreateReaderInfoItem(e.RFIDReaderInfo);
                    if (!readerList.Any(r => r.ID == deviceInfo.Reader.ID))
                        readerList.Add(deviceInfo.Reader);

                    AddToReaderList(deviceInfo);

                    var status = e.RFIDReaderInfo.CommunicationMode == ReaderCommunicationMode.Bluetooth ? "Paired" : "Attached";
                    OutputText("Events_StatusNotify: " + status + ".\n");
                }));
            }
        }

        /// <summary>
        /// Occurs when a reader has disappeared (unpaired).
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void ReaderDisappearedHandler(object sender, ReaderStatusChangedEventArgs e)
        {
            var reader = readerList.Find(i => i.ID.Equals(e.RFIDReaderInfo.ID, StringComparison.OrdinalIgnoreCase));

            if (reader != null)
            {
                Task.Run(() => Invoke((MethodInvoker)delegate
                {
                    if (reader.IsConnected)
                    {
                        Disconnect();
                    }

                    BeginInvoke((MethodInvoker)delegate
                    {
                        UpdateUIControls(false);
                    });

                    RemoveFromReaderList(reader);
                    readerList.Remove(reader);

                    var status = e.RFIDReaderInfo.CommunicationMode == ReaderCommunicationMode.Bluetooth ? "Unpaired" : "Detached";
                    OutputText("Events_StatusNotify: " + status + ".\n");
                }));
            }
        }

        /// <summary>
        /// Occurs when a reader has been connected.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void ReaderConnectedHandler(object sender, ReaderStatusChangedEventArgs e)
        {
            var reader = readerList.Find(i => i.ID.Equals(e.RFIDReaderInfo.ID, StringComparison.OrdinalIgnoreCase));
            if (reader != null)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    OutputText("Events_StatusNotify: Connected.\n");
                });
            }
        }

        /// <summary>
        /// Occurs when a reader has been disconnected.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void ReaderDisconnectedHandler(object sender, ReaderStatusChangedEventArgs e)
        {
            if (selectedReader != null && selectedReader.ID == e.RFIDReaderInfo.ID)
            {
                isConnected = false;

                UnRegisterEvents();

                ActiveReaderStatus.Reset();

                BeginInvoke((MethodInvoker)delegate
                {
                    UpdateUIControls(false);
                    selectedReader = null;

                    OutputText("Events_StatusNotify: Disconnected.\n");
                });
            }
        }

        /// <summary>
        ///  Occurs when an inventory session started.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void Inventory_InventoryStarted(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OutputText("Event: Inventory started.\n");
            });
        }

        /// <summary>
        ///  Occurs when an inventory session stops.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void Inventory_InventoryStopped(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                OutputText("Event: Inventory stopped.\n");
            });

            // Update the current reader default region, batch mode, trigger repeat status once batch mode inventory is completed.
            if (!ActiveReaderStatus.Initialized)
            {
                try
                {
                    CheckRegion();
                    ActiveReaderStatus.IsTriggerRepeat = RFIDLibraryUtility.IsTriggerRepeat(selectedReader);
                    ActiveReaderStatus.BatchMode = RFIDLibraryUtility.GetBatchMode(selectedReader);
                    ActiveReaderStatus.Initialized = true;
                }
                catch (Exception)
                {
                    OutputText("Event: Reading region and triggers after inventory stopped" + Environment.NewLine);
                    ActiveReaderStatus.Initialized = false;
                }
            }
            // if the trigger is a repeat trigger and not stopped via the Stop button keep the button text as stop at inventory stopped event
            if (ActiveReaderStatus.IsTriggerRepeat && !isStopPressed)
            {
                deviceIdWhichRunsInventory = selectedReader.ID;
                ActiveReaderStatus.IsInventoryRunning = true;

                UpdateInventoryButtons();
            }
            // due to user manually stopped the inventory or a non repeat trigger completed
            else
            {
                deviceIdWhichRunsInventory = string.Empty;
                ActiveReaderStatus.IsInventoryRunning = false;

                UpdateInventoryButtons();
                isStopPressed = false;

                // Get batch tag once auto stop the inventory when stopTrigger type set as any other option instead immediate and inventory ran under batch mode.
                if (ActiveReaderStatus.IsBatchModeInventoryRunning && !isStopPressed)
                {
                    RFIDLibraryUtility.GetBatchedTags(selectedReader);
                    OutputText("Get Batched Tags : Successful");
                    ActiveReaderStatus.IsBatchModeInventoryRunning = false;
                }
            }
        }

        /// <summary>
        /// Occurs after completing an inventory session to provides the session summary.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void Inventory_InventorySessionSummary(object sender, ReadSessionSummaryEventArgs e)
        {
            if (e == null)
                return;

            Invoke((MethodInvoker)delegate
            {
                ReadSessionSummaryEventArgs readSessionSummary = (ReadSessionSummaryEventArgs)e;
                OutputText("Event: Inventory operation end summary\n");
                OutputText("\tTotal Rounds = " + readSessionSummary.TotalRounds + "\n");
                OutputText("\tTotal Tags = " + readSessionSummary.TotalTags + "\n");
                OutputText("\tTotal Time (μs) = " + readSessionSummary.TotalTimeuS + "\n");
            });
        }

        /// <summary>
        /// Occurs when device connected running offline batch mode
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void Inventory_BatchMode(object sender, ReadSessionBatchModeEventArgs e)
        {
            ActiveReaderStatus.IsBatchModeInventoryRunning = true;
            deviceIdWhichRunsInventory = selectedReader.ID;
            ActiveReaderStatus.IsInventoryRunning = true;

            // Wait for connected event fires
            while (!isConnected)
            {
                Thread.Sleep(500);
            }
            UpdateInventoryButtons();
        }

        /// <summary>
        /// Occurs when reader read tags.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void Inventory_TagDataReceived(object sender, TagDataReceivedEventArgs e)
        {
            ProcessTagDataReceivedEvent(e);
        }


        /// <summary>
        ///  Occurs when an tag locate session started.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void TagLocate_TagLocateStarted(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OutputText("Event: TagLocate started.\n");
            });
        }

        /// <summary>
        ///  Occurs when an tag locate session started.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void TagLocate_TagLocateStopped(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OutputText("Event: TagLocate stopped.\n");
            });
        }

        /// <summary>
        /// Occurs when tag proximity precent recived.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event.</param>
        private void TagLocate_ProximityPercentReceived(object sender, ProximityPercentReceivedEventArgs e)
        {
            ProcessProximityPercentReceivedEvent(e);
        }


        private void AccessOperations_AccessOperationStarted(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OutputText("Event: Access operation started.\n");
            });
        }

        private void AccessOperations_AccessOperationStopped(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OutputText("Event: Access operation stopped.\n");
            });
        }

        private void AccessOperations_AccessOperationSummary(object sender, ReadSessionSummaryEventArgs e)
        {
            if (e == null)
                return;

            Invoke((MethodInvoker)delegate
            {
                ReadSessionSummaryEventArgs readSessionSummary = (ReadSessionSummaryEventArgs)e;
                OutputText("Event: Access operation end summary\n");
                OutputText("\tTotal Rounds = " + readSessionSummary.TotalRounds + "\n");
                OutputText("\tTotal Tags = " + readSessionSummary.TotalTags + "\n");
                OutputText("\tTotal Time (μs) = " + readSessionSummary.TotalTimeuS + "\n");
            });
        }


        /// <summary>
        ///  Occurs when temperature status changes or on user request.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The TemperatureStatusNotificationReceivedEventArgs</param>
        private void SelectedReader_TemperatureStatusNotification(object sender, TemperatureStatusNotificationReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (e != null)
                {
                    lblTemperature.Text = e.PATemp.ToString() + " C";
                    OutputText("Event_Temperature: STM32 Temperature = " + e.AmbTemp + ", Radio PA Temperature = " + e.PATemp + ", Cause = " + e.Cause);
                }
            });
        }

        /// <summary>
        /// Occurs when power status changes or on user request.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The PowerStatusNotificationReceivedEventArgs</param>
        private void SelectedReader_PowerStatusNotification(object sender, PowerStatusNotificationReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (e != null)
                {
                    lblPower.Text = e.Voltage.ToString() + " v";
                    OutputText("Event_Power: Current = " + e.Current + ", Power = " + e.Power + ", Voltage = " + e.Voltage + ",Cause = " + e.Cause);
                }
            });
        }

        /// <summary>
        /// Occurs when battery status changes or on user request.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The BatteryStatusNotificationReceivedEventArgs</param>
        private void SelectedReader_BatteryStatusNotification(object sender, BatteryStatusNotificationReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (e != null)
                {
                    lblBatteryLevel.Text = ((uint)e.Level).ToString() + "%";
                    OutputText("Event_Battery: Level = " + (uint)e.Level + "%, Status = " + e.Charging + ", Cause = " + e.Cause);
                }
            });
        }


        private void HexInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsHex(e);
        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsNumeric(e);
        }

        private void BatteryStatusTimer_Tick(object sender, object e)
        {
            if (selectedReader == null || !selectedReader.IsConnected)
                return;

            GetDeviceStatus();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate data grid view view UI control.
        /// </summary>
        private void PopulateControls()
        {
            DataGridViewColumn colTagID = new DataGridViewTextBoxColumn();
            colTagID.HeaderText = "Tag ID";
            colTagID.Name = "TagID";
            colTagID.Width = 255;
            colTagID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTagID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdTags.Columns.Add(colTagID);

            DataGridViewColumn colPeakRSSI = new DataGridViewTextBoxColumn();
            colPeakRSSI.HeaderText = "Peak RSSI";
            colPeakRSSI.Name = "PeakRSSI";
            colPeakRSSI.Width = 255;
            colPeakRSSI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPeakRSSI.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdTags.Columns.Add(colPeakRSSI);

            DataGridViewColumn colTagCount = new DataGridViewTextBoxColumn();
            colTagCount.HeaderText = "Tag Seen Count";
            colTagCount.Name = "TagSeenCount";
            colTagCount.Width = 255;
            colTagCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTagCount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdTags.Columns.Add(colTagCount);

            cmbMemoryBank.Items.AddRange(Enum.GetNames(typeof(MEMORY_BANK)));
            cmbMemoryBank.SelectedIndex = 0;
            cmbMemoryBankLock.Items.AddRange(Enum.GetNames(typeof(LOCK_MEMORY_BANK)));
            cmbMemoryBankLock.SelectedIndex = 0;
            cmbLockPrivilage.Items.AddRange(Enum.GetNames(typeof(ACCESS_PERMISSIONS)));
            cmbLockPrivilage.SelectedIndex = 0;

            BatteryStatusTimer();
        }

        /// <summary>
        /// Initialize the reader watcher events.
        /// </summary>
        private void InitializeReaderWatcher()
        {
            try
            {
                IRemoteReaderWatcher remoteReaderWatcher = RfidSdk.ReaderWatcherServicesFactory.Create(ReaderCommunicationMode.Bluetooth);
                remoteReaderWatcher.ReaderAppeared += new EventHandler<ReaderStatusChangedEventArgs>(ReaderAppearedHandler);
                remoteReaderWatcher.ReaderDisappeared += new EventHandler<ReaderStatusChangedEventArgs>(ReaderDisappearedHandler);
                remoteReaderWatcher.ReaderConnected += new EventHandler<ReaderStatusChangedEventArgs>(ReaderConnectedHandler);
                remoteReaderWatcher.ReaderDisconnected += new EventHandler<ReaderStatusChangedEventArgs>(ReaderDisconnectedHandler);

                isBluetoothWatcherInitialized = true;
            }
            catch (Exception ex)
            {
                //Print exception to log if Initializing ReaderWatcher failed
                OutputText(ex.Message);
            }

            try
            {
                IRemoteReaderWatcher usbReaderWatcher = RfidSdk.ReaderWatcherServicesFactory.Create(ReaderCommunicationMode.USB);
                usbReaderWatcher.ReaderAppeared += new EventHandler<ReaderStatusChangedEventArgs>(ReaderAppearedHandler);
                usbReaderWatcher.ReaderDisappeared += new EventHandler<ReaderStatusChangedEventArgs>(ReaderDisappearedHandler);
                usbReaderWatcher.ReaderConnected += new EventHandler<ReaderStatusChangedEventArgs>(ReaderConnectedHandler);
                usbReaderWatcher.ReaderDisconnected += new EventHandler<ReaderStatusChangedEventArgs>(ReaderDisconnectedHandler);

                isUsbWatcherInitialized = true;
            }
            catch (Exception ex)
            {
                //Print exception to log if Initializing ReaderWatcher failed
                OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Initialize the device status timer
        /// </summary>
        private void BatteryStatusTimer()
        {
            deviceStatusTimer = new System.Windows.Forms.Timer();
            deviceStatusTimer.Tick += BatteryStatusTimer_Tick;

            // It is up to the user to how frequently to get the device status.
            // The optimum value is 4 minutes and the best use of it is should not less than a minute.
            deviceStatusTimer.Interval = (1 * 60 * 1000); // 1 minutes
        }

        /// <summary>
        /// Disables button controls
        /// </summary>
        private void DisableControls()
        {
            settingsMenuItem.Enabled = false;
            btnConnectDisconnect.Enabled = false;

            (tabInventory as Control).Enabled = false;
            (tabTagLocate as Control).Enabled = false;
        }

        /// <summary>
        /// Update enability disability of UI controls.
        /// </summary>
        /// <param name="isConnect"></param>
        private void UpdateUIControls(bool isConnect)
        {
            UpdateUIControls(isConnect, false);
        }

        /// <summary>
        /// Update enability disability of UI controls.
        /// </summary>
        /// <param name="isConnect"></param>
        /// <param name="isReset"></param>
        private void UpdateUIControls(bool isConnect, bool isReset)
        {
            if (isReset)
            {
                btnConnectDisconnect.Enabled = false;
                helpMenuItem.Enabled = isConnect;
            }
            else
            {
                if (comboBoxReaders.Items.Count > 0)
                    btnConnectDisconnect.Enabled = true;

                btnConnectDisconnect.Text = (isConnect ? "DISCONNECT" : "CONNECT");
                helpMenuItem.Enabled = true;
            }

            btnManulConnect.Enabled = !isConnect;

            settingsMenuItem.Enabled = isConnect;

            btnInventoryStart.Enabled = isConnect;
            btnInventoryStop.Enabled = false;
            btnPurgeTags.Enabled = isConnect;
            btnTagLocateStart.Enabled = isConnect;
            btnTagLocateStop.Enabled = false;

            btnRead.Enabled = isConnect;
            btnWrite.Enabled = isConnect;
            btnLock.Enabled = isConnect;
            btnKill.Enabled = isConnect;
            btnGetAttribute.Enabled = isConnect;
            btnSetAttribute.Enabled = isConnect;

            if (string.IsNullOrEmpty(deviceIdWhichRunsInventory) || (selectedReader != null && deviceIdWhichRunsInventory == selectedReader.ID))
            {
                (tabInventory as Control).Enabled = true;
                if (selectedReader != null && deviceIdWhichRunsInventory == selectedReader.ID)
                {
                    if (isConnect)
                    {
                        btnInventoryStart.Enabled = false;
                        btnInventoryStop.Enabled = true;
                    }
                    else
                    {
                        deviceIdWhichRunsInventory = string.Empty;
                    }
                }
            }
            else
            {
                (tabInventory as Control).Enabled = false;
            }

            if (string.IsNullOrEmpty(deviceIdWhichRunsTagLocate) || (selectedReader != null && deviceIdWhichRunsTagLocate == selectedReader.ID))
            {
                (tabTagLocate as Control).Enabled = true;
                if (selectedReader != null && deviceIdWhichRunsTagLocate == selectedReader.ID)
                {
                    if (isConnect)
                    {
                        btnTagLocateStart.Enabled = false;
                        btnTagLocateStop.Enabled = true;
                    }
                    else
                    {
                        deviceIdWhichRunsTagLocate = string.Empty;
                    }
                }
            }
            else
            {
                (tabTagLocate as Control).Enabled = false;
            }
        }

        /// <summary>
        /// Fill reader items into home screen reader comboBox.
        /// </summary>
        private void FillRFIDReadersItems()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                readerList = new List<IRfidReader>();
                comboBoxReaders.Items.Clear();

                //Initialize reader management and reader info list.
                var readerInfoList = new List<IRfidReaderInfo>();

                if (isBluetoothWatcherInitialized)
                {
                    var remoteReaderInfoList = RFIDLibraryUtility.InitReaderList(ReaderCommunicationMode.Bluetooth);
                    readerInfoList.AddRange(remoteReaderInfoList);
                }

                if (isUsbWatcherInitialized)
                {
                    var usbReaderInfoList = RFIDLibraryUtility.InitReaderList(ReaderCommunicationMode.USB);
                    readerInfoList.AddRange(usbReaderInfoList);
                }

                foreach (IRfidReaderInfo readerInfo in readerInfoList.OrderBy(o => o.FriendlyName))
                {
                    var deviceInfo = CreateReaderInfoItem(readerInfo);
                    readerList.Add(deviceInfo.Reader);

                    var device = new RFIDReaderItem(deviceInfo);
                    comboBoxReaders.Items.Add(device);
                }

                if (comboBoxReaders.Items.Count > 0)
                {
                    comboBoxReaders.SelectedIndex = 0;
                    btnConnectDisconnect.Enabled = true;
                }
                else
                {
                    btnConnectDisconnect.Enabled = false;
                    UpdateUIControls(false);
                }
            }
            catch (Exception ex)
            {
                OutputText("Error discovering scanner: " + ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Crate local reader info item from SDK reader info object.
        /// </summary>
        /// <param name="readerInfo">The Reader Info object <see cref="IRfidReaderInfo"/></param>
        /// <returns>The reader info object <see cref="RFIDReaderItemInfo"/></returns>
        private RFIDReaderItemInfo CreateReaderInfoItem(IRfidReaderInfo readerInfo)
        {
            //create reader instance based on reader information.
            var reader = RFIDLibraryUtility.CreateReader(readerInfo);

            //creating reader device info object to create reader item on comboBox.
            var deviceInfo = new RFIDReaderItemInfo()
            {
                HostAddress = readerInfo.ID,
                PortNumber = readerInfo.ComPortNumber,
                FriendlyName = reader.FriendlyName,
                CommunicationMode = readerInfo.CommunicationMode,
                Status = readerInfo.Status,
                Reader = reader
            };

            return deviceInfo;
        }

        /// <summary>
        /// Check Current Region and if not set, prompt user to select the region
        /// </summary>
        private void CheckRegion()
        {
            // Check the region value is already set with connected reader and if not, set the region.
            var region = RFIDLibraryUtility.GetRegion(selectedReader);

            // If regulatory is not set, set it
            if (region == null)
            {
                ShowRegulatory(false);
            }
        }

        /// <summary>
        /// Update active reader status once reader is connected (but not if inventory running in batch mode)
        /// </summary>
        private void UpdateActiveReaderStatus()
        {
            // Check whether connected reader is not in batch mode inventory running state.
            if (ActiveReaderStatus.IsBatchModeInventoryRunning)
            {
                BeginInvoke(new Action(delegate
                {
                    OutputText("Inventory is running in batch mode\n");
                }));
            }
            else
            {
                try
                {
                    // Check the region value is already set with connected reader.
                    CheckRegion();

                    // Update the trigger repeat state of the reader based on connected reader start trigger configuration. 
                    ActiveReaderStatus.IsTriggerRepeat = RFIDLibraryUtility.IsTriggerRepeat(selectedReader);

                    // Keep the current batch mode configuration option of connected reader. It is used to make decision when start inventory.
                    ActiveReaderStatus.BatchMode = RFIDLibraryUtility.GetBatchMode(selectedReader);

                    // Use a single flag to determine all the information is retrieved.
                    ActiveReaderStatus.Initialized = true;
                }
                catch
                {
                    ActiveReaderStatus.Initialized = false;
                }
            }
        }

        /// <summary>
        /// Connect the reader using from IP Address and Port or COM port.
        /// </summary>
        private void ManualConnect()
        {
            if (ReaderInfo == null)
                return;

            var deviceInfo = CreateReaderInfoItem(ReaderInfo);
            selectedReader = deviceInfo.Reader;

            Connect();
        }

        /// <summary>
        /// Update the manual connected device status.
        /// </summary>
        /// <param name="success">Is connected successfully.</param>
        private void UpdateManualConnectStatus(bool success)
        {
            if (ReaderInfo == null)
                return;

            if (!success)
            {
                ReaderInfo = null;
                selectedReader = null;
                return;
            }

            isConnectedManually = true;
            comboBoxReaders.Enabled = false;

            var deviceInfo = CreateReaderInfoItem(ReaderInfo);
            if (!readerList.Any(r => r.FriendlyName.Contains(deviceInfo.PortNumber)))
                readerList.Add(deviceInfo.Reader);

            AddToReaderList(deviceInfo, true);
            ReaderInfo = null;

            OutputText("StatusNotify: Connected.\n");
        }

        /// <summary>
        /// Update the manual disconnected device status.
        /// </summary>
        /// <param name="success">Is disconnected successfully.</param>
        private void UpdateManualDisconnectStatus(bool success)
        {
            if (!success || !isConnectedManually)
                return;

            isConnectedManually = false;
            comboBoxReaders.Enabled = true;

            UnRegisterEvents();

            ActiveReaderStatus.Reset();

            var reader = readerList.Find(r => r.ID.Equals(selectedReader.ID, StringComparison.OrdinalIgnoreCase));
            RemoveFromReaderList(reader);
            readerList.Remove(reader);

            UpdateUIControls(false);
            selectedReader = null;

            OutputText("StatusNotify: Disconnected.\n");
        }

        /// <summary>
        /// Connect the selected reader.
        /// </summary>
        private void Connect()
        {
            try
            {
                OutputText("Connecting...");

                SetSelectedReader();

                if (selectedReader.IsConnected)
                {
                    RFIDLibraryUtility.Disconnect(selectedReader);
                }

                Thread connectThread = new Thread(StartConnect);
                connectThread.Start();

                isWaitAnimation = true;

                waitDialog = new WaitAnimation();
                waitDialog.StartPosition = FormStartPosition.CenterParent;
                waitDialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Initiates a connection to the reader. 
        /// </summary>
        private void StartConnect()
        {
            try
            {
                RegisterEvents();
                selectedReader.Inventory.AttachTagDataWithTagDataReceivedEvent = true;

                RFIDLibraryUtility.Connect(selectedReader);

                UpdateActiveReaderStatus();

                Invoke((MethodInvoker)delegate
                {
                    UpdateManualConnectStatus(true);

                    UpdateUIControls(true);
                    GetDeviceStatus();
                    deviceStatusTimer.Start();

                    Cursor.Current = Cursors.Default;
                    isConnected = true;

                    if (isWaitAnimation)
                    {
                        waitDialog.Close();
                        isWaitAnimation = false;
                    }
                });
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)delegate
                {
                    UpdateManualConnectStatus(false);

                    OutputText(ex.Message);
                    isConnected = false;
                    if (isWaitAnimation)
                    {
                        waitDialog.Close();
                        isWaitAnimation = false;
                    }
                    ActiveReaderStatus.Initialized = false;
                    UpdateUIControls(false);
                });
            }
        }

        /// <summary>
        /// Disconnect the selected reader.
        /// </summary>
        private void Disconnect()
        {
            try
            {
                OutputText("Disconnecting...");

                if (selectedReader != null)
                {
                    RFIDLibraryUtility.Disconnect(selectedReader);
                    ActiveReaderStatus.Initialized = false;
                    UpdateUIControls(false);
                }

                // Clean the inventory tag data list
                ResetTagInfo();

                deviceStatusTimer.Stop();

                UpdateManualDisconnectStatus(true);
            }
            catch (Exception ex)
            {
                UpdateManualDisconnectStatus(false);

                OutputText(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Register event handlers.
        /// </summary>
        private void RegisterEvents()
        {
            selectedReader.BatteryStatusNotification += SelectedReader_BatteryStatusNotification;
            selectedReader.PowerStatusNotification += SelectedReader_PowerStatusNotification;
            selectedReader.TemperatureStatusNotification += SelectedReader_TemperatureStatusNotification;

            selectedReader.Inventory.BatchMode += Inventory_BatchMode;
            selectedReader.Inventory.InventoryStarted += Inventory_InventoryStarted;
            selectedReader.Inventory.InventoryStopped += Inventory_InventoryStopped;
            selectedReader.Inventory.InventorySessionSummary += Inventory_InventorySessionSummary;
            selectedReader.Inventory.TagDataReceived += Inventory_TagDataReceived;

            selectedReader.TagLocate.ProximityPercentReceived += TagLocate_ProximityPercentReceived;
            selectedReader.TagLocate.TagLocateStarted += TagLocate_TagLocateStarted;
            selectedReader.TagLocate.TagLocateStopped += TagLocate_TagLocateStopped;

            selectedReader.AccessOperations.AccessOperationStarted += AccessOperations_AccessOperationStarted;
            selectedReader.AccessOperations.AccessOperationStopped += AccessOperations_AccessOperationStopped;
            selectedReader.AccessOperations.AccessOperationSummary += AccessOperations_AccessOperationSummary;
        }

        private void SetSelectedReader()
        {
            if (ReaderInfo != null)
                return;

            selectedItem = (RFIDReaderItem)comboBoxReaders.SelectedItem;
            selectedReader = readerList.Find(i => i.ID.Equals(selectedItem.Id, StringComparison.OrdinalIgnoreCase));

            if (selectedReader == null)
            {
                throw new ApplicationException("Selected reader should not be null.");
            }
        }

        /// <summary>
        /// Unregister events once reader is disconneted.
        /// </summary>
        private void UnRegisterEvents()
        {
            selectedReader.BatteryStatusNotification -= SelectedReader_BatteryStatusNotification;
            selectedReader.PowerStatusNotification -= SelectedReader_PowerStatusNotification;
            selectedReader.TemperatureStatusNotification -= SelectedReader_TemperatureStatusNotification;

            selectedReader.Inventory.BatchMode -= Inventory_BatchMode;
            selectedReader.Inventory.InventoryStarted -= Inventory_InventoryStarted;
            selectedReader.Inventory.InventoryStopped -= Inventory_InventoryStopped;
            selectedReader.Inventory.InventorySessionSummary -= Inventory_InventorySessionSummary;
            selectedReader.Inventory.TagDataReceived -= Inventory_TagDataReceived;

            selectedReader.TagLocate.ProximityPercentReceived -= TagLocate_ProximityPercentReceived;
            selectedReader.TagLocate.TagLocateStarted -= TagLocate_TagLocateStarted;
            selectedReader.TagLocate.TagLocateStopped -= TagLocate_TagLocateStopped;

            selectedReader.AccessOperations.AccessOperationStarted -= AccessOperations_AccessOperationStarted;
            selectedReader.AccessOperations.AccessOperationStopped -= AccessOperations_AccessOperationStopped;
            selectedReader.AccessOperations.AccessOperationSummary -= AccessOperations_AccessOperationSummary;
        }

        /// <summary>
        /// Gets the battery, temperature and power of the selected reader.
        /// </summary>
        private void GetDeviceStatus()
        {
            Task.Run(new Action(delegate
            {
                try
                {
                    RFIDLibraryUtility.GetDeviceStatus(selectedReader, true, true, true);
                }
                catch (Exception ex)
                {
                    BeginInvoke(new Action(delegate
                    {
                        OutputText(ex.Message);
                    }));
                }
            }));
        }

        /// <summary>
        /// Starts the inventory.
        /// </summary>
        private void StartInventory()
        {
            try
            {
                if (ActiveReaderStatus.IsInventoryRunning)
                {
                    OutputText("Inventory perform already in progress....");
                }
                else
                {
                    // Clean the inventory tag data list
                    ResetTagInfo();

                    isStopPressed = false;
                    deviceIdWhichRunsInventory = selectedReader.ID;
                    ActiveReaderStatus.IsInventoryRunning = true;

                    Task.Run(new Action(delegate
                    {
                        try
                        {
                            RFIDLibraryUtility.InventoryPerfom(selectedReader);
                        }
                        catch (Exception ex)
                        {
                            deviceIdWhichRunsInventory = string.Empty;
                            ActiveReaderStatus.IsInventoryRunning = false;

                            Invoke((MethodInvoker)delegate
                            {
                                OutputText(ex.Message);
                            });
                        }
                        UpdateInventoryButtons();
                    }));

                    if (ActiveReaderStatus.BatchMode == BATCH_MODE.ENABLE)
                    {
                        BeginInvoke(new Action(delegate
                        {
                            OutputText("Inventory is running in batch mode...");
                        }));
                        ActiveReaderStatus.IsBatchModeInventoryRunning = true;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                // While reader is in a busy state from a previous inventory session, if the user attempts to start a new inventory session, the following exceptions is thrown. 
                if (ex.Message.Contains("Unknown read session is in place"))
                {
                    DialogResult result = MessageBox.Show("Unknown inventory is running(in batch mode). Click 'Inventory Stop'",
                                                          "Important",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Information,
                                                          MessageBoxDefaultButton.Button2);

                    ActiveReaderStatus.IsBatchModeInventoryRunning = (ActiveReaderStatus.BatchMode != BATCH_MODE.DISABLE);

                    deviceIdWhichRunsInventory = selectedReader.ID;
                    ActiveReaderStatus.IsInventoryRunning = true;

                    UpdateInventoryButtons();
                }
            }
            catch (Exception ex)
            {
                deviceIdWhichRunsInventory = string.Empty;
                ActiveReaderStatus.IsInventoryRunning = false;

                UpdateInventoryButtons();
                OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Stops the inventory.
        /// </summary>
        private void StopInventory()
        {
            try
            {
                if (ActiveReaderStatus.IsInventoryRunning)
                {
                    isStopPressed = true;

                    RFIDLibraryUtility.StopInventory(selectedReader);

                    if (ActiveReaderStatus.IsBatchModeInventoryRunning)
                    {
                        RFIDLibraryUtility.GetBatchedTags(selectedReader);
                        OutputText("Get Batched Tags : Successful");
                        ActiveReaderStatus.IsBatchModeInventoryRunning = false;
                    }

                    deviceIdWhichRunsInventory = string.Empty;
                    ActiveReaderStatus.IsInventoryRunning = false;

                    UpdateInventoryButtons();
                }
                else
                {
                    OutputText("Already inventory stopped...");
                }
            }
            catch
            {
                deviceIdWhichRunsInventory = selectedReader.ID;
                ActiveReaderStatus.IsInventoryRunning = true;

                UpdateInventoryButtons();
            }
        }

        /// <summary>
        /// Update inventory start/stop button enability.
        /// </summary>
        private void UpdateInventoryButtons()
        {
            Invoke(new Action(delegate
            {
                if (ActiveReaderStatus.IsInventoryRunning)
                {
                    btnInventoryStart.Enabled = false;
                    btnInventoryStop.Enabled = true;
                    settingsMenuItem.Enabled = false;
                    btnTagLocateStart.Enabled = false;

                    btnRead.Enabled = false;
                    btnWrite.Enabled = false;
                    btnLock.Enabled = false;
                    btnKill.Enabled = false;
                }
                else
                {
                    btnInventoryStart.Enabled = true;
                    btnInventoryStop.Enabled = false;
                    settingsMenuItem.Enabled = true;
                    btnTagLocateStart.Enabled = true;

                    btnRead.Enabled = true;
                    btnWrite.Enabled = true;
                    btnLock.Enabled = true;
                    btnKill.Enabled = true;
                }
            }));
        }

        /// <summary>
        /// Update tag locate start/stop button enability.
        /// </summary>
        private void UpdateTagLocateButtons()
        {
            Invoke(new Action(delegate
            {
                if (ActiveReaderStatus.IsTagLocateRunning)
                {
                    btnTagLocateStart.Enabled = false;
                    btnTagLocateStop.Enabled = true;
                    settingsMenuItem.Enabled = false;
                    btnInventoryStart.Enabled = btnPurgeTags.Enabled = false;

                    btnRead.Enabled = false;
                    btnWrite.Enabled = false;
                    btnLock.Enabled = false;
                    btnKill.Enabled = false;
                }
                else
                {
                    btnTagLocateStart.Enabled = true;
                    btnTagLocateStop.Enabled = false;
                    settingsMenuItem.Enabled = true;
                    btnInventoryStart.Enabled = btnPurgeTags.Enabled = true;

                    btnRead.Enabled = true;
                    btnWrite.Enabled = true;
                    btnLock.Enabled = true;
                    btnKill.Enabled = true;
                }
            }));
        }

        /// <summary>
        /// Clean the tag data and nventory list view.
        /// </summary>
        private void ResetTagInfo()
        {
            tagList.Clear();
            grdTags.Rows.Clear();
        }

        /// <summary>
        /// Logging messages into main screen.
        /// </summary>
        /// <param name="txt"></param>
        public void OutputText(string txt)
        {
            try
            {
                outputLinePos++;
                if (outputLinePos > MAX_OUTPUT_LINES)
                {
                    txtOutput.Clear();
                    outputLinePos = 0;
                }

                if (!String.IsNullOrEmpty(txt))
                {
                    txtOutput.SelectionStart = txtOutput.Text.Length;
                    txtOutput.AppendText(txt + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                {
                    //Todo
                }
            }
        }

        /// <summary>
        /// Process the recieved tag data.
        /// </summary>
        /// <param name="e"></param>
        private void ProcessTagDataReceivedEvent(ITagData e)
        {
            if (e != null)
            {
                string id = e.EPCId;

                // Tags which are not having EPCID 
                if (e.EPCId == null)
                {
                    // Show it as empty row.
                    id = "";
                }

                TagData data = TagUtility.GetTagData(1, id, e.TagSeenCount, e.RSSI);
                if (data != null)
                {
                    var tagDataArr = new TagData[] { data };
                    Invoke((MethodInvoker)delegate
                    {
                        ShowTagData(tagDataArr);
                    });
                }
            }
            else
            {
                try
                {
                    if (selectedReader != null)
                    {
                        var tagDataArr = TagUtility.GetReadTags(100, selectedReader);
                        if (tagDataArr != null)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShowTagData(tagDataArr);
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        OutputText(ex.Message);
                    });
                }
            }
        }

        /// <summary>
        /// Shows the tag data.
        /// </summary>
        private void ShowTagData(TagData[] tagDataArr)
        {
            foreach (TagData data in tagDataArr)
            {
                if (!tagList.ContainsKey(data.TagID))
                {
                    int tagRowID = grdTags.Rows.Add();
                    TagInfo tag = new TagInfo(data, tagRowID, data.TagSeenCount);
                    tagList.Add(data.TagID, tag);
                    grdTags["TagID", tagRowID].Value = tag.Tag.TagID;
                    grdTags["PeakRSSI", tagRowID].Value = tag.Tag.PeakRSSI;
                    grdTags["TagSeenCount", tagRowID].Value = tag.Tag.TagSeenCount;
                }
                else
                {
                    tagList[data.TagID].Tag = data;
                    tagList[data.TagID].TagSeenTotalCount += tagList[data.TagID].Tag.TagSeenCount;
                    grdTags["PeakRSSI", tagList[data.TagID].RowIndex].Value = tagList[data.TagID].Tag.PeakRSSI;
                    grdTags["TagSeenCount", tagList[data.TagID].RowIndex].Value = tagList[data.TagID].TagSeenTotalCount;
                }
            }
        }

        /// <summary>
        /// Process the recieved proximity precent.
        /// </summary>
        /// <param name="e"></param>
        private void ProcessProximityPercentReceivedEvent(ProximityPercentReceivedEventArgs e)
        {
            Invoke(new Action(delegate
            {
                lblTL.Text = e.ProximityPercent.ToString();
                proximityPrcentBar.Value = e.ProximityPercent;
            }));
        }

        /// <summary>
        /// Removing the reader from the device combo list when reader is disappeared.(unpaired)
        /// </summary>
        /// <param name="reader"></param>
        private void RemoveFromReaderList(IRfidReader reader)
        {
            bool found = false;
            RFIDReaderItem curItem = null;
            for (int n = 0; n < comboBoxReaders.Items.Count; n++)
            {
                curItem = (RFIDReaderItem)comboBoxReaders.Items[n];
                if (curItem.Id == reader.ID)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                comboBoxReaders.Items.Remove(curItem);
                if (comboBoxReaders.Items.Count == 0)
                {
                    btnConnectDisconnect.Enabled = false;
                }
                else
                {
                    comboBoxReaders.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Adding from device combo list when reader is appeared. (paired)
        /// </summary>
        /// <param name="deviceInfo"></param>
        private void AddToReaderList(RFIDReaderItemInfo deviceInfo, bool select = false)
        {
            bool found = false;
            for (int n = 0; n < comboBoxReaders.Items.Count; n++)
            {
                RFIDReaderItem item = (RFIDReaderItem)comboBoxReaders.Items[n];
                if ((item.Id == deviceInfo.HostAddress) || (isConnectedManually && item.Text.Contains(deviceInfo.PortNumber)))
                {
                    found = true;
                    if (select)
                    {
                        selectedReader = readerList.Find(i => i.ID.Equals(item.Id, StringComparison.OrdinalIgnoreCase));
                        comboBoxReaders.SelectedIndex = comboBoxReaders.Items.IndexOf(item);
                        comboBoxReaders.Enabled = true;
                    }

                    break;
                }
            }

            if (!found)
            {
                RFIDReaderItem item = new RFIDReaderItem(deviceInfo);
                comboBoxReaders.Items.Add(item);

                if (select)
                    comboBoxReaders.SelectedIndex = comboBoxReaders.Items.IndexOf(item);
            }

            if (comboBoxReaders.Items.Count == 1)
            {
                if (!select)
                    comboBoxReaders.SelectedIndex = 0;

                btnConnectDisconnect.Enabled = true;
            }
        }

        /// <summary>
        /// Show singulation control configuration dialog.
        /// </summary>
        private void ShowSingulationDlg()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (selectedReader != null)
            {
                Singulation frm = new Singulation(this);
                frm.Reader = selectedReader;
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Show reader other configuration dialog.
        /// </summary>
        private void ShowReaderConfiguration()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (selectedReader != null)
            {
                Configuration frmConfiguration = new Configuration(this);
                frmConfiguration.Reader = selectedReader;
                frmConfiguration.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Show reader antenna configuration dialog.
        /// </summary>
        private void ShowReaderAntennaConfiguration()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (selectedReader != null)
            {
                Antenna frmConfiguration = new Antenna(this);
                frmConfiguration.Reader = selectedReader;
                frmConfiguration.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Show regulatory dialog.
        /// </summary>
        private void ShowRegulatory(bool isConfigured)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (selectedReader != null)
            {
                Regulatory frmConfiguration = new Regulatory(this);
                frmConfiguration.IsRegionConfigured = isConfigured;
                frmConfiguration.Reader = selectedReader;
                frmConfiguration.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Show pre filters dialog.
        /// </summary>
        private void ShowPreFilter()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (selectedReader != null)
            {
                PreFilters frmConfiguration = new PreFilters(this);
                frmConfiguration.Reader = selectedReader;
                frmConfiguration.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Show reader capabilities dialog.
        /// </summary>
        private void ShowReaderCapabilities()
        {
            if (selectedReader != null)
            {

                try
                {
                    Capability frmCap = new Capability();
                    frmCap.Reader = selectedReader;
                    frmCap.ShowDialog();
                }
                catch (Exception ex)
                {
                    OutputText("Error getting reader capabilities, exception :" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Show reader version info dialog.
        /// </summary>
        private void ShowReaderVersionInfo()
        {
            if (selectedReader != null)
            {

                try
                {
                    VersionInfo frmCap = new VersionInfo();
                    frmCap.Reader = selectedReader;
                    frmCap.ShowDialog();
                }
                catch (Exception ex)
                {
                    OutputText("Error getting reader version information, exception :" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Pair a new device
        /// </summary>
        private void PairNewReader(IWin32Window owner)
        {
            var dialog = new SelectBluetoothDeviceDialog
            {
                ShowAuthenticated = false,
                ShowRemembered = false,
                ShowUnknown = true,
                AddNewDeviceWizard = true
            };

            dialog.ShowDialog(owner);
        }

        /// <summary>
        /// Starts the tag locate.
        /// </summary>
        private void StartTagLocate()
        {
            try
            {
                if (!ActiveReaderStatus.IsTagLocateRunning)
                {
                    // Clean the inventory tag data list
                    proximityPrcentBar.Value = 0;

                    deviceIdWhichRunsTagLocate = selectedReader.ID;
                    ActiveReaderStatus.IsTagLocateRunning = true;

                    Task.Run(new Action(delegate
                    {
                        try
                        {
                            RFIDLibraryUtility.PerfomTagLocate(selectedReader, txtTagId.Text);
                        }
                        catch (Exception ex)
                        {
                            deviceIdWhichRunsTagLocate = string.Empty;
                            ActiveReaderStatus.IsTagLocateRunning = false;

                            Invoke((MethodInvoker)delegate
                            {
                                OutputText(ex.Message);
                            });
                        }
                        UpdateTagLocateButtons();
                    }));
                }
                else
                {
                    deviceIdWhichRunsTagLocate = string.Empty;
                    ActiveReaderStatus.IsTagLocateRunning = false;

                    UpdateTagLocateButtons();
                }
            }
            catch (InvalidOperationException ioex)
            {
                deviceIdWhichRunsTagLocate = string.Empty;
                ActiveReaderStatus.IsTagLocateRunning = false;

                OutputText(ioex.ToString());
            }
            catch (Exception ex)
            {
                deviceIdWhichRunsTagLocate = string.Empty;
                ActiveReaderStatus.IsTagLocateRunning = false;

                UpdateTagLocateButtons();
                OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Stops the tag locate.
        /// </summary>
        private void StopTagLocate()
        {
            try
            {
                if (ActiveReaderStatus.IsTagLocateRunning)
                {
                    RFIDLibraryUtility.StopTagLocate(selectedReader);

                    deviceIdWhichRunsTagLocate = string.Empty;
                    ActiveReaderStatus.IsTagLocateRunning = false;

                    UpdateTagLocateButtons();
                }
                else
                {
                    deviceIdWhichRunsTagLocate = string.Empty;
                    ActiveReaderStatus.IsTagLocateRunning = false;

                    OutputText("Already locate tag stopped...");
                }
            }
            catch
            {
                deviceIdWhichRunsTagLocate = selectedReader.ID;
                ActiveReaderStatus.IsTagLocateRunning = true;

                UpdateTagLocateButtons();
            }
        }

        private void ReadTagData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnRead.Enabled = false;

                if (string.IsNullOrEmpty(txtTagPattern.Text))
                    throw new Exception("Tag Pattern filed should not be empty.");

                selectedReader.AccessOperations.TagRead.MemoryBank = (MEMORY_BANK)cmbMemoryBank.SelectedIndex;

                if (!string.IsNullOrEmpty(txtLength.Text))
                    selectedReader.AccessOperations.TagRead.Length = short.Parse(txtLength.Text);

                if (!string.IsNullOrEmpty(txtOffset.Text))
                    selectedReader.AccessOperations.TagRead.Offset = short.Parse(txtOffset.Text);

                if (!string.IsNullOrEmpty(txtPassword.Text))
                    selectedReader.AccessOperations.TagRead.Password = txtPassword.Text;

                if (!string.IsNullOrEmpty(txtTagPattern.Text))
                    selectedReader.AccessOperations.TagRead.TagPattern = DataUtility.HexStringToByteArray(txtTagPattern.Text);

                Task.Run(new Action(delegate
                {
                    try
                    {
                        RFIDLibraryUtility.ReadTag(selectedReader);
                        BeginInvoke((MethodInvoker)delegate
                        {
                            txtData.Text = DataUtility.ByteArrayToHexString(selectedReader.AccessOperations.TagRead.TagData);
                        });
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke((MethodInvoker)delegate { OutputText(ex.Message); });
                    }

                    BeginInvoke((MethodInvoker)delegate { btnRead.Enabled = true; Cursor.Current = Cursors.Default; });
                }));
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
                btnRead.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void WriteTagData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnWrite.Enabled = false;

                if (string.IsNullOrEmpty(txtTagPattern.Text))
                    throw new Exception("Tag Pattern filed should not be empty.");
                if (string.IsNullOrEmpty(txtData.Text))
                    throw new Exception("Tag Data filed should not be empty.");

                selectedReader.AccessOperations.TagWrite.MemoryBank = (MEMORY_BANK)cmbMemoryBank.SelectedIndex;

                if (!string.IsNullOrEmpty(txtOffset.Text))
                    selectedReader.AccessOperations.TagWrite.Offset = short.Parse(txtOffset.Text);

                if (!string.IsNullOrEmpty(txtPassword.Text))
                    selectedReader.AccessOperations.TagWrite.Password = txtPassword.Text;

                if (!string.IsNullOrEmpty(txtTagPattern.Text))
                    selectedReader.AccessOperations.TagWrite.TagPattern = DataUtility.HexStringToByteArray(txtTagPattern.Text);

                selectedReader.AccessOperations.TagWrite.TagData = DataUtility.HexStringToByteArray(txtData.Text);

                Task.Run(new Action(delegate
                {
                    try
                    {
                        RFIDLibraryUtility.WriteTag(selectedReader);
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke((MethodInvoker)delegate { OutputText(ex.Message); });
                    }

                    BeginInvoke((MethodInvoker)delegate { btnWrite.Enabled = true; Cursor.Current = Cursors.Default; });
                }));
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);

                btnWrite.Enabled = true;
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void LockTagData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnLock.Enabled = false;

                if (string.IsNullOrEmpty(txtTagPatternLock.Text))
                    throw new Exception("Tag Pattern filed should not be empty.");

                selectedReader.AccessOperations.TagLock.MemoryBank = (LOCK_MEMORY_BANK)cmbMemoryBankLock.SelectedIndex;
                selectedReader.AccessOperations.TagLock.Permission = (ACCESS_PERMISSIONS)cmbLockPrivilage.SelectedIndex;

                if (!string.IsNullOrEmpty(txtPasswordLock.Text))
                    selectedReader.AccessOperations.TagLock.Password = txtPasswordLock.Text;

                if (!string.IsNullOrEmpty(txtTagPatternLock.Text))
                    selectedReader.AccessOperations.TagLock.TagPattern = DataUtility.HexStringToByteArray(txtTagPatternLock.Text);

                Task.Run(new Action(delegate
                {
                    try
                    {
                        RFIDLibraryUtility.LockTag(selectedReader);
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke((MethodInvoker)delegate { OutputText(ex.Message); });
                    }

                    BeginInvoke((MethodInvoker)delegate { btnLock.Enabled = true; Cursor.Current = Cursors.Default; });
                }));
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);

                btnLock.Enabled = true;
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void KillTag()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnKill.Enabled = false;

                if (string.IsNullOrEmpty(txtTagPatternKill.Text))
                    throw new Exception("Tag Pattern filed should not be empty.");

                if (!string.IsNullOrEmpty(txtPasswordKill.Text))
                    selectedReader.AccessOperations.TagKill.Password = txtPasswordKill.Text;

                if (!string.IsNullOrEmpty(txtTagPatternKill.Text))
                    selectedReader.AccessOperations.TagKill.TagPattern = DataUtility.HexStringToByteArray(txtTagPatternKill.Text);

                Task.Run(new Action(delegate
                {
                    try
                    {
                        RFIDLibraryUtility.KillTag(selectedReader);
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke((MethodInvoker)delegate { OutputText(ex.Message); });
                    }

                    BeginInvoke((MethodInvoker)delegate { btnKill.Enabled = true; Cursor.Current = Cursors.Default; });
                }));
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);

                btnKill.Enabled = true;
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        /*
        private void GetAttribute()
        {
            int attribute;
            int.TryParse(txtAttribute.Text, out attribute);
            if (attribute <= 0)
            {
                OutputText("Attribute should be a number and needs to be greater than zero.");
            }

            try
            {
                var rsm = RFIDLibraryUtility.GetAttribute(selectedReader, attribute);
                txtType.Text = rsm.Type ?? string.Empty;
                txtValue.Text = rsm.Value ?? string.Empty;
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }
        */

        /*
        private void SetAttribute()
        {
            int attribute;
            int.TryParse(txtAttribute.Text, out attribute);
            if (attribute <= 0)
            {
                OutputText("Attribute should be a number and needs to be greater than zero.");
            }

            if (string.IsNullOrEmpty(txtType.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                OutputText("Attribute type and value should not be null.");
            }

            try
            {
                RFIDLibraryUtility.SetAttribute(selectedReader, attribute, txtType.Text, txtValue.Text);
            }
            catch (Exception ex)
            {
                OutputText(ex.Message);
            }
        }
        */

        #endregion
    }
}
