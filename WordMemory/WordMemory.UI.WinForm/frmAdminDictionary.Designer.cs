namespace WordMemory.UI.WinForm
{
    partial class frmAdminDictionary
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
            this.dgvDictionary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDictionary
            // 
            this.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDictionary.Location = new System.Drawing.Point(0, 0);
            this.dgvDictionary.Name = "dgvDictionary";
            this.dgvDictionary.Size = new System.Drawing.Size(835, 445);
            this.dgvDictionary.TabIndex = 0;
            // 
            // frmAdminDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 578);
            this.Controls.Add(this.dgvDictionary);
            this.Name = "frmAdminDictionary";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary Screen";
            this.Load += new System.EventHandler(this.FrmAdminDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDictionary;
    }
}