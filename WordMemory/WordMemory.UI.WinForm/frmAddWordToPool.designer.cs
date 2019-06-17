namespace WordMemory.UI.WinForm
{
    partial class frmAddWordToPool
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPoolName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstDictionary = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMyDictionary = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPoolName
            // 
            this.lblPoolName.AutoSize = true;
            this.lblPoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoolName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPoolName.Location = new System.Drawing.Point(324, 26);
            this.lblPoolName.Name = "lblPoolName";
            this.lblPoolName.Size = new System.Drawing.Size(96, 17);
            this.lblPoolName.TabIndex = 15;
            this.lblPoolName.Text = "My Word Pool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dictionary";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(266, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(19, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(266, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(19, 44);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstDictionary
            // 
            this.lstDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lstDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDictionary.FullRowSelect = true;
            this.lstDictionary.GridLines = true;
            this.lstDictionary.Location = new System.Drawing.Point(19, 53);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(207, 225);
            this.lstDictionary.TabIndex = 18;
            this.lstDictionary.UseCompatibleStateImageBehavior = false;
            this.lstDictionary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "English";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Turkish";
            this.columnHeader3.Width = 107;
            // 
            // lstMyDictionary
            // 
            this.lstMyDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4});
            this.lstMyDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMyDictionary.FullRowSelect = true;
            this.lstMyDictionary.GridLines = true;
            this.lstMyDictionary.Location = new System.Drawing.Point(324, 53);
            this.lstMyDictionary.Name = "lstMyDictionary";
            this.lstMyDictionary.Size = new System.Drawing.Size(207, 225);
            this.lstMyDictionary.TabIndex = 18;
            this.lstMyDictionary.UseCompatibleStateImageBehavior = false;
            this.lstMyDictionary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "English";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Turkish";
            this.columnHeader4.Width = 106;
            // 
            // frmAddWordToPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.lstMyDictionary);
            this.Controls.Add(this.lstDictionary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPoolName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Name = "frmAddWordToPool";
            this.Text = "Add To Word Pool";
            this.Load += new System.EventHandler(this.frmCreateNewWordPool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lstDictionary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstMyDictionary;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}