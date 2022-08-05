using System;
using System.Windows.Forms;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class Singulation : Form
    {
        #region Private Fields

        private frmMain mainForm = null;
        private ushort curAntennaID = 0;

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }
        public string Result { get; internal set; }

        #endregion

        #region Constructors

        public Singulation(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Form Event Handlers     

        private void FrmSingulation_Load(object sender, EventArgs e)
        {
            LoadSingulation();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            SaveSingulation();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsNumeric(e);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Load singulation specific configuration settings from connected reader.
        /// </summary>
        private void LoadSingulation()
        {
            try
            {
                cmbSession.Items.AddRange(Enum.GetNames(typeof(SESSION)));
                cmbInventoryState.Items.AddRange(Enum.GetNames(typeof(STATE)));
                cmbSlFlag.Items.AddRange(Enum.GetNames(typeof(SL_FLAG)));
                txtTagPopulation.Text = "30";

                var singulation = RFIDLibraryUtility.GetSingulation(this.Reader, curAntennaID);

                cmbSession.SelectedIndex = cmbSession.Items.IndexOf(singulation.Session.ToString());
                cmbInventoryState.SelectedIndex = cmbInventoryState.Items.IndexOf(singulation.State.ToString());
                cmbSlFlag.SelectedIndex = cmbSlFlag.Items.IndexOf(singulation.SLFlag.ToString());
                txtTagPopulation.Text = singulation.TagPopulation.ToString();
            }
            catch (Exception ex)
            {
                mainForm.OutputText("Error loading singulationControl settings. " + ex.Message);
            }
        }

        /// <summary>
        /// Apply singulation settings values to the connected reader.
        /// </summary>
        /// <returns>true if applied successfully, false if failed.</returns>
        private bool SaveSingulation()
        {
            try
            {
                ushort population = 30;
                if (!ushort.TryParse(txtTagPopulation.Text, out population))
                {
                    mainForm.OutputText("Error saving settings, singulationControl incorrect tag population : " + txtTagPopulation.Text);
                }

                var singulationControl = new SingulationControl();
                singulationControl.Session = (SESSION)cmbSession.SelectedIndex;
                singulationControl.State = (STATE)cmbInventoryState.SelectedIndex;

                SL_FLAG slflag;
                Enum.TryParse<SL_FLAG>(cmbSlFlag.SelectedItem.ToString(), out slflag);
                singulationControl.SLFlag = slflag;

                singulationControl.TagPopulation = population;

                RFIDLibraryUtility.SetSingulation(this.Reader, curAntennaID, singulationControl);
                return true;
            }
            catch (Exception ex)
            {
                mainForm.OutputText("Error saving singulationControl settings. " + ex.Message);
                return false;
            }
        }

        #endregion
    }
}
