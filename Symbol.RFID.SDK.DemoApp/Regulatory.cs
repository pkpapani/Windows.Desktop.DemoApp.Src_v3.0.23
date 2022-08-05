using Symbol.RFID.SDK.Domain.Reader;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class Regulatory : Form
    {
        #region Consts

        private const string errorRetriveRegionConfiguration = "Retrieve the device region configuration is failed.";

        #endregion

        #region Private Fields

        private frmMain mainForm = null;
        private Dictionary<string, string> supportedRegions = null;
        private RegulatoryConfig selectedRegulatoryConfig = null;

        private string selectRegionText = "Select Region";

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        public bool IsRegionConfigured { private get; set; }

        #endregion

        #region Constructors

        public Regulatory(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Form Event Handlers

        private void Regulatory_Load(object sender, EventArgs e)
        {
            GetAllRegions();
            PopulateControls();
        }

        private void btnApplyRegulatory_Click(object sender, EventArgs e)
        {
            SetRegion();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = cmbRegions.SelectedItem;
            var key = supportedRegions.FirstOrDefault(o => o.Value == val.ToString()).Key;
            channelsList.Items.Clear();

            try
            {
                if (key == null || key.ToString() == selectRegionText)
                {
                    btnApplyRegulatory.Enabled = false;
                    lblHopping.Text = "";
                }
                else
                {
                    selectedRegulatoryConfig = Reader.Configurations.GetRegionConfiguration(key.ToString());
                    if (selectedRegulatoryConfig == null)
                        throw new ApplicationException(errorRetriveRegionConfiguration);

                    lblHopping.Text = selectedRegulatoryConfig.Hopping.ToString();
                    channelsList.Enabled = selectedRegulatoryConfig.Hopping;
                    channelsList.Items.AddRange(selectedRegulatoryConfig.Channels);

                    var selectedChannels = Reader.Configurations.GetEnabledChannels();

                    if (Reader.Configurations.RegulatoryConfig != null && Reader.Configurations.RegulatoryConfig.Region == selectedRegulatoryConfig.Region)
                    {
                        for (int i = 0; i < channelsList.Items.Count; i++)
                        {
                            var contains = selectedChannels.Contains(channelsList.Items[i].ToString());
                            channelsList.SetItemChecked(i, contains);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < channelsList.Items.Count; i++)
                        {
                            channelsList.SetItemChecked(i, true);
                        }
                    }

                    btnApplyRegulatory.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Get all supported regions form the selected reader. 
        /// </summary>
        private void GetAllRegions()
        {
            try
            {
                if (Reader != null)
                {
                    supportedRegions = this.Reader.Configurations.SupportedRegions;
                    cmbRegions.Items.AddRange(new string[] { selectRegionText });
                    cmbRegions.Items.AddRange(supportedRegions.Values.ToArray());
                    cmbRegions.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Retrieve region from the selected reader. 
        /// </summary>
        private void PopulateControls()
        {
            if (Reader == null)
            {
                var ex = new ApplicationException("The selected reader should not be null.");
                mainForm.OutputText(ex.Message + Environment.NewLine);
                throw ex;
            }

            Regulatory regulatory = this;
            if (Reader.Configurations.RegulatoryConfig != null)
            {
                var region = supportedRegions.FirstOrDefault(o => o.Key == Reader.Configurations.RegulatoryConfig.Region).Value;
                regulatory.cmbRegions.SelectedIndex = regulatory.cmbRegions.Items.IndexOf(region);
            }

            if (!IsRegionConfigured)
            {
                regulatory.Text = "Select the Region";
                regulatory.ControlBox = false;

                btnApplyRegulatory.Enabled = false;
                cmbRegions.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Sets region value for the selected reader. 
        /// </summary>
        private void SetRegion()
        {
            try
            {
                if (Reader != null)
                {
                    var region = new RegulatoryConfig();
                    region.Region = supportedRegions.FirstOrDefault(o => o.Value == cmbRegions.GetItemText(cmbRegions.SelectedItem)).Key;
                    region.Channels = channelsList.CheckedItems.OfType<string>().ToArray();
                    region.Hopping = selectedRegulatoryConfig.Hopping;

                    Reader.Configurations.RegulatoryConfig = region;
                }
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        #endregion
    }
}
