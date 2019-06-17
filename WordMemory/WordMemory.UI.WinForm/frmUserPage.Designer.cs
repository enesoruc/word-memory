namespace WordMemory.UI.WinForm
{
    partial class frmUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myWordPoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWordPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyWordPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSttingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpBoxGetPremium = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetPremium = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalTıme = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSuccesRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFalseScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrueScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBoxGetPremium.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myWordPoolsToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.accountSttingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myWordPoolsToolStripMenuItem
            // 
            this.myWordPoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewWordPoolToolStripMenuItem,
            this.viewMyWordPoolToolStripMenuItem});
            this.myWordPoolsToolStripMenuItem.Name = "myWordPoolsToolStripMenuItem";
            this.myWordPoolsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.myWordPoolsToolStripMenuItem.Text = "My Word Pools";
            // 
            // createNewWordPoolToolStripMenuItem
            // 
            this.createNewWordPoolToolStripMenuItem.Name = "createNewWordPoolToolStripMenuItem";
            this.createNewWordPoolToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createNewWordPoolToolStripMenuItem.Text = "Create New Word Pool";
            // 
            // viewMyWordPoolToolStripMenuItem
            // 
            this.viewMyWordPoolToolStripMenuItem.Name = "viewMyWordPoolToolStripMenuItem";
            this.viewMyWordPoolToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.viewMyWordPoolToolStripMenuItem.Text = "View My Word Pool";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.practiceToolStripMenuItem.Text = "Practice";
            // 
            // accountSttingsToolStripMenuItem
            // 
            this.accountSttingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMyInfoToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.accountSttingsToolStripMenuItem.Name = "accountSttingsToolStripMenuItem";
            this.accountSttingsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.accountSttingsToolStripMenuItem.Text = "Account Settings";
            // 
            // updateMyInfoToolStripMenuItem
            // 
            this.updateMyInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePersonalInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.updateMyInfoToolStripMenuItem.Name = "updateMyInfoToolStripMenuItem";
            this.updateMyInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updateMyInfoToolStripMenuItem.Text = "Update My Info";
            // 
            // updatePersonalInfoToolStripMenuItem
            // 
            this.updatePersonalInfoToolStripMenuItem.Name = "updatePersonalInfoToolStripMenuItem";
            this.updatePersonalInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.updatePersonalInfoToolStripMenuItem.Text = "Update Personal Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(568, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(678, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "1";
            // 
            // grpBoxGetPremium
            // 
            this.grpBoxGetPremium.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxGetPremium.Controls.Add(this.label3);
            this.grpBoxGetPremium.Controls.Add(this.btnGetPremium);
            this.grpBoxGetPremium.Location = new System.Drawing.Point(541, 18);
            this.grpBoxGetPremium.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxGetPremium.Name = "grpBoxGetPremium";
            this.grpBoxGetPremium.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxGetPremium.Size = new System.Drawing.Size(215, 88);
            this.grpBoxGetPremium.TabIndex = 11;
            this.grpBoxGetPremium.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "BUY NOW >";
            // 
            // btnGetPremium
            // 
            this.btnGetPremium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetPremium.BackgroundImage")));
            this.btnGetPremium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetPremium.Location = new System.Drawing.Point(134, 7);
            this.btnGetPremium.Name = "btnGetPremium";
            this.btnGetPremium.Size = new System.Drawing.Size(79, 77);
            this.btnGetPremium.TabIndex = 8;
            this.btnGetPremium.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(377, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Welcome :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(455, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel4.Controls.Add(this.lblTotalTıme);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(642, 322);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 57);
            this.panel4.TabIndex = 18;
            // 
            // lblTotalTıme
            // 
            this.lblTotalTıme.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTıme.Location = new System.Drawing.Point(-47, 37);
            this.lblTotalTıme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTıme.Name = "lblTotalTıme";
            this.lblTotalTıme.Size = new System.Drawing.Size(196, 23);
            this.lblTotalTıme.TabIndex = 7;
            this.lblTotalTıme.Text = "0";
            this.lblTotalTıme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "TOTAL TIME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel3.Controls.Add(this.lblSuccesRate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(642, 384);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 57);
            this.panel3.TabIndex = 19;
            // 
            // lblSuccesRate
            // 
            this.lblSuccesRate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccesRate.Location = new System.Drawing.Point(8, 37);
            this.lblSuccesRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccesRate.Name = "lblSuccesRate";
            this.lblSuccesRate.Size = new System.Drawing.Size(71, 23);
            this.lblSuccesRate.TabIndex = 7;
            this.lblSuccesRate.Text = "% 100";
            this.lblSuccesRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SUCCESS RATE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.lblFalseScore);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(481, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 56);
            this.panel2.TabIndex = 17;
            // 
            // lblFalseScore
            // 
            this.lblFalseScore.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFalseScore.Location = new System.Drawing.Point(3, 37);
            this.lblFalseScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFalseScore.Name = "lblFalseScore";
            this.lblFalseScore.Size = new System.Drawing.Size(134, 23);
            this.lblFalseScore.TabIndex = 6;
            this.lblFalseScore.Text = "0";
            this.lblFalseScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL FALSE ANSWER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.lblTrueScore);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(481, 322);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 57);
            this.panel1.TabIndex = 16;
            // 
            // lblTrueScore
            // 
            this.lblTrueScore.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueScore.Location = new System.Drawing.Point(17, 37);
            this.lblTrueScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrueScore.Name = "lblTrueScore";
            this.lblTrueScore.Size = new System.Drawing.Size(123, 23);
            this.lblTrueScore.TabIndex = 5;
            this.lblTrueScore.Text = "0";
            this.lblTrueScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL TRUE ANSWER";
            // 
            // frmUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.Başlıksız_3;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpBoxGetPremium);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserPage";
            this.Text = "frmUserPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxGetPremium.ResumeLayout(false);
            this.grpBoxGetPremium.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myWordPoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWordPoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyWordPoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSttingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpBoxGetPremium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetPremium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalTıme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSuccesRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFalseScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTrueScore;
        private System.Windows.Forms.Label label6;
    }
}