namespace WordMemory.UI.WinForm
{
    partial class frmAdminChangeWord
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "English";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turkish";
            // 
            // txtTurkish
            // 
            this.txtTurkish.Location = new System.Drawing.Point(120, 40);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(191, 20);
            this.txtTurkish.TabIndex = 0;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(120, 82);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(191, 20);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(264, 116);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(47, 17);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Aktif";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // frmAdminChangeWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 191);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurkish);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmAdminChangeWord";
            this.Text = "Change Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminChangeWord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkActive;
    }
}