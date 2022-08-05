using Symbol.RFID.SDK.Domain.Reader;
using System;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class Antenna : Form
    {
        #region Private Fields

        private frmMain mainForm = null;

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public Antenna(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Form Event Handlers

        private void AntCofiguration_Load(object sender, EventArgs e)
        {
            GetLinkProfiles();
            GetAntennaConfigurations();

        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsNumeric(e);
        }

        private void btnApplyAntConfig_Click(object sender, EventArgs e)
        {
            SetAntennaConfigurations();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Retrieve supported link profiles from the selected reader. 
        /// </summary>
        private void GetLinkProfiles()
        {
            try
            {
                var linkProfiles = this.Reader.Configurations.Antennas[0].SupportedLinkProfiles;
                foreach (var item in linkProfiles)
                {
                    cmbLinkProfile.Items.Insert(item.Key, item.Value);
                }

            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Retrieve antenna configuration value from the selected reader. 
        /// </summary>
        private void GetAntennaConfigurations()
        {
            try
            {
                if (Reader != null)
                {
                    var antennaConfig = RFIDLibraryUtility.GetAntennaConfigurations(this.Reader);
                    txtPowerIndex.Text = antennaConfig.TransmitPowerIndex.ToString();
                    txtTari.Text = antennaConfig.Tari.ToString();
                    cmbLinkProfile.SelectedIndex = antennaConfig.LinkProfile;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }        

        /// <summary>
        /// Set power antenna configuration value from the selected reader. 
        /// </summary>
        /// <returns>true if set successfully, false if failed.</returns>
        private bool SetAntennaConfigurations()
        {
            var success = false;
            try
            {
                if (Reader != null)
                {
                    var antennaConfig = new AntennaConfiguration();
                    antennaConfig.LinkProfile = (ushort)cmbLinkProfile.SelectedIndex;
                    antennaConfig.Tari = Convert.ToUInt32(txtTari.Text);
                    antennaConfig.TransmitPowerIndex = ushort.Parse(txtPowerIndex.Text);

                    RFIDLibraryUtility.SetAntennaConfigurations(this.Reader, antennaConfig);
                    success = true; 
                }
                return success;
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
                return success;
            }
        }

        #endregion        
    }
}
