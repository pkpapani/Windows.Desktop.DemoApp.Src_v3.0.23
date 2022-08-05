namespace Symbol.RFID.SDK.DemoApp
{
    partial class ManualConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualConnect));
            this.label3 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIpCom = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.rdoIP = new System.Windows.Forms.RadioButton();
            this.rdoCom = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Location = new System.Drawing.Point(12, 59);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(58, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP Address";
            // 
            // txtIpCom
            // 
            this.txtIpCom.Location = new System.Drawing.Point(103, 56);
            this.txtIpCom.Name = "txtIpCom";
            this.txtIpCom.Size = new System.Drawing.Size(160, 20);
            this.txtIpCom.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(103, 82);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(160, 20);
            this.txtPort.TabIndex = 4;
            // 
            // rdoIP
            // 
            this.rdoIP.AutoSize = true;
            this.rdoIP.BackColor = System.Drawing.Color.Transparent;
            this.rdoIP.Checked = true;
            this.rdoIP.Location = new System.Drawing.Point(103, 12);
            this.rdoIP.Name = "rdoIP";
            this.rdoIP.Size = new System.Drawing.Size(35, 17);
            this.rdoIP.TabIndex = 5;
            this.rdoIP.TabStop = true;
            this.rdoIP.Text = "IP";
            this.rdoIP.UseVisualStyleBackColor = false;
            this.rdoIP.Click += new System.EventHandler(this.rdoIP_Click);
            // 
            // rdoCom
            // 
            this.rdoCom.AutoSize = true;
            this.rdoCom.BackColor = System.Drawing.Color.Transparent;
            this.rdoCom.Location = new System.Drawing.Point(103, 35);
            this.rdoCom.Name = "rdoCom";
            this.rdoCom.Size = new System.Drawing.Size(49, 17);
            this.rdoCom.TabIndex = 5;
            this.rdoCom.Text = "COM";
            this.rdoCom.UseVisualStyleBackColor = false;
            this.rdoCom.Click += new System.EventHandler(this.rdoCom_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(167, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ManualConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 153);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoCom);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.rdoIP);
            this.Controls.Add(this.txtIpCom);
            this.Controls.Add(this.txtPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manul Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIpCom;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RadioButton rdoIP;
        private System.Windows.Forms.RadioButton rdoCom;
        private System.Windows.Forms.Button btnConnect;
    }
}