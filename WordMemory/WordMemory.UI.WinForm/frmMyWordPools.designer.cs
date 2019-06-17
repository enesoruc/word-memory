namespace WordMemory.UI.WinForm
{
    partial class frmMyWordPools
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
            this.btnUpdatePool = new System.Windows.Forms.Button();
            this.btnDeletePool = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstViewMyPool = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPoolName = new System.Windows.Forms.Label();
            this.lstBoxAllPools = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Word Pools";
            // 
            // btnUpdatePool
            // 
            this.btnUpdatePool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePool.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUpdatePool.Location = new System.Drawing.Point(418, 39);
            this.btnUpdatePool.Name = "btnUpdatePool";
            this.btnUpdatePool.Size = new System.Drawing.Size(97, 31);
            this.btnUpdatePool.TabIndex = 0;
            this.btnUpdatePool.Text = "Update Pool";
            this.btnUpdatePool.UseVisualStyleBackColor = true;
            this.btnUpdatePool.Click += new System.EventHandler(this.btnUpdatePool_Click);
            // 
            // btnDeletePool
            // 
            this.btnDeletePool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePool.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeletePool.Location = new System.Drawing.Point(418, 88);
            this.btnDeletePool.Name = "btnDeletePool";
            this.btnDeletePool.Size = new System.Drawing.Size(97, 26);
            this.btnDeletePool.TabIndex = 1;
            this.btnDeletePool.Text = "Delete Pool";
            this.btnDeletePool.UseVisualStyleBackColor = true;
            this.btnDeletePool.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSave.Location = new System.Drawing.Point(418, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstViewMyPool
            // 
            this.lstViewMyPool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewMyPool.Location = new System.Drawing.Point(230, 27);
            this.lstViewMyPool.Name = "lstViewMyPool";
            this.lstViewMyPool.Size = new System.Drawing.Size(170, 237);
            this.lstViewMyPool.TabIndex = 12;
            this.lstViewMyPool.UseCompatibleStateImageBehavior = false;
            this.lstViewMyPool.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "English";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Turkish";
            this.columnHeader2.Width = 109;
            // 
            // lblPoolName
            // 
            this.lblPoolName.AutoSize = true;
            this.lblPoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.lblPoolName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPoolName.Location = new System.Drawing.Point(238, 7);
            this.lblPoolName.Name = "lblPoolName";
            this.lblPoolName.Size = new System.Drawing.Size(0, 17);
            this.lblPoolName.TabIndex = 13;
            // 
            // lstBoxAllPools
            // 
            this.lstBoxAllPools.FormattingEnabled = true;
            this.lstBoxAllPools.Location = new System.Drawing.Point(32, 52);
            this.lstBoxAllPools.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxAllPools.Name = "lstBoxAllPools";
            this.lstBoxAllPools.Size = new System.Drawing.Size(157, 212);
            this.lstBoxAllPools.TabIndex = 14;
            this.lstBoxAllPools.SelectedValueChanged += new System.EventHandler(this.lstBoxAllPools_SelectedValueChanged);
            // 
            // frmMyWordPools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordMemory.UI.WinForm.Properties.Resources.mywordpool;
            this.ClientSize = new System.Drawing.Size(524, 271);
            this.Controls.Add(this.lstBoxAllPools);
            this.Controls.Add(this.lblPoolName);
            this.Controls.Add(this.lstViewMyPool);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeletePool);
            this.Controls.Add(this.btnUpdatePool);
            this.Controls.Add(this.label1);
            this.Name = "frmMyWordPools";
            this.Text = "My Word Pools";
            this.Load += new System.EventHandler(this.frmMyWordPools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePool;
        private System.Windows.Forms.Button btnDeletePool;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstViewMyPool;
        private System.Windows.Forms.Label lblPoolName;
        private System.Windows.Forms.ListBox lstBoxAllPools;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}