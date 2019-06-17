namespace WordMemory.UI.WinForm
{
    partial class frmAdminWordList
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
            this.lstDictionary = new System.Windows.Forms.ListView();
            this.Turkish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDictionary
            // 
            this.lstDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Turkish,
            this.English,
            this.AddedDate,
            this.IsActive});
            this.lstDictionary.FullRowSelect = true;
            this.lstDictionary.GridLines = true;
            this.lstDictionary.Location = new System.Drawing.Point(12, 12);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(558, 356);
            this.lstDictionary.TabIndex = 0;
            this.lstDictionary.UseCompatibleStateImageBehavior = false;
            this.lstDictionary.View = System.Windows.Forms.View.Details;
            // 
            // Turkish
            // 
            this.Turkish.Text = "Turkish";
            this.Turkish.Width = 141;
            // 
            // English
            // 
            this.English.Text = "English";
            this.English.Width = 154;
            // 
            // AddedDate
            // 
            this.AddedDate.Text = "AddedDate";
            this.AddedDate.Width = 148;
            // 
            // IsActive
            // 
            this.IsActive.Text = "IsActive";
            this.IsActive.Width = 109;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmAdminWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 422);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstDictionary);
            this.Name = "frmAdminWordList";
            this.Text = "Update Words";
            this.Load += new System.EventHandler(this.FrmAdminWordList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstDictionary;
        private System.Windows.Forms.ColumnHeader Turkish;
        private System.Windows.Forms.ColumnHeader English;
        private System.Windows.Forms.ColumnHeader AddedDate;
        private System.Windows.Forms.ColumnHeader IsActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}