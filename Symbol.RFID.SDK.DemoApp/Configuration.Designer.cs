namespace Symbol.RFID.SDK.DemoApp
{
    partial class Configuration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbBeeperVolume = new System.Windows.Forms.ComboBox();
            this.btnSetBeeperVolume = new System.Windows.Forms.Button();
            this.btnGetBeeperVolume = new System.Windows.Forms.Button();
            this.gbPowerManagement = new System.Windows.Forms.GroupBox();
            this.brtnSetDP = new System.Windows.Forms.Button();
            this.btnGetDP = new System.Windows.Forms.Button();
            this.cbDynamicPower = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTriggerMode = new System.Windows.Forms.ComboBox();
            this.btnTriggerModeSet = new System.Windows.Forms.Button();
            this.btnTriggerModeGet = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.gbPowerManagement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cmbBeeperVolume);
            this.groupBox4.Controls.Add(this.btnSetBeeperVolume);
            this.groupBox4.Controls.Add(this.btnGetBeeperVolume);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(11, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(261, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Beeper Volume";
            // 
            // cmbBeeperVolume
            // 
            this.cmbBeeperVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeeperVolume.FormattingEnabled = true;
            this.cmbBeeperVolume.Location = new System.Drawing.Point(11, 23);
            this.cmbBeeperVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBeeperVolume.Name = "cmbBeeperVolume";
            this.cmbBeeperVolume.Size = new System.Drawing.Size(145, 21);
            this.cmbBeeperVolume.TabIndex = 0;
            // 
            // btnSetBeeperVolume
            // 
            this.btnSetBeeperVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetBeeperVolume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetBeeperVolume.Location = new System.Drawing.Point(210, 22);
            this.btnSetBeeperVolume.Name = "btnSetBeeperVolume";
            this.btnSetBeeperVolume.Size = new System.Drawing.Size(46, 23);
            this.btnSetBeeperVolume.TabIndex = 2;
            this.btnSetBeeperVolume.Text = "Set";
            this.btnSetBeeperVolume.UseVisualStyleBackColor = true;
            this.btnSetBeeperVolume.Click += new System.EventHandler(this.BtnSetBeeperVolume_Click);
            // 
            // btnGetBeeperVolume
            // 
            this.btnGetBeeperVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetBeeperVolume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetBeeperVolume.Location = new System.Drawing.Point(159, 22);
            this.btnGetBeeperVolume.Name = "btnGetBeeperVolume";
            this.btnGetBeeperVolume.Size = new System.Drawing.Size(45, 23);
            this.btnGetBeeperVolume.TabIndex = 1;
            this.btnGetBeeperVolume.Text = "Get";
            this.btnGetBeeperVolume.UseVisualStyleBackColor = true;
            this.btnGetBeeperVolume.Click += new System.EventHandler(this.BtnGetBeeperVolume_Click);
            // 
            // gbPowerManagement
            // 
            this.gbPowerManagement.BackColor = System.Drawing.Color.Transparent;
            this.gbPowerManagement.Controls.Add(this.brtnSetDP);
            this.gbPowerManagement.Controls.Add(this.btnGetDP);
            this.gbPowerManagement.Controls.Add(this.cbDynamicPower);
            this.gbPowerManagement.Location = new System.Drawing.Point(11, 146);
            this.gbPowerManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPowerManagement.Name = "gbPowerManagement";
            this.gbPowerManagement.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPowerManagement.Size = new System.Drawing.Size(261, 49);
            this.gbPowerManagement.TabIndex = 2;
            this.gbPowerManagement.TabStop = false;
            this.gbPowerManagement.Text = "Power Management";
            // 
            // brtnSetDP
            // 
            this.brtnSetDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brtnSetDP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brtnSetDP.Location = new System.Drawing.Point(210, 18);
            this.brtnSetDP.Name = "brtnSetDP";
            this.brtnSetDP.Size = new System.Drawing.Size(46, 23);
            this.brtnSetDP.TabIndex = 2;
            this.brtnSetDP.TabStop = false;
            this.brtnSetDP.Text = "Set";
            this.brtnSetDP.UseVisualStyleBackColor = true;
            this.brtnSetDP.Click += new System.EventHandler(this.brtnSetDP_Click);
            // 
            // btnGetDP
            // 
            this.btnGetDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetDP.Location = new System.Drawing.Point(159, 18);
            this.btnGetDP.Name = "btnGetDP";
            this.btnGetDP.Size = new System.Drawing.Size(45, 23);
            this.btnGetDP.TabIndex = 1;
            this.btnGetDP.TabStop = false;
            this.btnGetDP.Text = "Get";
            this.btnGetDP.UseVisualStyleBackColor = true;
            this.btnGetDP.Click += new System.EventHandler(this.btnGetDP_Click);
            // 
            // cbDynamicPower
            // 
            this.cbDynamicPower.AutoSize = true;
            this.cbDynamicPower.Location = new System.Drawing.Point(11, 22);
            this.cbDynamicPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDynamicPower.Name = "cbDynamicPower";
            this.cbDynamicPower.Size = new System.Drawing.Size(100, 17);
            this.cbDynamicPower.TabIndex = 0;
            this.cbDynamicPower.Text = "Dynamic Power";
            this.cbDynamicPower.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbTriggerMode);
            this.groupBox1.Controls.Add(this.btnTriggerModeSet);
            this.groupBox1.Controls.Add(this.btnTriggerModeGet);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(261, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trigger Mode";
            // 
            // cmbTriggerMode
            // 
            this.cmbTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriggerMode.FormattingEnabled = true;
            this.cmbTriggerMode.Location = new System.Drawing.Point(11, 23);
            this.cmbTriggerMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTriggerMode.Name = "cmbTriggerMode";
            this.cmbTriggerMode.Size = new System.Drawing.Size(145, 21);
            this.cmbTriggerMode.TabIndex = 0;
            // 
            // btnTriggerModeSet
            // 
            this.btnTriggerModeSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTriggerModeSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTriggerModeSet.Location = new System.Drawing.Point(210, 22);
            this.btnTriggerModeSet.Name = "btnTriggerModeSet";
            this.btnTriggerModeSet.Size = new System.Drawing.Size(46, 23);
            this.btnTriggerModeSet.TabIndex = 2;
            this.btnTriggerModeSet.Text = "Set";
            this.btnTriggerModeSet.UseVisualStyleBackColor = true;
            this.btnTriggerModeSet.Click += new System.EventHandler(this.btnTriggerModeSet_Click);
            // 
            // btnTriggerModeGet
            // 
            this.btnTriggerModeGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTriggerModeGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTriggerModeGet.Location = new System.Drawing.Point(159, 22);
            this.btnTriggerModeGet.Name = "btnTriggerModeGet";
            this.btnTriggerModeGet.Size = new System.Drawing.Size(45, 23);
            this.btnTriggerModeGet.TabIndex = 1;
            this.btnTriggerModeGet.Text = "Get";
            this.btnTriggerModeGet.UseVisualStyleBackColor = true;
            this.btnTriggerModeGet.Click += new System.EventHandler(this.btnTriggerModeGet_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPowerManagement);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.groupBox4.ResumeLayout(false);
            this.gbPowerManagement.ResumeLayout(false);
            this.gbPowerManagement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbBeeperVolume;
        private System.Windows.Forms.Button btnSetBeeperVolume;
        private System.Windows.Forms.Button btnGetBeeperVolume;
        private System.Windows.Forms.GroupBox gbPowerManagement;
        private System.Windows.Forms.CheckBox cbDynamicPower;
        private System.Windows.Forms.Button brtnSetDP;
        private System.Windows.Forms.Button btnGetDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTriggerMode;
        private System.Windows.Forms.Button btnTriggerModeSet;
        private System.Windows.Forms.Button btnTriggerModeGet;
    }
}