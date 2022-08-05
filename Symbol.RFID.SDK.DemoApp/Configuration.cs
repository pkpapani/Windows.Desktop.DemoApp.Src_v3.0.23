using Symbol.RFID.SDK.Domain.Reader;
using System;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class Configuration : Form
    {
        #region Private Fields

        private frmMain mainForm = null;

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public Configuration(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Form Event Handlers

        private void Configuration_Load(object sender, EventArgs e)
        {
            cmbBeeperVolume.Items.AddRange(Enum.GetNames(typeof(BEEPER_VOLUME)));            
            GetBeeperVolume();
            cmbTriggerMode.Items.AddRange(Enum.GetNames(typeof(TRIGGER_MODE)));
            GetTriggerMode();
            GetDynamicPower();
        }

        private void BtnGetBeeperVolume_Click(object sender, EventArgs e)
        {
            GetBeeperVolume();
        }

        private void BtnSetBeeperVolume_Click(object sender, EventArgs e)
        {
            SetBeeperVolume();
        }

        private void btnGetDP_Click(object sender, EventArgs e)
        {
            GetDynamicPower();
        }

        private void brtnSetDP_Click(object sender, EventArgs e)
        {
            SetDynamicPower();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Retrieve beeper volume value from the selected reader. 
        /// </summary>
        private void GetBeeperVolume()
        {
            try
            {
                if (Reader != null)
                {
                    BEEPER_VOLUME beeperVolume = RFIDLibraryUtility.GetBeeperVolume(this.Reader);
                    cmbBeeperVolume.SelectedIndex = (int)beeperVolume;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Set beeper volume value from the selected reader. 
        /// </summary>
        private void SetBeeperVolume()
        {
            try
            {
                if (Reader != null)
                {
                    RFIDLibraryUtility.SetBeeperVolume(this.Reader, (BEEPER_VOLUME)cmbBeeperVolume.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }


        /// <summary>
        /// Retrieve trigger mode value from the selected reader. 
        /// </summary>
        private void GetTriggerMode()
        {
            try
            {
                if (Reader != null)
                {
                    TRIGGER_MODE triggerMode = RFIDLibraryUtility.GetTriggerMode(this.Reader);
                    cmbTriggerMode.SelectedIndex = (int)triggerMode;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Set trigger mode value from the selected reader. 
        /// </summary>
        private void SetTriggerMode()
        {
            try
            {
                if (Reader != null)
                {
                    RFIDLibraryUtility.SetTriggerMode(this.Reader, (TRIGGER_MODE)cmbTriggerMode.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Retrieve dynamic power enabled/disabled from the selected reader. 
        /// </summary>
        private void GetDynamicPower()
        {
            try
            {
                if (Reader != null)
                {
                    cbDynamicPower.Checked = (this.Reader.Configurations.DynamicPower == DYNAMIC_POWER.ENABLE);
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Set dynamic power enabled/disabled from the selected reader. 
        /// </summary>
        private void SetDynamicPower()
        {
            try
            {
                if (Reader != null)
                {
                    this.Reader.Configurations.DynamicPower = (cbDynamicPower.Checked ? DYNAMIC_POWER.ENABLE : DYNAMIC_POWER.DISABLE);
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        #endregion

        private void btnTriggerModeGet_Click(object sender, EventArgs e)
        {
            GetTriggerMode();
        }

        private void btnTriggerModeSet_Click(object sender, EventArgs e)
        {
            SetTriggerMode(); 
        }
    }
}
