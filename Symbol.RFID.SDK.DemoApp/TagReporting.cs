using System;
using System.Windows.Forms;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class TagReportingForm : Form
    {
        #region Fields

        private frmMain mainForm = null;
        private ReportConfig reportConfig;

        #endregion

        #region Constructors

        public TagReportingForm(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Form Event Handlers

        private void TagReporting_Load(object sender, EventArgs e)
        {
            GetTagReporting();
        }
        
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplyTagReporting(); 
            SetReportUniqueTags();
            SetBatchMode();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Load trigger param values form connected reader.
        /// </summary>
        private void GetTagReporting()
        {
            try
            {
                if (Reader != null)
                {
                    reportConfig = RFIDLibraryUtility.GetTagReportConfig(Reader);

                    chkChannelIndex.Checked = reportConfig.ChannelIndex;
                    chkFirstSeenTime.Checked = reportConfig.FirstSeenTime;
                    chkLastSeenTime.Checked = reportConfig.LastSeenTime;
                    chkPC.Checked = reportConfig.PC;
                    chkPhase.Checked = reportConfig.Phase;
                    chkRSSI.Checked = reportConfig.RSSI;
                    chkTagSeenCount.Checked = reportConfig.TagSeenCount;

                    chkReportUniqueTags.Checked = this.Reader.Configurations.ReportUniqueTags;

                    BATCH_MODE batchMode = RFIDLibraryUtility.GetBatchMode(this.Reader);
                    string strBatchMode = "";
                    switch (batchMode)
                    {
                        case BATCH_MODE.AUTO:
                            strBatchMode = "AUTO";
                            break;
                        case BATCH_MODE.DISABLE:
                            strBatchMode = "DISABLE";
                            break;
                        case BATCH_MODE.ENABLE:
                            strBatchMode = "ENABLE";
                            break;
                    }
                    cmbBatchMode.SelectedIndex = cmbBatchMode.Items.IndexOf(strBatchMode);
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText("Error loading ReportConfigParam. " + ex.Message);
            }
        }

        /// <summary>
        /// Apply provided trigger param values to the connected reader.
        /// </summary>
        private void ApplyTagReporting()
        {
            try
            {
                reportConfig.ChannelIndex = chkChannelIndex.Checked;
                reportConfig.FirstSeenTime = chkFirstSeenTime.Checked;
                reportConfig.LastSeenTime = chkLastSeenTime.Checked;
                reportConfig.PC = chkPC.Checked;
                reportConfig.Phase = chkPhase.Checked;
                reportConfig.RSSI = chkRSSI.Checked;
                reportConfig.TagSeenCount = chkTagSeenCount.Checked;

                RFIDLibraryUtility.SetTagReportConfig(Reader, reportConfig);
            }
            catch (Exception ex)
            {
                mainForm.OutputText("Error saving ReportConfigParam. " + ex.Message);
            }
        }

        /// <summary>
        /// Set batch mode value from the selected reader. 
        /// </summary>
        private bool SetBatchMode()
        {
            try
            {
                if (Reader != null)
                {
                    switch (cmbBatchMode.Text)
                    {
                        case "ENABLE":
                            {
                                RFIDLibraryUtility.SetBatchMode(this.Reader, BATCH_MODE.ENABLE);
                                break;
                            }
                        case "DISABLE":
                            {
                                RFIDLibraryUtility.SetBatchMode(this.Reader, BATCH_MODE.DISABLE);
                                break;
                            }
                        case "AUTO":
                            {
                                Reader.Configurations.BatchModeConfig = BATCH_MODE.AUTO;
                                break;
                            }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
                return false;
            }
        }

        private bool SetReportUniqueTags()
        {
            try
            {
                this.Reader.Configurations.ReportUniqueTags = chkReportUniqueTags.Checked;
                return true;
            }
            catch (Exception ex)
            {
                mainForm.OutputText("Error saving SetReportUniqueTags. " + ex.Message);
                return false;
            }
        }

        #endregion
    }
}
