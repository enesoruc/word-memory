namespace WordMemory.UI.WinForm
{
    partial class frmCreateNewWordPool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoolName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewPool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter a Name for New Word Pool";
            // 
            // txtPoolName
            // 
            this.txtPoolName.Location = new System.Drawing.Point(155, 78);
            this.txtPoolName.Name = "txtPoolName";
            this.txtPoolName.Size = new System.Drawing.Size(275, 23);
            this.txtPoolName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pool Name :";
            // 
            // btnCreateNewPool
            // 
            this.btnCreateNewPool.Location = new System.Drawing.Point(155, 127);
            this.btnCreateNewPool.Name = "btnCreateNewPool";
            this.btnCreateNewPool.Size = new System.Drawing.Size(105, 34);
            this.btnCreateNewPool.TabIndex = 1;
            this.btnCreateNewPool.Text = "Create Pool";
            this.btnCreateNewPool.UseVisualStyleBackColor = true;
            this.btnCreateNewPool.Click += new System.EventHandler(this.btnCreateNewPool_Click);
            // 
            // frmCreateNewWordPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.createNewPool2;
            this.ClientSize = new System.Drawing.Size(449, 186);
            this.Controls.Add(this.btnCreateNewPool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoolName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateNewWordPool";
            this.Text = "Create New Word Pool";
            this.Load += new System.EventHandler(this.frmCreateNewWordPool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewPool;
    }
}