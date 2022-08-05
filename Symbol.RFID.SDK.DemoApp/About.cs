using Symbol.RFID.SDK.Domain.Reader;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    partial class About : Form
    {
        #region Form Event Handlers

        private IRfidReader reader;
        private frmMain mainForm;

        #endregion

        #region Constructors

        public About(IRfidReader selectedReader, frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.reader = selectedReader;
        }

        #endregion

        #region Form Event Handlers

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            this.labelProductName.Text = this.AssemblyTitle;
            this.labelCopyright.Text = this.AssemblyCopyright;
            this.labelCompanyName.Text = this.AssemblyCompany;

            this.labelVersion.Text = "v" + this.AssemblyVersion;           
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute) attributes[0]).Company;
            }
        }

        #endregion
    }
}
