namespace WordMemory.UI.WinForm
{
    partial class frmAdminAddNewWord
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(115, 87);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(191, 20);
            this.txtEnglish.TabIndex = 1;
            // 
            // txtTurkish
            // 
            this.txtTurkish.Location = new System.Drawing.Point(115, 45);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(191, 20);
            this.txtTurkish.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turkish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "English";
            // 
            // frmAdminAddNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurkish);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAdminAddNewWord";
            this.Text = "Add New Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminAddNewWord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}