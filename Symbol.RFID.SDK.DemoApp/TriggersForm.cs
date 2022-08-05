using System;
using System.Windows.Forms;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class TriggersForm : Form
    {
        #region Fields

        private frmMain m_AppForm = null;
        public static TriggerInfo triggerInfo;

        #endregion

        #region Constructors

        public TriggersForm(frmMain mainForm)
        {
            InitializeComponent();
            m_AppForm = mainForm;
        }

        #endregion

        #region Form Event Handlers

        private void StartTriggerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStartGroupBox();
            if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE)
            {

            }
            else if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC)
            {
                this.startGroupBox.Controls.Add(this.periodicGroupBox);
            }
            else if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD)
            {
                this.startGroupBox.Controls.Add(this.startHandHeldTriggerGroupBox);
            }
        }

        private void StopTrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStopGroupBox();
            if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE)
            {

            }
            else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION)
            {
                this.stopGroupBox.Controls.Add(this.durationGB);
            }
            else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_TAG_OBSERVATION_WITH_TIMEOUT)
            {
                this.stopGroupBox.Controls.Add(this.tagObservationGB);
            }
            else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_N_ATTEMPTS_WITH_TIMEOUT)
            {
                this.stopGroupBox.Controls.Add(this.nAttemptsGB);
            }
            else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_HANDHELD_WITH_TIMEOUT)
            {
                this.stopGroupBox.Controls.Add(this.stopHandHeldTriggerGroupBox);
            }
        }

        private void TriggerInfoApplyButton_Click(object sender, EventArgs e)
        {
            SaveTriggerParams();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Triggers_Load(object sender, EventArgs e)
        {
            InitDefaultValues();
            LoadTriggerParams();
        }

        private void StopTriggerReleased_CB_Click(object sender, EventArgs e)
        {
            this.stopTriggerPressed_CB.Checked = false;
        }

        private void StopTriggerPressed_CB_Click(object sender, EventArgs e)
        {
            this.stopTriggerReleased_CB.Checked = false;
        }

        private void StartTriggerPressed_CB_Click(object sender, EventArgs e)
        {
            this.startTriggerReleased_CB.Checked = false;
        }

        private void StartTriggerReleased_CB_Click(object sender, EventArgs e)
        {
            this.startTriggerPressed_CB.Checked = false;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Clear start trigger UI controls.
        /// </summary>
        private void ClearStartGroupBox()
        {
            this.startGroupBox.Controls.Remove(this.periodicGroupBox);
            this.startGroupBox.Controls.Remove(this.startHandHeldTriggerGroupBox);
        }

        /// <summary>
        /// Clear stop trigger UI controls.
        /// </summary>
        private void ClearStopGroupBox()
        {
            this.stopGroupBox.Controls.Remove(this.durationGB);
            this.stopGroupBox.Controls.Remove(this.GPITimeoutGB);
            this.stopGroupBox.Controls.Remove(this.tagObservationGB);
            this.stopGroupBox.Controls.Remove(this.nAttemptsGB);
            this.stopGroupBox.Controls.Remove(this.stopHandHeldTriggerGroupBox);
        }

        /// <summary>
        /// Initialize default values.
        /// </summary>
        private void InitDefaultValues()
        {
            startPeriod_TB.Text = "1000";
            startTriggerPressed_CB.Checked = true;

            stopDuration_TB.Text = "10000";
            stopTriggerTagOb_TB.Text = "10000";
            stopTagObservation_TB.Text = "100";
            stopTriggerNAttTimeOut_TB.Text = "10000";
            stopNumAttempt_TB.Text = "10";
            handHeldTriggerTimeout_TB.Text = "10000";
            stopTriggerReleased_CB.Checked = true;
        }

        /// <summary>
        /// Apply provided trigger param values to the connected reader.
        /// </summary>
        private void SaveTriggerParams()
        {
            try
            {
                if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE)
                {
                    triggerInfo.StartTrigger.Type = START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE;
                }
                else if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC)
                {
                    triggerInfo.StartTrigger.Type = START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC;

                    if (!String.IsNullOrEmpty((startPeriod_TB.Text)))
                        triggerInfo.StartTrigger.Periodic.Period = uint.Parse(startPeriod_TB.Text);
                }
                else if (startTriggerType_CB.SelectedIndex == (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD)
                {
                    triggerInfo.StartTrigger.Type = START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD;

                    if (startTriggerPressed_CB.Checked)
                        triggerInfo.StartTrigger.Handheld.HandheldEvent = HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_PRESSED;
                    else if (startTriggerReleased_CB.Checked)
                        triggerInfo.StartTrigger.Handheld.HandheldEvent = HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_RELEASED;
                }

                if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE)
                {
                    triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE;
                }
                else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION)
                {
                    triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION;
                    if (!String.IsNullOrEmpty(this.stopDuration_TB.Text))
                        triggerInfo.StopTrigger.Duration = uint.Parse(this.stopDuration_TB.Text);
                }
                else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_TAG_OBSERVATION_WITH_TIMEOUT)
                {
                    triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_TAG_OBSERVATION_WITH_TIMEOUT;
                    if (!String.IsNullOrEmpty(stopTagObservation_TB.Text))
                        triggerInfo.StopTrigger.TagObservation.N = ushort.Parse(stopTagObservation_TB.Text);
                    if (!String.IsNullOrEmpty(stopTriggerTagOb_TB.Text))
                        triggerInfo.StopTrigger.TagObservation.Timeout = uint.Parse(stopTriggerTagOb_TB.Text);
                }
                else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_N_ATTEMPTS_WITH_TIMEOUT)
                {
                    triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_N_ATTEMPTS_WITH_TIMEOUT;
                    if (!String.IsNullOrEmpty(stopNumAttempt_TB.Text))
                        triggerInfo.StopTrigger.NumAttempts.N = ushort.Parse(stopNumAttempt_TB.Text);
                    if (!String.IsNullOrEmpty(stopTriggerNAttTimeOut_TB.Text))
                        triggerInfo.StopTrigger.NumAttempts.Timeout = uint.Parse(stopTriggerNAttTimeOut_TB.Text);
                }
                else if (stopTriggerType_CB.SelectedIndex == (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_HANDHELD_WITH_TIMEOUT)
                {
                    triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_HANDHELD_WITH_TIMEOUT;
                    if (!String.IsNullOrEmpty(handHeldTriggerTimeout_TB.Text))
                        triggerInfo.StopTrigger.Handheld.Timeout = uint.Parse(handHeldTriggerTimeout_TB.Text);

                    if (stopTriggerPressed_CB.Checked)
                        triggerInfo.StopTrigger.Handheld.HandheldEvent = HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_PRESSED;
                    else if (stopTriggerReleased_CB.Checked)
                        triggerInfo.StopTrigger.Handheld.HandheldEvent = HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_RELEASED;
                }
            }
            catch (Exception ex)
            {
                m_AppForm.OutputText("Error saving TriggerParams. " + ex.Message);
            }
        }

        /// <summary>
        /// Load trigger param values form connected reader.
        /// </summary>
        private void LoadTriggerParams()
        {
            try
            {
                if (triggerInfo.StartTrigger.Type == START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE)
                {
                    startTriggerType_CB.SelectedIndex = (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE;
                }
                else if (triggerInfo.StartTrigger.Type == START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC)
                {
                    startTriggerType_CB.SelectedIndex = (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC;

                    startPeriod_TB.Text = triggerInfo.StartTrigger.Periodic.Period.ToString();
                }
                else if (triggerInfo.StartTrigger.Type == START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD)
                {
                    startTriggerType_CB.SelectedIndex = (int)START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD;

                    if (triggerInfo.StartTrigger.Handheld.HandheldEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_PRESSED)
                    {
                        startTriggerPressed_CB.Checked = true;
                        startTriggerReleased_CB.Checked = false;
                    }
                    else if (triggerInfo.StartTrigger.Handheld.HandheldEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_RELEASED)
                    {
                        startTriggerPressed_CB.Checked = false;
                        startTriggerReleased_CB.Checked = true;
                    }
                }

                if (triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE)
                {
                    stopTriggerType_CB.SelectedIndex = (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE;
                }
                else if (triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION ||
                         triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_ON_ACCESS_COUNT)
                {
                    stopTriggerType_CB.SelectedIndex = (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION;
                    this.stopDuration_TB.Text = triggerInfo.StopTrigger.Duration.ToString();
                }
                else if (triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_TAG_OBSERVATION_WITH_TIMEOUT)
                {
                    stopTriggerType_CB.SelectedIndex = (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_TAG_OBSERVATION_WITH_TIMEOUT;
                    stopTagObservation_TB.Text = triggerInfo.StopTrigger.TagObservation.N.ToString();
                    stopTriggerTagOb_TB.Text = triggerInfo.StopTrigger.TagObservation.Timeout.ToString();
                }
                else if (triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_N_ATTEMPTS_WITH_TIMEOUT)
                {
                    stopTriggerType_CB.SelectedIndex = (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_N_ATTEMPTS_WITH_TIMEOUT;
                    stopNumAttempt_TB.Text = triggerInfo.StopTrigger.NumAttempts.N.ToString();
                    stopTriggerNAttTimeOut_TB.Text = triggerInfo.StopTrigger.NumAttempts.Timeout.ToString();
                }
                else if (triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_HANDHELD_WITH_TIMEOUT)
                {
                    stopTriggerType_CB.SelectedIndex = (int)STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_HANDHELD_WITH_TIMEOUT;
                    handHeldTriggerTimeout_TB.Text = triggerInfo.StopTrigger.Handheld.Timeout.ToString();

                    if (triggerInfo.StopTrigger.Handheld.HandheldEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_PRESSED)
                    {
                        stopTriggerPressed_CB.Checked = true;
                        stopTriggerReleased_CB.Checked = false;
                    }
                    else if (triggerInfo.StopTrigger.Handheld.HandheldEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_RELEASED)
                    {
                        stopTriggerPressed_CB.Checked = false;
                        stopTriggerReleased_CB.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                m_AppForm.OutputText("Error loading TriggerParams. " + ex.Message);
            }
        }


        #endregion
    }
}