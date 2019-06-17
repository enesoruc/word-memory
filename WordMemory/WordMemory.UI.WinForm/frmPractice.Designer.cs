namespace WordMemory.UI.WinForm
{
    partial class frmPractice
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
            this.lstMyPools = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTurToEng = new System.Windows.Forms.Button();
            this.btnEngToTur = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lstInWords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstMyPools
            // 
            this.lstMyPools.FormattingEnabled = true;
            this.lstMyPools.Location = new System.Drawing.Point(33, 49);
            this.lstMyPools.Name = "lstMyPools";
            this.lstMyPools.Size = new System.Drawing.Size(174, 225);
            this.lstMyPools.TabIndex = 4;
            this.lstMyPools.SelectedValueChanged += new System.EventHandler(this.lstMyPools_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "My Pools";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "In Words";
            // 
            // btnTurToEng
            // 
            this.btnTurToEng.Location = new System.Drawing.Point(79, 290);
            this.btnTurToEng.Name = "btnTurToEng";
            this.btnTurToEng.Size = new System.Drawing.Size(75, 23);
            this.btnTurToEng.TabIndex = 0;
            this.btnTurToEng.Text = "Tur - Eng";
            this.btnTurToEng.UseVisualStyleBackColor = true;
            this.btnTurToEng.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEngToTur
            // 
            this.btnEngToTur.Location = new System.Drawing.Point(187, 290);
            this.btnEngToTur.Name = "btnEngToTur";
            this.btnEngToTur.Size = new System.Drawing.Size(75, 23);
            this.btnEngToTur.TabIndex = 1;
            this.btnEngToTur.Text = "Eng - Tur";
            this.btnEngToTur.UseVisualStyleBackColor = true;
            this.btnEngToTur.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(307, 290);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstInWords
            // 
            this.lstInWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstInWords.FullRowSelect = true;
            this.lstInWords.Location = new System.Drawing.Point(241, 33);
            this.lstInWords.Name = "lstInWords";
            this.lstInWords.Size = new System.Drawing.Size(191, 241);
            this.lstInWords.TabIndex = 7;
            this.lstInWords.UseCompatibleStateImageBehavior = false;
            this.lstInWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "English";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Turkish";
            this.columnHeader2.Width = 90;
            // 
            // frmPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.practice;
            this.ClientSize = new System.Drawing.Size(464, 336);
            this.Controls.Add(this.lstInWords);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnEngToTur);
            this.Controls.Add(this.btnTurToEng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMyPools);
            this.Name = "frmPractice";
            this.Text = "Practice Page";
            this.Load += new System.EventHandler(this.frmPractice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMyPools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTurToEng;
        private System.Windows.Forms.Button btnEngToTur;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListView lstInWords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}