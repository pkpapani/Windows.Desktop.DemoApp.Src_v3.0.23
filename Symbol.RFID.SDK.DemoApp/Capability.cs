using System;
using System.Windows.Forms;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class Capability : Form
    {
        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public Capability()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Event Handlers

        private void FrmCapabilities_Load(object sender, EventArgs e)
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
            var capabilitiess = RFIDLibraryUtility.GetCapabilities(this.Reader);
            txtModelName.Text = capabilitiess.ModelName;
            txtSerialNumber.Text = capabilitiess.SerialNumber;
            txtManufactureName.Text = capabilitiess.ManufactureName;
            txtManufactureDate.Text = capabilitiess.ManufacturingDate;
        }

        #endregion
    }
}
