namespace WordMemory.UI.WinForm
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msWordStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.msUserStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.msFinancalStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPayments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLimitedUsers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDictionary,
            this.statisticsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.adminSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msDictionary
            // 
            this.msDictionary.Name = "msDictionary";
            this.msDictionary.Size = new System.Drawing.Size(89, 24);
            this.msDictionary.Text = "Dictionary";
            this.msDictionary.Click += new System.EventHandler(this.DictionarySettingsToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msWordStatistics,
            this.msUserStatistics,
            this.msFinancalStatistics});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // msWordStatistics
            // 
            this.msWordStatistics.Name = "msWordStatistics";
            this.msWordStatistics.Size = new System.Drawing.Size(200, 26);
            this.msWordStatistics.Text = "Word Statistics";
            this.msWordStatistics.Click += new System.EventHandler(this.msWordStatistics_Click);
            // 
            // msUserStatistics
            // 
            this.msUserStatistics.Name = "msUserStatistics";
            this.msUserStatistics.Size = new System.Drawing.Size(200, 26);
            this.msUserStatistics.Text = "User Statistics";
            this.msUserStatistics.Click += new System.EventHandler(this.MsUserStatistics_Click);
            // 
            // msFinancalStatistics
            // 
            this.msFinancalStatistics.Name = "msFinancalStatistics";
            this.msFinancalStatistics.Size = new System.Drawing.Size(200, 26);
            this.msFinancalStatistics.Text = "Financal Statistics";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userStatusToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // userStatusToolStripMenuItem
            // 
            this.userStatusToolStripMenuItem.Name = "userStatusToolStripMenuItem";
            this.userStatusToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.userStatusToolStripMenuItem.Text = "Update Users Status";
            this.userStatusToolStripMenuItem.Click += new System.EventHandler(this.userStatusToolStripMenuItem_Click);
            // 
            // adminSettingsToolStripMenuItem
            // 
            this.adminSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.adminSettingsToolStripMenuItem.Name = "adminSettingsToolStripMenuItem";
            this.adminSettingsToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.adminSettingsToolStripMenuItem.Text = "Admin Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblWordCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 2;
            // 
            // lblWordCount
            // 
            this.lblWordCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWordCount.Location = new System.Drawing.Point(47, 55);
            this.lblWordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(164, 28);
            this.lblWordCount.TabIndex = 5;
            this.lblWordCount.Text = "Sayı";
            this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Word Count";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.lblUserCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(407, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 3;
            // 
            // lblUserCount
            // 
            this.lblUserCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserCount.Location = new System.Drawing.Point(49, 55);
            this.lblUserCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(179, 28);
            this.lblUserCount.TabIndex = 6;
            this.lblUserCount.Text = "Sayı";
            this.lblUserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(71, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total User Count";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(235)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.lblPayments);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(804, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 123);
            this.panel3.TabIndex = 4;
            // 
            // lblPayments
            // 
            this.lblPayments.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPayments.Location = new System.Drawing.Point(43, 55);
            this.lblPayments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(181, 28);
            this.lblPayments.TabIndex = 7;
            this.lblPayments.Text = "Sayı";
            this.lblPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(77, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Payments";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel4.Controls.Add(this.lblLimitedUsers);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(407, 234);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 123);
            this.panel4.TabIndex = 3;
            // 
            // lblLimitedUsers
            // 
            this.lblLimitedUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLimitedUsers.Location = new System.Drawing.Point(49, 55);
            this.lblLimitedUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimitedUsers.Name = "lblLimitedUsers";
            this.lblLimitedUsers.Size = new System.Drawing.Size(179, 28);
            this.lblLimitedUsers.TabIndex = 6;
            this.lblLimitedUsers.Text = "Sayı";
            this.lblLimitedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(56, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Limited User Count";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msDictionary;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.ToolStripMenuItem kelimaBazlıRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financalStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msWordStatistics;
        private System.Windows.Forms.ToolStripMenuItem msUserStatistics;
        private System.Windows.Forms.ToolStripMenuItem msFinancalStatistics;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLimitedUsers;
        private System.Windows.Forms.Label label5;
    }
}