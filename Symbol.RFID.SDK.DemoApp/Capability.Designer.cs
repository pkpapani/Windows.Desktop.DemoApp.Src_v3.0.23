using System.ComponentModel;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    partial class Capability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capability));
            this.grpCapabilities = new System.Windows.Forms.GroupBox();
            this.txtManufactureDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtManufactureName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCapabilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCapabilities
            // 
            this.grpCapabilities.BackColor = System.Drawing.Color.Transparent;
            this.grpCapabilities.Controls.Add(this.txtManufactureDate);
            this.grpCapabilities.Controls.Add(this.label8);
            this.grpCapabilities.Controls.Add(this.txtSerialNumber);
            this.grpCapabilities.Controls.Add(this.label7);
            this.grpCapabilities.Controls.Add(this.txtManufactureName);
            this.grpCapabilities.Controls.Add(this.label6);
            this.grpCapabilities.Controls.Add(this.txtModelName);
            this.grpCapabilities.Controls.Add(this.label1);
            this.grpCapabilities.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpCapabilities.Location = new System.Drawing.Point(10, 10);
            this.grpCapabilities.Margin = new System.Windows.Forms.Padding(2);
            this.grpCapabilities.Name = "grpCapabilities";
            this.grpCapabilities.Padding = new System.Windows.Forms.Padding(2);
            this.grpCapabilities.Size = new System.Drawing.Size(341, 136);
            this.grpCapabilities.TabIndex = 0;
            this.grpCapabilities.TabStop = false;
            this.grpCapabilities.Text = "Capabilities";
            // 
            // txtManufactureDate
            // 
            this.txtManufactureDate.Enabled = false;
            this.txtManufactureDate.Location = new System.Drawing.Point(140, 104);
            this.txtManufactureDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtManufactureDate.Name = "txtManufactureDate";
            this.txtManufactureDate.ReadOnly = true;
            this.txtManufactureDate.Size = new System.Drawing.Size(180, 20);
            this.txtManufactureDate.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Manufacturing Date";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.Location = new System.Drawing.Point(140, 80);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(180, 20);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Serial Number";
            // 
            // txtManufactureName
            // 
            this.txtManufactureName.Enabled = false;
            this.txtManufactureName.Location = new System.Drawing.Point(140, 56);
            this.txtManufactureName.Margin = new System.Windows.Forms.Padding(2);
            this.txtManufactureName.Name = "txtManufactureName";
            this.txtManufactureName.ReadOnly = true;
            this.txtManufactureName.Size = new System.Drawing.Size(180, 20);
            this.txtManufactureName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manufacturer Name";
            // 
            // txtModelName
            // 
            this.txtModelName.Enabled = false;
            this.txtModelName.Location = new System.Drawing.Point(140, 32);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(180, 20);
            this.txtModelName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Name";
            // 
            // Capability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(362, 161);
            this.Controls.Add(this.grpCapabilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Capability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capabilities";
            this.Load += new System.EventHandler(this.FrmCapabilities_Load);
            this.grpCapabilities.ResumeLayout(false);
            this.grpCapabilities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpCapabilities;
        private TextBox txtModelName;
        private Label label1;
        private TextBox txtManufactureName;
        private Label label6;
        private TextBox txtSerialNumber;
        private Label label7;
        private TextBox txtManufactureDate;
        private Label label8;
    }
}