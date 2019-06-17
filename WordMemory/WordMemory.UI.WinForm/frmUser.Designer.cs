namespace WordMemory.UI.WinForm
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msMyWordPools = new System.Windows.Forms.ToolStripMenuItem();
            this.msCreateNewWordPool = new System.Windows.Forms.ToolStripMenuItem();
            this.msViewMyWordPools = new System.Windows.Forms.ToolStripMenuItem();
            this.msPractice = new System.Windows.Forms.ToolStripMenuItem();
            this.msAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msUpdateMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.msUpdatePersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.msChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabımıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRoleType = new System.Windows.Forms.Label();
            this.btnGetPremium = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGetPremium = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSuccesRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFalseScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrueScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalTıme = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBoxGetPremium.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(531, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Status : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMyWordPools,
            this.msPractice,
            this.msAccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(719, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMyWordPools
            // 
            this.msMyWordPools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCreateNewWordPool,
            this.msViewMyWordPools});
            this.msMyWordPools.Name = "msMyWordPools";
            this.msMyWordPools.Size = new System.Drawing.Size(100, 26);
            this.msMyWordPools.Text = "My Word Pools";
            // 
            // msCreateNewWordPool
            // 
            this.msCreateNewWordPool.Name = "msCreateNewWordPool";
            this.msCreateNewWordPool.Size = new System.Drawing.Size(194, 22);
            this.msCreateNewWordPool.Text = "Create New Word Pool";
            this.msCreateNewWordPool.Click += new System.EventHandler(this.msCreateNewWordPool_Click);
            // 
            // msViewMyWordPools
            // 
            this.msViewMyWordPools.Name = "msViewMyWordPools";
            this.msViewMyWordPools.Size = new System.Drawing.Size(194, 22);
            this.msViewMyWordPools.Text = "View My Word Pools";
            this.msViewMyWordPools.Click += new System.EventHandler(this.msViewMyWordPools_Click);
            // 
            // msPractice
            // 
            this.msPractice.Name = "msPractice";
            this.msPractice.Size = new System.Drawing.Size(61, 26);
            this.msPractice.Text = "Practice";
            this.msPractice.Click += new System.EventHandler(this.msPractice_Click);
            // 
            // msAccountSettings
            // 
            this.msAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.msAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUpdateMyInfo,
            this.hesabımıSilToolStripMenuItem});
            this.msAccountSettings.Name = "msAccountSettings";
            this.msAccountSettings.Size = new System.Drawing.Size(109, 26);
            this.msAccountSettings.Text = "Account Settings";
            // 
            // msUpdateMyInfo
            // 
            this.msUpdateMyInfo.BackColor = System.Drawing.Color.Transparent;
            this.msUpdateMyInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUpdatePersonalInfo,
            this.msChangePassword});
            this.msUpdateMyInfo.Name = "msUpdateMyInfo";
            this.msUpdateMyInfo.Size = new System.Drawing.Size(156, 22);
            this.msUpdateMyInfo.Text = "Update My Info";
            // 
            // msUpdatePersonalInfo
            // 
            this.msUpdatePersonalInfo.Name = "msUpdatePersonalInfo";
            this.msUpdatePersonalInfo.Size = new System.Drawing.Size(184, 22);
            this.msUpdatePersonalInfo.Text = "Update Personal Info";
            this.msUpdatePersonalInfo.Click += new System.EventHandler(this.msUpdatePersonalInfo_Click);
            // 
            // msChangePassword
            // 
            this.msChangePassword.Name = "msChangePassword";
            this.msChangePassword.Size = new System.Drawing.Size(184, 22);
            this.msChangePassword.Text = "Change Password";
            this.msChangePassword.Click += new System.EventHandler(this.msChangePassword_Click);
            // 
            // hesabımıSilToolStripMenuItem
            // 
            this.hesabımıSilToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.hesabımıSilToolStripMenuItem.Name = "hesabımıSilToolStripMenuItem";
            this.hesabımıSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hesabımıSilToolStripMenuItem.Text = "Delete Account";
            this.hesabımıSilToolStripMenuItem.Click += new System.EventHandler(this.hesabımıSilToolStripMenuItem_Click);
            // 
            // lblRoleType
            // 
            this.lblRoleType.AutoSize = true;
            this.lblRoleType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoleType.ForeColor = System.Drawing.Color.White;
            this.lblRoleType.Location = new System.Drawing.Point(623, 5);
            this.lblRoleType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoleType.Name = "lblRoleType";
            this.lblRoleType.Size = new System.Drawing.Size(52, 17);
            this.lblRoleType.TabIndex = 7;
            this.lblRoleType.Text = "label1";
            // 
            // btnGetPremium
            // 
            this.btnGetPremium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetPremium.BackgroundImage")));
            this.btnGetPremium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetPremium.Location = new System.Drawing.Point(134, 3);
            this.btnGetPremium.Name = "btnGetPremium";
            this.btnGetPremium.Size = new System.Drawing.Size(79, 77);
            this.btnGetPremium.TabIndex = 8;
            this.btnGetPremium.UseVisualStyleBackColor = true;
            this.btnGetPremium.Click += new System.EventHandler(this.btnGetPremium_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "BUY NOW >";
            // 
            // grpBoxGetPremium
            // 
            this.grpBoxGetPremium.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxGetPremium.Controls.Add(this.label1);
            this.grpBoxGetPremium.Controls.Add(this.btnGetPremium);
            this.grpBoxGetPremium.Location = new System.Drawing.Point(494, 26);
            this.grpBoxGetPremium.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxGetPremium.Name = "grpBoxGetPremium";
            this.grpBoxGetPremium.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxGetPremium.Size = new System.Drawing.Size(215, 76);
            this.grpBoxGetPremium.TabIndex = 10;
            this.grpBoxGetPremium.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(333, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(14, 13);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.lblSuccesRate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(410, 316);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 57);
            this.panel3.TabIndex = 15;
            // 
            // lblSuccesRate
            // 
            this.lblSuccesRate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccesRate.Location = new System.Drawing.Point(13, 33);
            this.lblSuccesRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccesRate.Name = "lblSuccesRate";
            this.lblSuccesRate.Size = new System.Drawing.Size(71, 23);
            this.lblSuccesRate.TabIndex = 7;
            this.lblSuccesRate.Text = "% 100";
            this.lblSuccesRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUCCESS RATE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.lblFalseScore);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(252, 357);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 56);
            this.panel2.TabIndex = 14;
            // 
            // lblFalseScore
            // 
            this.lblFalseScore.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFalseScore.Location = new System.Drawing.Point(13, 33);
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
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL FALSE ANSWER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lblTrueScore);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(94, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 57);
            this.panel1.TabIndex = 13;
            // 
            // lblTrueScore
            // 
            this.lblTrueScore.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueScore.Location = new System.Drawing.Point(19, 33);
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
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL TRUE ANSWER";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chartreuse;
            this.panel4.Controls.Add(this.lblTotalTıme);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(562, 357);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 57);
            this.panel4.TabIndex = 15;
            // 
            // lblTotalTıme
            // 
            this.lblTotalTıme.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTıme.Location = new System.Drawing.Point(-47, 33);
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "TOTAL TIME";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.user1;
            this.ClientSize = new System.Drawing.Size(719, 431);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grpBoxGetPremium);
            this.Controls.Add(this.lblRoleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxGetPremium.ResumeLayout(false);
            this.grpBoxGetPremium.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMyWordPools;
        private System.Windows.Forms.ToolStripMenuItem msCreateNewWordPool;
        private System.Windows.Forms.ToolStripMenuItem msViewMyWordPools;
        private System.Windows.Forms.ToolStripMenuItem msPractice;
        private System.Windows.Forms.ToolStripMenuItem msAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem msUpdateMyInfo;
        private System.Windows.Forms.ToolStripMenuItem msUpdatePersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem msChangePassword;
        private System.Windows.Forms.ToolStripMenuItem hesabımıSilToolStripMenuItem;
        private System.Windows.Forms.Label lblRoleType;
        private System.Windows.Forms.Button btnGetPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxGetPremium;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSuccesRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTrueScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFalseScore;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalTıme;
        private System.Windows.Forms.Label label7;
    }
}

