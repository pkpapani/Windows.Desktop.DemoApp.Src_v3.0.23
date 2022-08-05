using Symbol.RFID.SDK.Domain.Reader;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    public partial class ManualConnect : Form
    {
        #region Private Fields

        private const string DefaultPort = "5084";

        private frmMain mainForm = null;
        private Regex regexIP = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
        private Regex regexCOM = new Regex(@"\b\d{1,255}\b");

        private int portNumber = 0;

        #endregion

        #region Properties

        public IRfidReader Reader { get; set; }

        #endregion

        #region Constructors

        public ManualConnect(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            txtPort.Text = DefaultPort;
        }

        #endregion

        #region Form Event Handlers

        private void rdoIP_Click(object sender, EventArgs e)
        {
            if (rdoIP.Checked)
            {
                lblIP.Text = "IP Address";
                txtPort.Enabled = true;
            }
        }

        private void rdoCom_Click(object sender, EventArgs e)
        {
            if (rdoCom.Checked)
            {
                lblIP.Text = "COM Port";
                txtPort.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        #endregion

        #region Private Methods

        private void Connect()
        {
            MatchCollection collection;
            if (rdoIP.Checked)
            {
                if (string.IsNullOrEmpty(txtIpCom.Text))
                {
                    MessageBox.Show("IP Address should not be empty.");
                    return;
                }

                if (string.IsNullOrEmpty(txtPort.Text))
                {
                    MessageBox.Show("Port number should not be empty.");
                    return;
                }

                collection = regexIP.Matches(txtIpCom.Text.Trim());
                if (collection.Count == 0)
                {
                    MessageBox.Show("Invalid IP Address.");
                    return;
                }

                int.TryParse(txtPort.Text, out portNumber);
                if (portNumber == 0)
                {
                    MessageBox.Show("Invalid port number.");
                    return;
                }

                mainForm.ReaderInfo = new ReaderInfo("IP " + txtIpCom.Text.Trim() + ":" + txtPort.Text.Trim(), txtIpCom.Text.Trim(), txtPort.Text.Trim(), ReaderStatus.NotConnected, ReaderCommunicationMode.IP);
            }
            else
            {
                if (string.IsNullOrEmpty(txtIpCom.Text))
                {
                    MessageBox.Show("COM port should not be empty.");
                    return;
                }

                collection = regexCOM.Matches(txtIpCom.Text.Trim());
                if (collection.Count == 0)
                {
                    MessageBox.Show("Invalid COM port.");
                    return;
                }

                mainForm.ReaderInfo = new ReaderInfo("USB Serial Device (COM" + txtIpCom.Text.Trim() + ")", "COM" + txtIpCom.Text.Trim(), "COM" + txtIpCom.Text.Trim(), ReaderStatus.NotConnected, ReaderCommunicationMode.USB);
            }

            Close();
        }

        #endregion
    }
}
