namespace WordMemory.UI.WinForm
{
    partial class frmUserPractice
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
            this.components = new System.ComponentModel.Container();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblScoreFalse = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuess.Location = new System.Drawing.Point(186, 199);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(5);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(327, 53);
            this.txtGuess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "True :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 299);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 35);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Guess";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(262, 34);
            this.lblScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 31);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(14, 17);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 25);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Finish";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(521, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Your Time :";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWord.ForeColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(268, 116);
            this.lblWord.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(126, 46);
            this.lblWord.TabIndex = 8;
            this.lblWord.Text = "label6";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(626, 14);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(24, 25);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(364, 40);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 17);
            this.label.TabIndex = 2;
            this.label.Text = "False :";
            // 
            // lblScoreFalse
            // 
            this.lblScoreFalse.AutoSize = true;
            this.lblScoreFalse.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreFalse.ForeColor = System.Drawing.Color.White;
            this.lblScoreFalse.Location = new System.Drawing.Point(430, 34);
            this.lblScoreFalse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScoreFalse.Name = "lblScoreFalse";
            this.lblScoreFalse.Size = new System.Drawing.Size(29, 31);
            this.lblScoreFalse.TabIndex = 6;
            this.lblScoreFalse.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Location = new System.Drawing.Point(666, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(23, 17);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "sn";
            // 
            // frmUserPractice
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.userPractice;
            this.ClientSize = new System.Drawing.Size(709, 351);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblScoreFalse);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUserPractice";
            this.Text = "frmUserPractice";
            this.Load += new System.EventHandler(this.frmUserPractice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblScoreFalse;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
    }
}