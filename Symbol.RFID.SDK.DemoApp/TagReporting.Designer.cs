namespace Symbol.RFID.SDK.DemoApp
{
    partial class TagReportingForm
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
            this.applyButton = new System.Windows.Forms.Button();
            this.chkPC = new System.Windows.Forms.CheckBox();
            this.chkRSSI = new System.Windows.Forms.CheckBox();
            this.chkChannelIndex = new System.Windows.Forms.CheckBox();
            this.chkTagSeenCount = new System.Windows.Forms.CheckBox();
            this.chkPhase = new System.Windows.Forms.CheckBox();
            this.chkFirstSeenTime = new System.Windows.Forms.CheckBox();
            this.chkLastSeenTime = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBatchMode = new System.Windows.Forms.Label();
            this.cmbBatchMode = new System.Windows.Forms.ComboBox();
            this.chkReportUniqueTags = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(211, 191);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(81, 28);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // chkPC
            // 
            this.chkPC.AutoSize = true;
            this.chkPC.Location = new System.Drawing.Point(6, 19);
            this.chkPC.Name = "chkPC";
            this.chkPC.Size = new System.Drawing.Size(40, 17);
            this.chkPC.TabIndex = 0;
            this.chkPC.Text = "PC";
            this.chkPC.UseVisualStyleBackColor = true;
            // 
            // chkRSSI
            // 
            this.chkRSSI.AutoSize = true;
            this.chkRSSI.Location = new System.Drawing.Point(6, 42);
            this.chkRSSI.Name = "chkRSSI";
            this.chkRSSI.Size = new System.Drawing.Size(51, 17);
            this.chkRSSI.TabIndex = 1;
            this.chkRSSI.Text = "RSSI";
            this.chkRSSI.UseVisualStyleBackColor = true;
            // 
            // chkChannelIndex
            // 
            this.chkChannelIndex.AutoSize = true;
            this.chkChannelIndex.Location = new System.Drawing.Point(6, 88);
            this.chkChannelIndex.Name = "chkChannelIndex";
            this.chkChannelIndex.Size = new System.Drawing.Size(94, 17);
            this.chkChannelIndex.TabIndex = 3;
            this.chkChannelIndex.Text = "Channel Index";
            this.chkChannelIndex.UseVisualStyleBackColor = true;
            // 
            // chkTagSeenCount
            // 
            this.chkTagSeenCount.AutoSize = true;
            this.chkTagSeenCount.Location = new System.Drawing.Point(174, 65);
            this.chkTagSeenCount.Name = "chkTagSeenCount";
            this.chkTagSeenCount.Size = new System.Drawing.Size(104, 17);
            this.chkTagSeenCount.TabIndex = 4;
            this.chkTagSeenCount.Text = "Tag Seen Count";
            this.chkTagSeenCount.UseVisualStyleBackColor = true;
            // 
            // chkPhase
            // 
            this.chkPhase.AutoSize = true;
            this.chkPhase.Location = new System.Drawing.Point(6, 65);
            this.chkPhase.Name = "chkPhase";
            this.chkPhase.Size = new System.Drawing.Size(56, 17);
            this.chkPhase.TabIndex = 2;
            this.chkPhase.Text = "Phase";
            this.chkPhase.UseVisualStyleBackColor = true;
            // 
            // chkFirstSeenTime
            // 
            this.chkFirstSeenTime.AutoSize = true;
            this.chkFirstSeenTime.Location = new System.Drawing.Point(175, 19);
            this.chkFirstSeenTime.Name = "chkFirstSeenTime";
            this.chkFirstSeenTime.Size = new System.Drawing.Size(99, 17);
            this.chkFirstSeenTime.TabIndex = 5;
            this.chkFirstSeenTime.Text = "First Seen Time";
            this.chkFirstSeenTime.UseVisualStyleBackColor = true;
            // 
            // chkLastSeenTime
            // 
            this.chkLastSeenTime.AutoSize = true;
            this.chkLastSeenTime.Location = new System.Drawing.Point(174, 42);
            this.chkLastSeenTime.Name = "chkLastSeenTime";
            this.chkLastSeenTime.Size = new System.Drawing.Size(100, 17);
            this.chkLastSeenTime.TabIndex = 6;
            this.chkLastSeenTime.Text = "Last Seen Time";
            this.chkLastSeenTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPC);
            this.groupBox1.Controls.Add(this.chkLastSeenTime);
            this.groupBox1.Controls.Add(this.chkRSSI);
            this.groupBox1.Controls.Add(this.chkFirstSeenTime);
            this.groupBox1.Controls.Add(this.chkChannelIndex);
            this.groupBox1.Controls.Add(this.chkPhase);
            this.groupBox1.Controls.Add(this.chkTagSeenCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Reporting";
            // 
            // labelBatchMode
            // 
            this.labelBatchMode.AutoSize = true;
            this.labelBatchMode.Location = new System.Drawing.Point(15, 137);
            this.labelBatchMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBatchMode.Name = "labelBatchMode";
            this.labelBatchMode.Size = new System.Drawing.Size(65, 13);
            this.labelBatchMode.TabIndex = 8;
            this.labelBatchMode.Text = "Batch Mode";
            // 
            // cmbBatchMode
            // 
            this.cmbBatchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchMode.FormattingEnabled = true;
            this.cmbBatchMode.Items.AddRange(new object[] {
            "AUTO",
            "ENABLE",
            "DISABLE"});
            this.cmbBatchMode.Location = new System.Drawing.Point(186, 129);
            this.cmbBatchMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBatchMode.Name = "cmbBatchMode";
            this.cmbBatchMode.Size = new System.Drawing.Size(100, 21);
            this.cmbBatchMode.TabIndex = 7;
            // 
            // chkReportUniqueTags
            // 
            this.chkReportUniqueTags.AutoSize = true;
            this.chkReportUniqueTags.Location = new System.Drawing.Point(18, 165);
            this.chkReportUniqueTags.Name = "chkReportUniqueTags";
            this.chkReportUniqueTags.Size = new System.Drawing.Size(122, 17);
            this.chkReportUniqueTags.TabIndex = 9;
            this.chkReportUniqueTags.Text = "Report Unique Tags";
            this.chkReportUniqueTags.UseVisualStyleBackColor = true;
            // 
            // TagReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 229);
            this.Controls.Add(this.chkReportUniqueTags);
            this.Controls.Add(this.labelBatchMode);
            this.Controls.Add(this.cmbBatchMode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TagReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Reporting";
            this.Load += new System.EventHandler(this.TagReporting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox chkPC;
        private System.Windows.Forms.CheckBox chkRSSI;
        private System.Windows.Forms.CheckBox chkChannelIndex;
        private System.Windows.Forms.CheckBox chkTagSeenCount;
        private System.Windows.Forms.CheckBox chkPhase;
        private System.Windows.Forms.CheckBox chkFirstSeenTime;
        private System.Windows.Forms.CheckBox chkLastSeenTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBatchMode;
        private System.Windows.Forms.ComboBox cmbBatchMode;
        private System.Windows.Forms.CheckBox chkReportUniqueTags;
    }
}