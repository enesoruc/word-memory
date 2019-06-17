namespace WordMemory.UI.WinForm
{
    partial class frmUserStatistics
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
            this.grdViewReports = new System.Windows.Forms.DataGridView();
            this.dtPickerLast = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFirst = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxReportType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewReports
            // 
            this.grdViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewReports.Location = new System.Drawing.Point(30, 190);
            this.grdViewReports.Name = "grdViewReports";
            this.grdViewReports.RowTemplate.Height = 24;
            this.grdViewReports.Size = new System.Drawing.Size(772, 342);
            this.grdViewReports.TabIndex = 10;
            // 
            // dtPickerLast
            // 
            this.dtPickerLast.Enabled = false;
            this.dtPickerLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerLast.Location = new System.Drawing.Point(169, 133);
            this.dtPickerLast.Name = "dtPickerLast";
            this.dtPickerLast.Size = new System.Drawing.Size(150, 20);
            this.dtPickerLast.TabIndex = 8;
            this.dtPickerLast.ValueChanged += new System.EventHandler(this.dtPickerFirst_ValueChanged);
            // 
            // dtPickerFirst
            // 
            this.dtPickerFirst.Enabled = false;
            this.dtPickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFirst.Location = new System.Drawing.Point(169, 90);
            this.dtPickerFirst.Name = "dtPickerFirst";
            this.dtPickerFirst.Size = new System.Drawing.Size(150, 20);
            this.dtPickerFirst.TabIndex = 9;
            this.dtPickerFirst.ValueChanged += new System.EventHandler(this.dtPickerFirst_ValueChanged);
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.Location = new System.Drawing.Point(349, 135);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 26);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "REPORT TYPE :";
            // 
            // cmbBoxReportType
            // 
            this.cmbBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxReportType.FormattingEnabled = true;
            this.cmbBoxReportType.Items.AddRange(new object[] {
            "BY WEEK",
            "BY MONTH",
            "DATES"});
            this.cmbBoxReportType.Location = new System.Drawing.Point(169, 41);
            this.cmbBoxReportType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxReportType.Name = "cmbBoxReportType";
            this.cmbBoxReportType.Size = new System.Drawing.Size(150, 21);
            this.cmbBoxReportType.TabIndex = 5;
            this.cmbBoxReportType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxReportType_SelectedIndexChanged);
            // 
            // frmUserStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 573);
            this.Controls.Add(this.grdViewReports);
            this.Controls.Add(this.dtPickerLast);
            this.Controls.Add(this.dtPickerFirst);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxReportType);
            this.Name = "frmUserStatistics";
            this.Text = "User Based Practice Report";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewReports;
        private System.Windows.Forms.DateTimePicker dtPickerLast;
        private System.Windows.Forms.DateTimePicker dtPickerFirst;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxReportType;
    }
}