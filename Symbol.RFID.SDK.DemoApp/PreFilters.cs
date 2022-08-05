using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Symbol.RFID.SDK.DemoApp.Entities;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class PreFilters : Form
    {
        #region Private Fields

        private frmMain mainForm = null;

        private FilterData[] ConfiguredFilters = null;
        private int filterIndex = 0;

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public PreFilters(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Form Event Handlers

        private void PreFilters_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            SetFilters();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConfiguredFilters[filterIndex] == null)
            {
                ConfiguredFilters[filterIndex] = new FilterData();
                ConfiguredFilters[filterIndex].Action = cmbAction.SelectedIndex;
                ConfiguredFilters[filterIndex].IsEnable = chkEnable.Checked;
                ConfiguredFilters[filterIndex].MemoryBank = cmbMemoryBank.SelectedIndex;
                ConfiguredFilters[filterIndex].OffSet = short.Parse(txtOffSet.Text.Trim());
                ConfiguredFilters[filterIndex].TagPattern = txtTagPattern.Text.Trim();
                ConfiguredFilters[filterIndex].Target = cmbTarget.SelectedIndex;
            }

            filterIndex = cmbFilters.SelectedIndex;
            if (ConfiguredFilters[filterIndex] == null)
            {
                chkEnable.Checked = false;
                cmbAction.SelectedIndex = 0;
                cmbMemoryBank.SelectedIndex = 0;
                cmbTarget.SelectedIndex = 0;
                txtTagPattern.Text = string.Empty;
                txtOffSet.Text = "0";
                return;
            }

            txtTagPattern.Text = ConfiguredFilters[filterIndex].TagPattern;
            cmbAction.SelectedIndex = ConfiguredFilters[filterIndex].Action;
            cmbMemoryBank.SelectedIndex = ConfiguredFilters[filterIndex].MemoryBank;
            cmbTarget.SelectedIndex = ConfiguredFilters[filterIndex].Target;
            txtOffSet.Text = ConfiguredFilters[filterIndex].OffSet.ToString();
            chkEnable.Checked = ConfiguredFilters[filterIndex].IsEnable;
        }

        private void HexInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsHex(e);
        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataUtility.IsNumeric(e);
        }

        #endregion

        #region Private Methods

        private void PopulateControls()
        {
            try
            {
                var count = Reader.Capabilities.SupportedFilters;
                ConfiguredFilters = new FilterData[count];
                if (Reader != null)
                {
                    var filters = this.Reader.PreFilters.ConfiguredFilters;
                    for (int i = 0; i < filters.Count; i++)
                    {
                        ConfiguredFilters[i] = new FilterData();
                        ConfiguredFilters[i].Action = (int)filters[i].Action;
                        ConfiguredFilters[i].IsEnable = true;
                        ConfiguredFilters[i].MemoryBank = (int)filters[i].MaskBank;
                        ConfiguredFilters[i].OffSet = (short)filters[i].MaskStartPos;
                        ConfiguredFilters[i].TagPattern = DataUtility.ByteArrayToHexString(filters[i].MatchPattern);
                        ConfiguredFilters[i].Target = (int)filters[i].Target;
                    }
                }

                chkEnable.Checked = false;
                cmbAction.Items.AddRange(Enum.GetNames(typeof(FILTER_ACTION)));
                cmbAction.SelectedIndex = 0;
                cmbMemoryBank.Items.AddRange(Enum.GetNames(typeof(FILTER_MASK_BANK)));
                cmbMemoryBank.SelectedIndex = 0;
                cmbTarget.Items.AddRange(Enum.GetNames(typeof(FILTER_TARGET)));
                cmbTarget.SelectedIndex = 0;

                txtOffSet.Text = "0";

                for (int i = 0; i < count; i++)
                {
                    cmbFilters.Items.Add("FILTER " + (i + 1));
                }
                cmbFilters.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        /// <summary>
        /// Configutre pre filter to the device.
        /// </summary>
        private void SetFilters()
        {
            try
            {
                filterIndex = cmbFilters.SelectedIndex;

                if (ConfiguredFilters[filterIndex] == null)
                    ConfiguredFilters[filterIndex] = new FilterData();

                ConfiguredFilters[filterIndex].Action = cmbAction.SelectedIndex;
                ConfiguredFilters[filterIndex].IsEnable = chkEnable.Checked;
                ConfiguredFilters[filterIndex].MemoryBank = cmbMemoryBank.SelectedIndex;
                ConfiguredFilters[filterIndex].OffSet = short.Parse(txtOffSet.Text.Trim());
                ConfiguredFilters[filterIndex].TagPattern = txtTagPattern.Text.Trim();
                ConfiguredFilters[filterIndex].Target = cmbTarget.SelectedIndex;

                List<Filter> readerFilters = new List<Filter>();
                foreach (var item in ConfiguredFilters)
                {
                    if (item == null || !item.IsEnable || string.IsNullOrEmpty(item.TagPattern))
                        continue;

                    var f = new Filter()
                    {
                        Action = (FILTER_ACTION)item.Action,
                        MaskBank = (FILTER_MASK_BANK)item.MemoryBank,
                        Target = (FILTER_TARGET)item.Target,
                        MaskStartPos = item.OffSet,
                        MatchPattern = DataUtility.HexStringToByteArray(item.TagPattern),
                    };
                    readerFilters.Add(f);
                }

                this.Reader.PreFilters.ConfiguredFilters = readerFilters;

            }
            catch (Exception ex)
            {
                mainForm.OutputText(ex.Message);
            }
        }

        #endregion
    }
}