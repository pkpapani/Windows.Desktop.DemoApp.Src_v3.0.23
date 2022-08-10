namespace Symbol.RFID.SDK.DemoApp
{
    partial class Antenna
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
            this.gbAntConfiguration = new System.Windows.Forms.GroupBox();
            this.cmbLinkProfile = new System.Windows.Forms.ComboBox();
            this.labelTari = new System.Windows.Forms.Label();
            this.labelLinkProfile = new System.Windows.Forms.Label();
            this.txtTari = new System.Windows.Forms.TextBox();
            this.txtPowerIndex = new System.Windows.Forms.TextBox();
            this.labelTPIndex = new System.Windows.Forms.Label();
            this.btnApplyAntConfig = new System.Windows.Forms.Button();
            this.gbAntConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAntConfiguration
            // 
            this.gbAntConfiguration.Controls.Add(this.cmbLinkProfile);
            this.gbAntConfiguration.Controls.Add(this.labelTari);
            this.gbAntConfiguration.Controls.Add(this.labelLinkProfile);
            this.gbAntConfiguration.Controls.Add(this.txtTari);
            this.gbAntConfiguration.Controls.Add(this.txtPowerIndex);
            this.gbAntConfiguration.Controls.Add(this.labelTPIndex);
            this.gbAntConfiguration.Location = new System.Drawing.Point(10, 10);
            this.gbAntConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.gbAntConfiguration.Name = "gbAntConfiguration";
            this.gbAntConfiguration.Padding = new System.Windows.Forms.Padding(2);
            this.gbAntConfiguration.Size = new System.Drawing.Size(366, 121);
            this.gbAntConfiguration.TabIndex = 0;
            this.gbAntConfiguration.TabStop = false;
            this.gbAntConfiguration.Text = "Antenna Cofiguration";
            // 
            // cmbLinkProfile
            // 
            this.cmbLinkProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinkProfile.FormattingEnabled = true;
            this.cmbLinkProfile.Location = new System.Drawing.Point(140, 82);
            this.cmbLinkProfile.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLinkProfile.Name = "cmbLinkProfile";
            this.cmbLinkProfile.Size = new System.Drawing.Size(210, 21);
            this.cmbLinkProfile.TabIndex = 2;
            // 
            // labelTari
            // 
            this.labelTari.AutoSize = true;
            this.labelTari.Location = new System.Drawing.Point(15, 54);
            this.labelTari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTari.Name = "labelTari";
            this.labelTari.Size = new System.Drawing.Size(25, 13);
            this.labelTari.TabIndex = 4;
            this.labelTari.Text = "Tari";
            // 
            // labelLinkProfile
            // 
            this.labelLinkProfile.AutoSize = true;
            this.labelLinkProfile.Location = new System.Drawing.Point(15, 85);
            this.labelLinkProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLinkProfile.Name = "labelLinkProfile";
            this.labelLinkProfile.Size = new System.Drawing.Size(59, 13);
            this.labelLinkProfile.TabIndex = 5;
            this.labelLinkProfile.Text = "Link Profile";
            // 
            // txtTari
            // 
            this.txtTari.Location = new System.Drawing.Point(140, 54);
            this.txtTari.Margin = new System.Windows.Forms.Padding(2);
            this.txtTari.Name = "txtTari";
            this.txtTari.Size = new System.Drawing.Size(210, 20);
            this.txtTari.TabIndex = 1;
            this.txtTari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericInput_KeyPress);
            // 
            // txtPowerIndex
            // 
            this.txtPowerIndex.Location = new System.Drawing.Point(140, 25);
            this.txtPowerIndex.Margin = new System.Windows.Forms.Padding(2);
            this.txtPowerIndex.Name = "txtPowerIndex";
            this.txtPowerIndex.Size = new System.Drawing.Size(210, 20);
            this.txtPowerIndex.TabIndex = 0;
            this.txtPowerIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericInput_KeyPress);
            // 
            // labelTPIndex
            // 
            this.labelTPIndex.AutoSize = true;
            this.labelTPIndex.Location = new System.Drawing.Point(15, 25);
            this.labelTPIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTPIndex.Name = "labelTPIndex";
            this.labelTPIndex.Size = new System.Drawing.Size(109, 13);
            this.labelTPIndex.TabIndex = 3;
            this.labelTPIndex.Text = "Transmit Power Index";
            // 
            // btnApplyAntConfig
            // 
            this.btnApplyAntConfig.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApplyAntConfig.Location = new System.Drawing.Point(287, 135);
            this.btnApplyAntConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyAntConfig.Name = "btnApplyAntConfig";
            this.btnApplyAntConfig.Size = new System.Drawing.Size(89, 28);
            this.btnApplyAntConfig.TabIndex = 1;
            this.btnApplyAntConfig.Text = "Apply";
            this.btnApplyAntConfig.UseVisualStyleBackColor = false;
            this.btnApplyAntConfig.Click += new System.EventHandler(this.btnApplyAntConfig_Click);
            // 
            // Antenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.btnApplyAntConfig);
            this.Controls.Add(this.gbAntConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Antenna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Antenna Cofiguration";
            this.Load += new System.EventHandler(this.AntCofiguration_Load);
            this.gbAntConfiguration.ResumeLayout(false);
            this.gbAntConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAntConfiguration;
        private System.Windows.Forms.Button btnApplyAntConfig;
        private System.Windows.Forms.Label labelTPIndex;
        private System.Windows.Forms.TextBox txtPowerIndex;
        private System.Windows.Forms.Label labelLinkProfile;
        private System.Windows.Forms.TextBox txtTari;
        private System.Windows.Forms.Label labelTari;
        private System.Windows.Forms.ComboBox cmbLinkProfile;
    }
}