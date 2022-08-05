namespace Symbol.RFID.SDK.DemoApp
{
    partial class PreFilters
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
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelTagPattern = new System.Windows.Forms.Label();
            this.gbPreFilters = new System.Windows.Forms.GroupBox();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffSet = new System.Windows.Forms.TextBox();
            this.cmbMemoryBank = new System.Windows.Forms.ComboBox();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.txtTagPattern = new System.Windows.Forms.TextBox();
            this.labelOffset = new System.Windows.Forms.Label();
            this.labelMemBank = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.gbPreFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(15, 29);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "Filter";
            // 
            // labelTagPattern
            // 
            this.labelTagPattern.AutoSize = true;
            this.labelTagPattern.Location = new System.Drawing.Point(15, 103);
            this.labelTagPattern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTagPattern.Name = "labelTagPattern";
            this.labelTagPattern.Size = new System.Drawing.Size(63, 13);
            this.labelTagPattern.TabIndex = 9;
            this.labelTagPattern.Text = "Tag Pattern";
            // 
            // gbPreFilters
            // 
            this.gbPreFilters.Controls.Add(this.cmbFilters);
            this.gbPreFilters.Controls.Add(this.chkEnable);
            this.gbPreFilters.Controls.Add(this.label1);
            this.gbPreFilters.Controls.Add(this.txtOffSet);
            this.gbPreFilters.Controls.Add(this.cmbMemoryBank);
            this.gbPreFilters.Controls.Add(this.cmbAction);
            this.gbPreFilters.Controls.Add(this.cmbTarget);
            this.gbPreFilters.Controls.Add(this.txtTagPattern);
            this.gbPreFilters.Controls.Add(this.labelOffset);
            this.gbPreFilters.Controls.Add(this.labelMemBank);
            this.gbPreFilters.Controls.Add(this.labelAction);
            this.gbPreFilters.Controls.Add(this.labelTarget);
            this.gbPreFilters.Controls.Add(this.labelFilter);
            this.gbPreFilters.Controls.Add(this.labelTagPattern);
            this.gbPreFilters.Location = new System.Drawing.Point(9, 10);
            this.gbPreFilters.Margin = new System.Windows.Forms.Padding(2);
            this.gbPreFilters.Name = "gbPreFilters";
            this.gbPreFilters.Padding = new System.Windows.Forms.Padding(2);
            this.gbPreFilters.Size = new System.Drawing.Size(342, 228);
            this.gbPreFilters.TabIndex = 0;
            this.gbPreFilters.TabStop = false;
            this.gbPreFilters.Text = "Pre Filters";
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Location = new System.Drawing.Point(149, 27);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(180, 21);
            this.cmbFilters.TabIndex = 14;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(149, 54);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(15, 14);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enable";
            // 
            // txtOffSet
            // 
            this.txtOffSet.Location = new System.Drawing.Point(149, 198);
            this.txtOffSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtOffSet.Name = "txtOffSet";
            this.txtOffSet.Size = new System.Drawing.Size(180, 20);
            this.txtOffSet.TabIndex = 6;
            this.txtOffSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericInput_KeyPress);
            // 
            // cmbMemoryBank
            // 
            this.cmbMemoryBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryBank.FormattingEnabled = true;
            this.cmbMemoryBank.Location = new System.Drawing.Point(149, 148);
            this.cmbMemoryBank.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemoryBank.Name = "cmbMemoryBank";
            this.cmbMemoryBank.Size = new System.Drawing.Size(180, 21);
            this.cmbMemoryBank.TabIndex = 4;
            // 
            // cmbAction
            // 
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Location = new System.Drawing.Point(149, 173);
            this.cmbAction.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(180, 21);
            this.cmbAction.TabIndex = 5;
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(149, 123);
            this.cmbTarget.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(180, 21);
            this.cmbTarget.TabIndex = 3;
            // 
            // txtTagPattern
            // 
            this.txtTagPattern.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPattern.Location = new System.Drawing.Point(149, 99);
            this.txtTagPattern.Margin = new System.Windows.Forms.Padding(2);
            this.txtTagPattern.Name = "txtTagPattern";
            this.txtTagPattern.Size = new System.Drawing.Size(180, 20);
            this.txtTagPattern.TabIndex = 2;
            this.txtTagPattern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.Location = new System.Drawing.Point(15, 202);
            this.labelOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(72, 13);
            this.labelOffset.TabIndex = 13;
            this.labelOffset.Text = "Offset (words)";
            // 
            // labelMemBank
            // 
            this.labelMemBank.AutoSize = true;
            this.labelMemBank.Location = new System.Drawing.Point(15, 151);
            this.labelMemBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemBank.Name = "labelMemBank";
            this.labelMemBank.Size = new System.Drawing.Size(72, 13);
            this.labelMemBank.TabIndex = 11;
            this.labelMemBank.Text = "Memory Bank";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(15, 176);
            this.labelAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(37, 13);
            this.labelAction.TabIndex = 12;
            this.labelAction.Text = "Action";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(15, 126);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(38, 13);
            this.labelTarget.TabIndex = 10;
            this.labelTarget.Text = "Target";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApplyFilter.Location = new System.Drawing.Point(262, 247);
            this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(89, 28);
            this.btnApplyFilter.TabIndex = 1;
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // PreFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 286);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.gbPreFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pre Filters";
            this.Load += new System.EventHandler(this.PreFilters_Load);
            this.gbPreFilters.ResumeLayout(false);
            this.gbPreFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelTagPattern;
        private System.Windows.Forms.GroupBox gbPreFilters;
        private System.Windows.Forms.TextBox txtOffSet;
        private System.Windows.Forms.ComboBox cmbMemoryBank;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.TextBox txtTagPattern;
        private System.Windows.Forms.Label labelOffset;
        private System.Windows.Forms.Label labelMemBank;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilters;
    }
}