using System.ComponentModel;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabContainer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.grdTags = new System.Windows.Forms.DataGridView();
            this.btnInventoryStart = new System.Windows.Forms.Button();
            this.btnPurgeTags = new System.Windows.Forms.Button();
            this.btnInventoryStop = new System.Windows.Forms.Button();
            this.tabTagLocate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTagId = new System.Windows.Forms.TextBox();
            this.lblTL = new System.Windows.Forms.Label();
            this.btnTagLocateStart = new System.Windows.Forms.Button();
            this.btnTagLocateStop = new System.Windows.Forms.Button();
            this.proximityPrcentBar = new System.Windows.Forms.ProgressBar();
            this.tabReadWrite = new System.Windows.Forms.TabPage();
            this.comboBoxReaders = new System.Windows.Forms.ComboBox();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblReaders = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antennaConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regulatory = new System.Windows.Forms.ToolStripMenuItem();
            this.preFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.singulationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagReportingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPairNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.btnManulConnect = new System.Windows.Forms.Button();
            this.tabLock = new System.Windows.Forms.TabPage();
            this.tabKill = new System.Windows.Forms.TabPage();
            this.tabRSM = new System.Windows.Forms.TabPage();
            this.btnKill = new System.Windows.Forms.Button();
            this.txtPasswordKill = new System.Windows.Forms.TextBox();
            this.txtTagPatternKill = new System.Windows.Forms.TextBox();
            this.labelKillPassword = new System.Windows.Forms.Label();
            this.labelTagPatternKill = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.cmbLockPrivilage = new System.Windows.Forms.ComboBox();
            this.cmbMemoryBankLock = new System.Windows.Forms.ComboBox();
            this.txtPasswordLock = new System.Windows.Forms.TextBox();
            this.txtTagPatternLock = new System.Windows.Forms.TextBox();
            this.labelLockPrivilege = new System.Windows.Forms.Label();
            this.labelMemBankACLock = new System.Windows.Forms.Label();
            this.labelPasswordACLock = new System.Windows.Forms.Label();
            this.labelTagPatternACLock = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.cmbMemoryBank = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTagPattern = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelOffset = new System.Windows.Forms.Label();
            this.labelMemBank = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTagPattern = new System.Windows.Forms.Label();
            this.btnSetAttribute = new System.Windows.Forms.Button();
            this.btnGetAttribute = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            tabContainer = new System.Windows.Forms.TabControl();
            tabContainer.SuspendLayout();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).BeginInit();
            this.tabTagLocate.SuspendLayout();
            this.tabReadWrite.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabLock.SuspendLayout();
            this.tabKill.SuspendLayout();
            this.tabRSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabContainer.Controls.Add(this.tabInventory);
            tabContainer.Controls.Add(this.tabTagLocate);
            tabContainer.Controls.Add(this.tabReadWrite);
            tabContainer.Controls.Add(this.tabLock);
            tabContainer.Controls.Add(this.tabKill);
            tabContainer.Controls.Add(this.tabRSM);
            tabContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabContainer.Location = new System.Drawing.Point(23, 111);
            tabContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabContainer.Name = "tabContainer";
            tabContainer.SelectedIndex = 0;
            tabContainer.Size = new System.Drawing.Size(893, 274);
            tabContainer.TabIndex = 45;
            tabContainer.SelectedIndexChanged += new System.EventHandler(this.tabContainer_SelectedIndexChanged);
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabInventory.Controls.Add(this.grdTags);
            this.tabInventory.Controls.Add(this.btnInventoryStart);
            this.tabInventory.Controls.Add(this.btnPurgeTags);
            this.tabInventory.Controls.Add(this.btnInventoryStop);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInventory.Size = new System.Drawing.Size(885, 241);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory";
            // 
            // grdTags
            // 
            this.grdTags.AllowUserToAddRows = false;
            this.grdTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTags.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTags.Location = new System.Drawing.Point(7, 6);
            this.grdTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTags.Name = "grdTags";
            this.grdTags.ReadOnly = true;
            this.grdTags.RowHeadersVisible = false;
            this.grdTags.RowHeadersWidth = 51;
            this.grdTags.RowTemplate.Height = 24;
            this.grdTags.Size = new System.Drawing.Size(693, 230);
            this.grdTags.TabIndex = 22;
            // 
            // btnInventoryStart
            // 
            this.btnInventoryStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventoryStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventoryStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryStart.BackgroundImage")));
            this.btnInventoryStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventoryStart.FlatAppearance.BorderSize = 0;
            this.btnInventoryStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryStart.ForeColor = System.Drawing.Color.White;
            this.btnInventoryStart.Location = new System.Drawing.Point(712, 7);
            this.btnInventoryStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventoryStart.Name = "btnInventoryStart";
            this.btnInventoryStart.Size = new System.Drawing.Size(164, 34);
            this.btnInventoryStart.TabIndex = 3;
            this.btnInventoryStart.Text = "INVENTORY START";
            this.btnInventoryStart.UseVisualStyleBackColor = false;
            this.btnInventoryStart.Click += new System.EventHandler(this.BtnInventoryStart_Click);
            // 
            // btnPurgeTags
            // 
            this.btnPurgeTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurgeTags.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurgeTags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurgeTags.BackgroundImage")));
            this.btnPurgeTags.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPurgeTags.FlatAppearance.BorderSize = 0;
            this.btnPurgeTags.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurgeTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurgeTags.ForeColor = System.Drawing.Color.White;
            this.btnPurgeTags.Location = new System.Drawing.Point(712, 85);
            this.btnPurgeTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPurgeTags.Name = "btnPurgeTags";
            this.btnPurgeTags.Size = new System.Drawing.Size(164, 34);
            this.btnPurgeTags.TabIndex = 44;
            this.btnPurgeTags.Text = "PURGE TAGS";
            this.btnPurgeTags.UseVisualStyleBackColor = false;
            this.btnPurgeTags.Click += new System.EventHandler(this.BtnPurgeTags_Click);
            // 
            // btnInventoryStop
            // 
            this.btnInventoryStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventoryStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventoryStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryStop.BackgroundImage")));
            this.btnInventoryStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventoryStop.FlatAppearance.BorderSize = 0;
            this.btnInventoryStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryStop.ForeColor = System.Drawing.Color.White;
            this.btnInventoryStop.Location = new System.Drawing.Point(712, 47);
            this.btnInventoryStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventoryStop.Name = "btnInventoryStop";
            this.btnInventoryStop.Size = new System.Drawing.Size(164, 34);
            this.btnInventoryStop.TabIndex = 4;
            this.btnInventoryStop.Text = "INVENTORY STOP";
            this.btnInventoryStop.UseVisualStyleBackColor = false;
            this.btnInventoryStop.Click += new System.EventHandler(this.BtnInventoryStop_Click);
            // 
            // tabTagLocate
            // 
            this.tabTagLocate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabTagLocate.Controls.Add(this.label2);
            this.tabTagLocate.Controls.Add(this.txtTagId);
            this.tabTagLocate.Controls.Add(this.lblTL);
            this.tabTagLocate.Controls.Add(this.btnTagLocateStart);
            this.tabTagLocate.Controls.Add(this.btnTagLocateStop);
            this.tabTagLocate.Controls.Add(this.proximityPrcentBar);
            this.tabTagLocate.Location = new System.Drawing.Point(4, 29);
            this.tabTagLocate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTagLocate.Name = "tabTagLocate";
            this.tabTagLocate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTagLocate.Size = new System.Drawing.Size(885, 241);
            this.tabTagLocate.TabIndex = 1;
            this.tabTagLocate.Text = "Tag Locate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tag Id";
            // 
            // txtTagId
            // 
            this.txtTagId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagId.Location = new System.Drawing.Point(143, 32);
            this.txtTagId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTagId.Name = "txtTagId";
            this.txtTagId.Size = new System.Drawing.Size(720, 27);
            this.txtTagId.TabIndex = 5;
            this.txtTagId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // lblTL
            // 
            this.lblTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(433, 110);
            this.lblTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(29, 31);
            this.lblTL.TabIndex = 4;
            this.lblTL.Text = "0";
            this.lblTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTagLocateStart
            // 
            this.btnTagLocateStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTagLocateStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTagLocateStart.BackgroundImage")));
            this.btnTagLocateStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTagLocateStart.FlatAppearance.BorderSize = 0;
            this.btnTagLocateStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTagLocateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagLocateStart.ForeColor = System.Drawing.Color.White;
            this.btnTagLocateStart.Location = new System.Drawing.Point(528, 174);
            this.btnTagLocateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTagLocateStart.Name = "btnTagLocateStart";
            this.btnTagLocateStart.Size = new System.Drawing.Size(164, 34);
            this.btnTagLocateStart.TabIndex = 3;
            this.btnTagLocateStart.Text = "START";
            this.btnTagLocateStart.UseVisualStyleBackColor = false;
            this.btnTagLocateStart.Click += new System.EventHandler(this.BtnTagLocateStart_Click);
            // 
            // btnTagLocateStop
            // 
            this.btnTagLocateStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagLocateStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTagLocateStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTagLocateStop.BackgroundImage")));
            this.btnTagLocateStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTagLocateStop.FlatAppearance.BorderSize = 0;
            this.btnTagLocateStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTagLocateStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagLocateStop.ForeColor = System.Drawing.Color.White;
            this.btnTagLocateStop.Location = new System.Drawing.Point(700, 174);
            this.btnTagLocateStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTagLocateStop.Name = "btnTagLocateStop";
            this.btnTagLocateStop.Size = new System.Drawing.Size(164, 34);
            this.btnTagLocateStop.TabIndex = 2;
            this.btnTagLocateStop.Text = "STOP";
            this.btnTagLocateStop.UseVisualStyleBackColor = false;
            this.btnTagLocateStop.Click += new System.EventHandler(this.BtnTagLocateStop_Click);
            // 
            // proximityPrcentBar
            // 
            this.proximityPrcentBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proximityPrcentBar.Location = new System.Drawing.Point(21, 71);
            this.proximityPrcentBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proximityPrcentBar.Name = "proximityPrcentBar";
            this.proximityPrcentBar.Size = new System.Drawing.Size(842, 28);
            this.proximityPrcentBar.TabIndex = 0;
            // 
            // tabReadWrite
            // 
            this.tabReadWrite.Controls.Add(this.btnWrite);
            this.tabReadWrite.Controls.Add(this.btnRead);
            this.tabReadWrite.Controls.Add(this.txtData);
            this.tabReadWrite.Controls.Add(this.txtLength);
            this.tabReadWrite.Controls.Add(this.txtOffset);
            this.tabReadWrite.Controls.Add(this.cmbMemoryBank);
            this.tabReadWrite.Controls.Add(this.txtPassword);
            this.tabReadWrite.Controls.Add(this.txtTagPattern);
            this.tabReadWrite.Controls.Add(this.labelData);
            this.tabReadWrite.Controls.Add(this.labelLength);
            this.tabReadWrite.Controls.Add(this.labelOffset);
            this.tabReadWrite.Controls.Add(this.labelMemBank);
            this.tabReadWrite.Controls.Add(this.labelPassword);
            this.tabReadWrite.Controls.Add(this.labelTagPattern);
            this.tabReadWrite.Location = new System.Drawing.Point(4, 29);
            this.tabReadWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReadWrite.Name = "tabReadWrite";
            this.tabReadWrite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReadWrite.Size = new System.Drawing.Size(885, 241);
            this.tabReadWrite.TabIndex = 2;
            this.tabReadWrite.Text = "Read / Write";
            this.tabReadWrite.UseVisualStyleBackColor = true;
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReaders.FormattingEnabled = true;
            this.comboBoxReaders.IntegralHeight = false;
            this.comboBoxReaders.ItemHeight = 20;
            this.comboBoxReaders.Location = new System.Drawing.Point(23, 69);
            this.comboBoxReaders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(429, 28);
            this.comboBoxReaders.TabIndex = 0;
            this.comboBoxReaders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReaders_SelectedIndexChanged);
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectDisconnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnectDisconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnectDisconnect.BackgroundImage")));
            this.btnConnectDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnectDisconnect.FlatAppearance.BorderSize = 0;
            this.btnConnectDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnectDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnectDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnConnectDisconnect.Location = new System.Drawing.Point(740, 65);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(164, 34);
            this.btnConnectDisconnect.TabIndex = 1;
            this.btnConnectDisconnect.Text = "CONNECT";
            this.btnConnectDisconnect.UseVisualStyleBackColor = false;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.BtnConnectDisconnect_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(23, 409);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(892, 174);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TabStop = false;
            // 
            // lblReaders
            // 
            this.lblReaders.AutoSize = true;
            this.lblReaders.BackColor = System.Drawing.Color.Transparent;
            this.lblReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReaders.Location = new System.Drawing.Point(20, 47);
            this.lblReaders.Margin = new System.Windows.Forms.Padding(0);
            this.lblReaders.Name = "lblReaders";
            this.lblReaders.Size = new System.Drawing.Size(145, 18);
            this.lblReaders.TabIndex = 10;
            this.lblReaders.Text = "Active RFID Readers";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLog.Location = new System.Drawing.Point(20, 388);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(34, 20);
            this.lblLog.TabIndex = 16;
            this.lblLog.Text = "Log";
            this.lblLog.Click += new System.EventHandler(this.lblLog_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(939, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Checked = true;
            this.settingsMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antennaConfiguration,
            this.capabilitiesMenuItem,
            this.configurationMenuItem,
            this.regulatory,
            this.preFilters,
            this.singulationMenuItem,
            this.tagReportingMenuItem,
            this.triggersMenuItem,
            this.versionMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.saveConfigMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsMenuItem.Text = "&Settings";
            // 
            // antennaConfiguration
            // 
            this.antennaConfiguration.Name = "antennaConfiguration";
            this.antennaConfiguration.Size = new System.Drawing.Size(218, 26);
            this.antennaConfiguration.Text = "&Antenna";
            this.antennaConfiguration.Click += new System.EventHandler(this.antennaConfiguration_Click);
            // 
            // capabilitiesMenuItem
            // 
            this.capabilitiesMenuItem.Name = "capabilitiesMenuItem";
            this.capabilitiesMenuItem.Size = new System.Drawing.Size(218, 26);
            this.capabilitiesMenuItem.Text = "&Capabilities";
            this.capabilitiesMenuItem.Click += new System.EventHandler(this.CapabilitiesToolStripMenuItem_Click);
            // 
            // configurationMenuItem
            // 
            this.configurationMenuItem.Name = "configurationMenuItem";
            this.configurationMenuItem.Size = new System.Drawing.Size(218, 26);
            this.configurationMenuItem.Text = "C&onfiguration";
            this.configurationMenuItem.Click += new System.EventHandler(this.Configurations_Click);
            // 
            // regulatory
            // 
            this.regulatory.Name = "regulatory";
            this.regulatory.Size = new System.Drawing.Size(218, 26);
            this.regulatory.Text = "&Regulatory";
            this.regulatory.Click += new System.EventHandler(this.regulatory_Click);
            // 
            // preFilters
            // 
            this.preFilters.Name = "preFilters";
            this.preFilters.Size = new System.Drawing.Size(218, 26);
            this.preFilters.Text = "&Pre Filters";
            this.preFilters.Click += new System.EventHandler(this.preFilters_Click);
            // 
            // singulationMenuItem
            // 
            this.singulationMenuItem.Name = "singulationMenuItem";
            this.singulationMenuItem.Size = new System.Drawing.Size(218, 26);
            this.singulationMenuItem.Text = "&Singulation";
            this.singulationMenuItem.Click += new System.EventHandler(this.SingulationToolStripMenuItem_Click);
            // 
            // tagReportingMenuItem
            // 
            this.tagReportingMenuItem.Name = "tagReportingMenuItem";
            this.tagReportingMenuItem.Size = new System.Drawing.Size(218, 26);
            this.tagReportingMenuItem.Text = "&Tag Reporting";
            this.tagReportingMenuItem.Click += new System.EventHandler(this.TagReportingMenuItem_Click);
            // 
            // triggersMenuItem
            // 
            this.triggersMenuItem.Name = "triggersMenuItem";
            this.triggersMenuItem.Size = new System.Drawing.Size(218, 26);
            this.triggersMenuItem.Text = "Tr&iggers";
            this.triggersMenuItem.Click += new System.EventHandler(this.TriggersToolStripMenuItem_Click);
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(218, 26);
            this.versionMenuItem.Text = "&Version Info";
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem1.Text = "&Restore Default";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.BtnRestoreDefaults_Click);
            // 
            // saveConfigMenuItem
            // 
            this.saveConfigMenuItem.Name = "saveConfigMenuItem";
            this.saveConfigMenuItem.Size = new System.Drawing.Size(218, 26);
            this.saveConfigMenuItem.Text = "&Save Configuration";
            this.saveConfigMenuItem.Click += new System.EventHandler(this.BtnSaveConfig_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnPairNew
            // 
            this.btnPairNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPairNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPairNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPairNew.BackgroundImage")));
            this.btnPairNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPairNew.FlatAppearance.BorderSize = 0;
            this.btnPairNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPairNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPairNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPairNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPairNew.ForeColor = System.Drawing.Color.White;
            this.btnPairNew.Location = new System.Drawing.Point(468, 65);
            this.btnPairNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPairNew.Name = "btnPairNew";
            this.btnPairNew.Size = new System.Drawing.Size(128, 34);
            this.btnPairNew.TabIndex = 31;
            this.btnPairNew.Text = "PAIR";
            this.btnPairNew.UseVisualStyleBackColor = false;
            this.btnPairNew.Click += new System.EventHandler(this.BtnPairNew_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Battery Level :";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemperature.Location = new System.Drawing.Point(421, 591);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(30, 20);
            this.lblTemperature.TabIndex = 47;
            this.lblTemperature.Text = "0 C";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(267, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Radio Temperature :";
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblBatteryLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatteryLevel.Location = new System.Drawing.Point(133, 591);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(29, 20);
            this.lblBatteryLevel.TabIndex = 49;
            this.lblBatteryLevel.Text = "0%";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(600, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Power :";
            // 
            // lblPower
            // 
            this.lblPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.Transparent;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPower.Location = new System.Drawing.Point(667, 591);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(28, 20);
            this.lblPower.TabIndex = 50;
            this.lblPower.Text = "0 v";
            // 
            // btnManulConnect
            // 
            this.btnManulConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManulConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManulConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManulConnect.BackgroundImage")));
            this.btnManulConnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManulConnect.FlatAppearance.BorderSize = 0;
            this.btnManulConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManulConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManulConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManulConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManulConnect.ForeColor = System.Drawing.Color.White;
            this.btnManulConnect.Location = new System.Drawing.Point(604, 65);
            this.btnManulConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManulConnect.Name = "btnManulConnect";
            this.btnManulConnect.Size = new System.Drawing.Size(128, 34);
            this.btnManulConnect.TabIndex = 52;
            this.btnManulConnect.Text = "IP / COM";
            this.btnManulConnect.UseVisualStyleBackColor = false;
            this.btnManulConnect.Click += new System.EventHandler(this.btnManulConnect_Click);
            // 
            // tabLock
            // 
            this.tabLock.Controls.Add(this.btnLock);
            this.tabLock.Controls.Add(this.cmbLockPrivilage);
            this.tabLock.Controls.Add(this.cmbMemoryBankLock);
            this.tabLock.Controls.Add(this.txtPasswordLock);
            this.tabLock.Controls.Add(this.txtTagPatternLock);
            this.tabLock.Controls.Add(this.labelLockPrivilege);
            this.tabLock.Controls.Add(this.labelMemBankACLock);
            this.tabLock.Controls.Add(this.labelPasswordACLock);
            this.tabLock.Controls.Add(this.labelTagPatternACLock);
            this.tabLock.Location = new System.Drawing.Point(4, 29);
            this.tabLock.Name = "tabLock";
            this.tabLock.Padding = new System.Windows.Forms.Padding(3);
            this.tabLock.Size = new System.Drawing.Size(885, 241);
            this.tabLock.TabIndex = 3;
            this.tabLock.Text = "Lock";
            this.tabLock.UseVisualStyleBackColor = true;
            // 
            // tabKill
            // 
            this.tabKill.Controls.Add(this.btnKill);
            this.tabKill.Controls.Add(this.txtPasswordKill);
            this.tabKill.Controls.Add(this.txtTagPatternKill);
            this.tabKill.Controls.Add(this.labelKillPassword);
            this.tabKill.Controls.Add(this.labelTagPatternKill);
            this.tabKill.Location = new System.Drawing.Point(4, 29);
            this.tabKill.Name = "tabKill";
            this.tabKill.Padding = new System.Windows.Forms.Padding(3);
            this.tabKill.Size = new System.Drawing.Size(885, 241);
            this.tabKill.TabIndex = 4;
            this.tabKill.Text = "Kill";
            this.tabKill.UseVisualStyleBackColor = true;
            // 
            // tabRSM
            // 
            this.tabRSM.Controls.Add(this.txtType);
            this.tabRSM.Controls.Add(this.txtValue);
            this.tabRSM.Controls.Add(this.txtAttribute);
            this.tabRSM.Controls.Add(this.label4);
            this.tabRSM.Controls.Add(this.label7);
            this.tabRSM.Controls.Add(this.label8);
            this.tabRSM.Controls.Add(this.btnSetAttribute);
            this.tabRSM.Controls.Add(this.btnGetAttribute);
            this.tabRSM.Location = new System.Drawing.Point(4, 29);
            this.tabRSM.Name = "tabRSM";
            this.tabRSM.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSM.Size = new System.Drawing.Size(885, 241);
            this.tabRSM.TabIndex = 5;
            this.tabRSM.Text = "RSM";
            this.tabRSM.UseVisualStyleBackColor = true;
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKill.BackgroundImage")));
            this.btnKill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKill.FlatAppearance.BorderSize = 0;
            this.btnKill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.ForeColor = System.Drawing.Color.White;
            this.btnKill.Location = new System.Drawing.Point(700, 174);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(164, 34);
            this.btnKill.TabIndex = 22;
            this.btnKill.Text = "KILL";
            this.btnKill.UseVisualStyleBackColor = false;
            // 
            // txtPasswordKill
            // 
            this.txtPasswordKill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasswordKill.Location = new System.Drawing.Point(143, 67);
            this.txtPasswordKill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordKill.Name = "txtPasswordKill";
            this.txtPasswordKill.Size = new System.Drawing.Size(265, 27);
            this.txtPasswordKill.TabIndex = 21;
            this.txtPasswordKill.Text = "00";
            // 
            // txtTagPatternKill
            // 
            this.txtTagPatternKill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPatternKill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPatternKill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPatternKill.Location = new System.Drawing.Point(143, 32);
            this.txtTagPatternKill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTagPatternKill.Name = "txtTagPatternKill";
            this.txtTagPatternKill.Size = new System.Drawing.Size(265, 27);
            this.txtTagPatternKill.TabIndex = 20;
            // 
            // labelKillPassword
            // 
            this.labelKillPassword.AutoSize = true;
            this.labelKillPassword.Location = new System.Drawing.Point(21, 71);
            this.labelKillPassword.Name = "labelKillPassword";
            this.labelKillPassword.Size = new System.Drawing.Size(95, 20);
            this.labelKillPassword.TabIndex = 19;
            this.labelKillPassword.Text = "Kill Password";
            // 
            // labelTagPatternKill
            // 
            this.labelTagPatternKill.AutoSize = true;
            this.labelTagPatternKill.Location = new System.Drawing.Point(21, 35);
            this.labelTagPatternKill.Name = "labelTagPatternKill";
            this.labelTagPatternKill.Size = new System.Drawing.Size(82, 20);
            this.labelTagPatternKill.TabIndex = 18;
            this.labelTagPatternKill.Text = "Tag Pattern";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLock.BackgroundImage")));
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(700, 174);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(164, 34);
            this.btnLock.TabIndex = 25;
            this.btnLock.Text = "LOCK";
            this.btnLock.UseVisualStyleBackColor = false;
            // 
            // cmbLockPrivilage
            // 
            this.cmbLockPrivilage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLockPrivilage.FormattingEnabled = true;
            this.cmbLockPrivilage.Location = new System.Drawing.Point(143, 136);
            this.cmbLockPrivilage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLockPrivilage.Name = "cmbLockPrivilage";
            this.cmbLockPrivilage.Size = new System.Drawing.Size(265, 28);
            this.cmbLockPrivilage.TabIndex = 24;
            // 
            // cmbMemoryBankLock
            // 
            this.cmbMemoryBankLock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryBankLock.FormattingEnabled = true;
            this.cmbMemoryBankLock.Location = new System.Drawing.Point(143, 103);
            this.cmbMemoryBankLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMemoryBankLock.Name = "cmbMemoryBankLock";
            this.cmbMemoryBankLock.Size = new System.Drawing.Size(265, 28);
            this.cmbMemoryBankLock.TabIndex = 23;
            // 
            // txtPasswordLock
            // 
            this.txtPasswordLock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasswordLock.Location = new System.Drawing.Point(143, 67);
            this.txtPasswordLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordLock.Name = "txtPasswordLock";
            this.txtPasswordLock.Size = new System.Drawing.Size(265, 27);
            this.txtPasswordLock.TabIndex = 22;
            this.txtPasswordLock.Text = "00";
            // 
            // txtTagPatternLock
            // 
            this.txtTagPatternLock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPatternLock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPatternLock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPatternLock.Location = new System.Drawing.Point(143, 32);
            this.txtTagPatternLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTagPatternLock.Name = "txtTagPatternLock";
            this.txtTagPatternLock.Size = new System.Drawing.Size(265, 27);
            this.txtTagPatternLock.TabIndex = 21;
            // 
            // labelLockPrivilege
            // 
            this.labelLockPrivilege.AutoSize = true;
            this.labelLockPrivilege.Location = new System.Drawing.Point(23, 142);
            this.labelLockPrivilege.Name = "labelLockPrivilege";
            this.labelLockPrivilege.Size = new System.Drawing.Size(100, 20);
            this.labelLockPrivilege.TabIndex = 20;
            this.labelLockPrivilege.Text = "Lock Privilege";
            // 
            // labelMemBankACLock
            // 
            this.labelMemBankACLock.AutoSize = true;
            this.labelMemBankACLock.Location = new System.Drawing.Point(21, 107);
            this.labelMemBankACLock.Name = "labelMemBankACLock";
            this.labelMemBankACLock.Size = new System.Drawing.Size(100, 20);
            this.labelMemBankACLock.TabIndex = 19;
            this.labelMemBankACLock.Text = "Memory Bank";
            // 
            // labelPasswordACLock
            // 
            this.labelPasswordACLock.AutoSize = true;
            this.labelPasswordACLock.Location = new System.Drawing.Point(21, 71);
            this.labelPasswordACLock.Name = "labelPasswordACLock";
            this.labelPasswordACLock.Size = new System.Drawing.Size(70, 20);
            this.labelPasswordACLock.TabIndex = 18;
            this.labelPasswordACLock.Text = "Password";
            // 
            // labelTagPatternACLock
            // 
            this.labelTagPatternACLock.AutoSize = true;
            this.labelTagPatternACLock.Location = new System.Drawing.Point(21, 35);
            this.labelTagPatternACLock.Name = "labelTagPatternACLock";
            this.labelTagPatternACLock.Size = new System.Drawing.Size(82, 20);
            this.labelTagPatternACLock.TabIndex = 17;
            this.labelTagPatternACLock.Text = "Tag Pattern";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWrite.BackgroundImage")));
            this.btnWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Location = new System.Drawing.Point(700, 174);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(164, 34);
            this.btnWrite.TabIndex = 29;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(528, 174);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(164, 34);
            this.btnRead.TabIndex = 28;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // txtData
            // 
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Location = new System.Drawing.Point(528, 32);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(335, 27);
            this.txtData.TabIndex = 27;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(143, 103);
            this.txtLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(265, 27);
            this.txtLength.TabIndex = 26;
            this.txtLength.Text = "0";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(143, 67);
            this.txtOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(265, 27);
            this.txtOffset.TabIndex = 25;
            this.txtOffset.Text = "2";
            // 
            // cmbMemoryBank
            // 
            this.cmbMemoryBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryBank.FormattingEnabled = true;
            this.cmbMemoryBank.Location = new System.Drawing.Point(143, 174);
            this.cmbMemoryBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMemoryBank.Name = "cmbMemoryBank";
            this.cmbMemoryBank.Size = new System.Drawing.Size(265, 28);
            this.cmbMemoryBank.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Location = new System.Drawing.Point(143, 136);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 27);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "00";
            // 
            // txtTagPattern
            // 
            this.txtTagPattern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPattern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPattern.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPattern.Location = new System.Drawing.Point(143, 32);
            this.txtTagPattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTagPattern.Name = "txtTagPattern";
            this.txtTagPattern.Size = new System.Drawing.Size(265, 27);
            this.txtTagPattern.TabIndex = 22;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(469, 35);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(41, 20);
            this.labelData.TabIndex = 21;
            this.labelData.Text = "Data";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(21, 107);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(108, 20);
            this.labelLength.TabIndex = 20;
            this.labelLength.Text = "Length (words)";
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.Location = new System.Drawing.Point(21, 71);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(103, 20);
            this.labelOffset.TabIndex = 19;
            this.labelOffset.Text = "Offset (words)";
            // 
            // labelMemBank
            // 
            this.labelMemBank.AutoSize = true;
            this.labelMemBank.Location = new System.Drawing.Point(23, 178);
            this.labelMemBank.Name = "labelMemBank";
            this.labelMemBank.Size = new System.Drawing.Size(100, 20);
            this.labelMemBank.TabIndex = 18;
            this.labelMemBank.Text = "Memory Bank";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(23, 142);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelTagPattern
            // 
            this.labelTagPattern.AutoSize = true;
            this.labelTagPattern.Location = new System.Drawing.Point(21, 35);
            this.labelTagPattern.Name = "labelTagPattern";
            this.labelTagPattern.Size = new System.Drawing.Size(82, 20);
            this.labelTagPattern.TabIndex = 16;
            this.labelTagPattern.Text = "Tag Pattern";
            // 
            // btnSetAttribute
            // 
            this.btnSetAttribute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetAttribute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetAttribute.BackgroundImage")));
            this.btnSetAttribute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetAttribute.FlatAppearance.BorderSize = 0;
            this.btnSetAttribute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetAttribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAttribute.ForeColor = System.Drawing.Color.White;
            this.btnSetAttribute.Location = new System.Drawing.Point(700, 174);
            this.btnSetAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetAttribute.Name = "btnSetAttribute";
            this.btnSetAttribute.Size = new System.Drawing.Size(164, 34);
            this.btnSetAttribute.TabIndex = 31;
            this.btnSetAttribute.Text = "SET";
            this.btnSetAttribute.UseVisualStyleBackColor = false;
            this.btnSetAttribute.Click += new System.EventHandler(this.btnSetAttribute_Click);
            // 
            // btnGetAttribute
            // 
            this.btnGetAttribute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetAttribute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetAttribute.BackgroundImage")));
            this.btnGetAttribute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetAttribute.FlatAppearance.BorderSize = 0;
            this.btnGetAttribute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGetAttribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGetAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAttribute.ForeColor = System.Drawing.Color.White;
            this.btnGetAttribute.Location = new System.Drawing.Point(528, 174);
            this.btnGetAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAttribute.Name = "btnGetAttribute";
            this.btnGetAttribute.Size = new System.Drawing.Size(164, 34);
            this.btnGetAttribute.TabIndex = 30;
            this.btnGetAttribute.Text = "GET";
            this.btnGetAttribute.UseVisualStyleBackColor = false;
            this.btnGetAttribute.Click += new System.EventHandler(this.btnGetAttribute_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(143, 103);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(265, 27);
            this.txtValue.TabIndex = 36;
            // 
            // txtAttribute
            // 
            this.txtAttribute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAttribute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAttribute.Location = new System.Drawing.Point(143, 32);
            this.txtAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.Size = new System.Drawing.Size(265, 27);
            this.txtAttribute.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Attribute";
            // 
            // txtType
            // 
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtType.Location = new System.Drawing.Point(143, 67);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(265, 27);
            this.txtType.TabIndex = 37;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.btnManulConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblBatteryLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(tabContainer);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.btnPairNew);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblReaders);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.comboBoxReaders);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(954, 654);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID SDK DEMONSTRATION APP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAppMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmAppMain_Load);
            tabContainer.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).EndInit();
            this.tabTagLocate.ResumeLayout(false);
            this.tabTagLocate.PerformLayout();
            this.tabReadWrite.ResumeLayout(false);
            this.tabReadWrite.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabLock.ResumeLayout(false);
            this.tabLock.PerformLayout();
            this.tabKill.ResumeLayout(false);
            this.tabKill.PerformLayout();
            this.tabRSM.ResumeLayout(false);
            this.tabRSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxReaders;
        private Button btnConnectDisconnect;
        private Button btnInventoryStart;
        private Button btnInventoryStop;
        private TextBox txtOutput;
        private Label lblReaders;
        private Label lblLog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsMenuItem;
        private ToolStripMenuItem configurationMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private DataGridView grdTags;
        private Button btnPairNew;
        private Button btnPurgeTags;
        private ToolStripMenuItem capabilitiesMenuItem;
        private ToolStripMenuItem singulationMenuItem;
        private ToolStripMenuItem triggersMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveConfigMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tagReportingMenuItem;
        private TabPage tabInventory;
        private TabPage tabTagLocate;
        private Button btnTagLocateStart;
        private Button btnTagLocateStop;
        private ProgressBar proximityPrcentBar;
        private Label lblTL;
        private Label label2;
        private TextBox txtTagId;
        private ToolStripMenuItem antennaConfiguration;
        private ToolStripMenuItem regulatory;
        private ToolStripMenuItem preFilters;
        private TabPage tabReadWrite;
        private ToolStripMenuItem versionMenuItem;
        private Label label3;
        private Label lblTemperature;
        private Label label5;
        private Label lblBatteryLevel;
        private Label label6;
        private Label lblPower;
        private Button btnManulConnect;
        private TabPage tabLock;
        private TabPage tabKill;
        private TabPage tabRSM;
        private Button btnWrite;
        private Button btnRead;
        private TextBox txtData;
        private TextBox txtLength;
        private TextBox txtOffset;
        private ComboBox cmbMemoryBank;
        private TextBox txtPassword;
        private TextBox txtTagPattern;
        private Label labelData;
        private Label labelLength;
        private Label labelOffset;
        private Label labelMemBank;
        private Label labelPassword;
        private Label labelTagPattern;
        private Button btnLock;
        private ComboBox cmbLockPrivilage;
        private ComboBox cmbMemoryBankLock;
        private TextBox txtPasswordLock;
        private TextBox txtTagPatternLock;
        private Label labelLockPrivilege;
        private Label labelMemBankACLock;
        private Label labelPasswordACLock;
        private Label labelTagPatternACLock;
        private Button btnKill;
        private TextBox txtPasswordKill;
        private TextBox txtTagPatternKill;
        private Label labelKillPassword;
        private Label labelTagPatternKill;
        private Button btnSetAttribute;
        private Button btnGetAttribute;
        private TextBox txtValue;
        private TextBox txtAttribute;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtType;
    }
}

