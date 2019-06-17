namespace WordMemory.UI.WinForm
{
    partial class frmWordStatistics
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
            this.cmbBoxReportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtPickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dtPickerLast = new System.Windows.Forms.DateTimePicker();
            this.grdViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxReportType
            // 
            this.cmbBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxReportType.FormattingEnabled = true;
            this.cmbBoxReportType.Items.AddRange(new object[] {
            "BY WEEK",
            "BY MONTH",
            "DATES"});
            this.cmbBoxReportType.Location = new System.Drawing.Point(171, 34);
            this.cmbBoxReportType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxReportType.Name = "cmbBoxReportType";
            this.cmbBoxReportType.Size = new System.Drawing.Size(150, 24);
            this.cmbBoxReportType.TabIndex = 0;
            this.cmbBoxReportType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxReportType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT TYPE :";
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.Location = new System.Drawing.Point(351, 128);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 26);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtPickerFirst
            // 
            this.dtPickerFirst.Enabled = false;
            this.dtPickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFirst.Location = new System.Drawing.Point(171, 83);
            this.dtPickerFirst.Name = "dtPickerFirst";
            this.dtPickerFirst.Size = new System.Drawing.Size(150, 23);
            this.dtPickerFirst.TabIndex = 3;
            this.dtPickerFirst.ValueChanged += new System.EventHandler(this.dtPickerFirst_ValueChanged);
            // 
            // dtPickerLast
            // 
            this.dtPickerLast.Enabled = false;
            this.dtPickerLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerLast.Location = new System.Drawing.Point(171, 126);
            this.dtPickerLast.Name = "dtPickerLast";
            this.dtPickerLast.Size = new System.Drawing.Size(150, 23);
            this.dtPickerLast.TabIndex = 3;
            this.dtPickerLast.ValueChanged += new System.EventHandler(this.dtPickerFirst_ValueChanged);
            // 
            // grdViewReports
            // 
            this.grdViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewReports.Location = new System.Drawing.Point(32, 183);
            this.grdViewReports.Name = "grdViewReports";
            this.grdViewReports.RowTemplate.Height = 24;
            this.grdViewReports.Size = new System.Drawing.Size(772, 342);
            this.grdViewReports.TabIndex = 4;
            // 
            // frmWordStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 573);
            this.Controls.Add(this.grdViewReports);
            this.Controls.Add(this.dtPickerLast);
            this.Controls.Add(this.dtPickerFirst);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxReportType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWordStatistics";
            this.ShowIcon = false;
            this.Text = "Word Add Report";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxReportType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dtPickerFirst;
        private System.Windows.Forms.DateTimePicker dtPickerLast;
        private System.Windows.Forms.DataGridView grdViewReports;
    }
}