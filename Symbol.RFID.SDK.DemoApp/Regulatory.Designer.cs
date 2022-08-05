namespace Symbol.RFID.SDK.DemoApp
{
    partial class Regulatory
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
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelChannelSelection = new System.Windows.Forms.Label();
            this.gbRegulatory = new System.Windows.Forms.GroupBox();
            this.lblHopping = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRegions = new System.Windows.Forms.ComboBox();
            this.btnApplyRegulatory = new System.Windows.Forms.Button();
            this.channelsList = new System.Windows.Forms.CheckedListBox();
            this.gbRegulatory.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(15, 32);
            this.labelRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(41, 13);
            this.labelRegion.TabIndex = 0;
            this.labelRegion.Text = "Region";
            // 
            // labelChannelSelection
            // 
            this.labelChannelSelection.AutoSize = true;
            this.labelChannelSelection.Location = new System.Drawing.Point(15, 90);
            this.labelChannelSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChannelSelection.Name = "labelChannelSelection";
            this.labelChannelSelection.Size = new System.Drawing.Size(93, 13);
            this.labelChannelSelection.TabIndex = 1;
            this.labelChannelSelection.Text = "Channel Selection";
            // 
            // gbRegulatory
            // 
            this.gbRegulatory.Controls.Add(this.channelsList);
            this.gbRegulatory.Controls.Add(this.lblHopping);
            this.gbRegulatory.Controls.Add(this.label1);
            this.gbRegulatory.Controls.Add(this.cmbRegions);
            this.gbRegulatory.Controls.Add(this.labelRegion);
            this.gbRegulatory.Controls.Add(this.labelChannelSelection);
            this.gbRegulatory.Location = new System.Drawing.Point(9, 10);
            this.gbRegulatory.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegulatory.Name = "gbRegulatory";
            this.gbRegulatory.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegulatory.Size = new System.Drawing.Size(342, 198);
            this.gbRegulatory.TabIndex = 4;
            this.gbRegulatory.TabStop = false;
            this.gbRegulatory.Text = "Regulatory Config";
            // 
            // lblHopping
            // 
            this.lblHopping.AutoSize = true;
            this.lblHopping.Location = new System.Drawing.Point(151, 60);
            this.lblHopping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHopping.Name = "lblHopping";
            this.lblHopping.Size = new System.Drawing.Size(65, 13);
            this.lblHopping.TabIndex = 7;
            this.lblHopping.Text = "True / False";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Is Hopping Configurable";
            // 
            // cmbRegions
            // 
            this.cmbRegions.DropDownHeight = 100;
            this.cmbRegions.FormattingEnabled = true;
            this.cmbRegions.IntegralHeight = false;
            this.cmbRegions.Location = new System.Drawing.Point(154, 29);
            this.cmbRegions.Name = "cmbRegions";
            this.cmbRegions.Size = new System.Drawing.Size(180, 21);
            this.cmbRegions.TabIndex = 4;
            this.cmbRegions.SelectedIndexChanged += new System.EventHandler(this.cmbRegions_SelectedIndexChanged);
            // 
            // btnApplyRegulatory
            // 
            this.btnApplyRegulatory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApplyRegulatory.Location = new System.Drawing.Point(262, 222);
            this.btnApplyRegulatory.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyRegulatory.Name = "btnApplyRegulatory";
            this.btnApplyRegulatory.Size = new System.Drawing.Size(89, 28);
            this.btnApplyRegulatory.TabIndex = 5;
            this.btnApplyRegulatory.Text = "Apply";
            this.btnApplyRegulatory.UseVisualStyleBackColor = false;
            this.btnApplyRegulatory.Click += new System.EventHandler(this.btnApplyRegulatory_Click);
            // 
            // channelsList
            // 
            this.channelsList.FormattingEnabled = true;
            this.channelsList.Location = new System.Drawing.Point(154, 90);
            this.channelsList.Name = "channelsList";
            this.channelsList.Size = new System.Drawing.Size(180, 94);
            this.channelsList.TabIndex = 8;
            // 
            // Regulatory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.btnApplyRegulatory);
            this.Controls.Add(this.gbRegulatory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regulatory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regulatory";
            this.Load += new System.EventHandler(this.Regulatory_Load);
            this.gbRegulatory.ResumeLayout(false);
            this.gbRegulatory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelChannelSelection;
        private System.Windows.Forms.GroupBox gbRegulatory;
        private System.Windows.Forms.Button btnApplyRegulatory;
        private System.Windows.Forms.ComboBox cmbRegions;
        private System.Windows.Forms.Label lblHopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox channelsList;
    }
}