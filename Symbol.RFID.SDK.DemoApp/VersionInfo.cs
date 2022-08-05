using System;
using System.Windows.Forms;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class VersionInfo : Form
    {
        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public VersionInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Event Handlers

        private void VersionInfo_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Load reader capabilities from connected reader.
        /// </summary>
        private void LoadSettings()
        {
            var versioninfo = RFIDLibraryUtility.GetVersionInfo(this.Reader);
            txtFirmware.Text = versioninfo.Firmware;
            txtNGE.Text = versioninfo.NGE.ToString();
            txtHardware.Text = versioninfo.Hardware.ToString();
            txtBluetooth.Text = versioninfo.Bluetooth.ToString();
            if (versioninfo.Bluetooth.Major == 0)
            {
                lblBluetooth.Visible = txtBluetooth.Visible = false;
            }
        }

        #endregion
    }
}
