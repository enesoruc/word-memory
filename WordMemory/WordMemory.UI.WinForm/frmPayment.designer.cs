namespace WordMemory.UI.WinForm
{
    partial class frmPayment
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
            this.rdButtonCash = new System.Windows.Forms.RadioButton();
            this.rdButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.numUDCredit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxCreditCard = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxCash = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDCash = new System.Windows.Forms.NumericUpDown();
            this.btnPayment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCredit)).BeginInit();
            this.grpBoxCreditCard.SuspendLayout();
            this.grpBoxCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCash)).BeginInit();
            this.SuspendLayout();
            // 
            // rdButtonCash
            // 
            this.rdButtonCash.AutoSize = true;
            this.rdButtonCash.Location = new System.Drawing.Point(27, 47);
            this.rdButtonCash.Margin = new System.Windows.Forms.Padding(4);
            this.rdButtonCash.Name = "rdButtonCash";
            this.rdButtonCash.Size = new System.Drawing.Size(53, 19);
            this.rdButtonCash.TabIndex = 1;
            this.rdButtonCash.Text = "Cash";
            this.rdButtonCash.UseVisualStyleBackColor = true;
            // 
            // rdButtonCreditCard
            // 
            this.rdButtonCreditCard.AutoSize = true;
            this.rdButtonCreditCard.Checked = true;
            this.rdButtonCreditCard.Location = new System.Drawing.Point(27, 100);
            this.rdButtonCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.rdButtonCreditCard.Name = "rdButtonCreditCard";
            this.rdButtonCreditCard.Size = new System.Drawing.Size(86, 19);
            this.rdButtonCreditCard.TabIndex = 1;
            this.rdButtonCreditCard.TabStop = true;
            this.rdButtonCreditCard.Text = "Credit Card";
            this.rdButtonCreditCard.UseVisualStyleBackColor = true;
            this.rdButtonCreditCard.CheckedChanged += new System.EventHandler(this.rdButtonCreditCard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdButtonCreditCard);
            this.groupBox1.Controls.Add(this.rdButtonCash);
            this.groupBox1.Location = new System.Drawing.Point(45, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(171, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(168, 109);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(298, 21);
            this.txtCardNumber.TabIndex = 0;
            // 
            // numUDCredit
            // 
            this.numUDCredit.DecimalPlaces = 2;
            this.numUDCredit.Location = new System.Drawing.Point(168, 46);
            this.numUDCredit.Margin = new System.Windows.Forms.Padding(4);
            this.numUDCredit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDCredit.Name = "numUDCredit";
            this.numUDCredit.Size = new System.Drawing.Size(80, 21);
            this.numUDCredit.TabIndex = 4;
            this.numUDCredit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Number";
            // 
            // txtCardPassword
            // 
            this.txtCardPassword.Location = new System.Drawing.Point(168, 151);
            this.txtCardPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardPassword.MaxLength = 4;
            this.txtCardPassword.Name = "txtCardPassword";
            this.txtCardPassword.Size = new System.Drawing.Size(298, 21);
            this.txtCardPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card Password";
            // 
            // grpBoxCreditCard
            // 
            this.grpBoxCreditCard.Controls.Add(this.label4);
            this.grpBoxCreditCard.Controls.Add(this.label1);
            this.grpBoxCreditCard.Controls.Add(this.label3);
            this.grpBoxCreditCard.Controls.Add(this.txtCardNumber);
            this.grpBoxCreditCard.Controls.Add(this.label2);
            this.grpBoxCreditCard.Controls.Add(this.txtCardPassword);
            this.grpBoxCreditCard.Controls.Add(this.numUDCredit);
            this.grpBoxCreditCard.Location = new System.Drawing.Point(268, 38);
            this.grpBoxCreditCard.Name = "grpBoxCreditCard";
            this.grpBoxCreditCard.Size = new System.Drawing.Size(482, 230);
            this.grpBoxCreditCard.TabIndex = 6;
            this.grpBoxCreditCard.TabStop = false;
            this.grpBoxCreditCard.Text = "Credit Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(255, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "$";
            // 
            // grpBoxCash
            // 
            this.grpBoxCash.Controls.Add(this.label5);
            this.grpBoxCash.Controls.Add(this.label6);
            this.grpBoxCash.Controls.Add(this.numUDCash);
            this.grpBoxCash.Location = new System.Drawing.Point(237, 38);
            this.grpBoxCash.Name = "grpBoxCash";
            this.grpBoxCash.Size = new System.Drawing.Size(340, 113);
            this.grpBoxCash.TabIndex = 7;
            this.grpBoxCash.TabStop = false;
            this.grpBoxCash.Text = "Cash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(219, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total :";
            // 
            // numUDCash
            // 
            this.numUDCash.DecimalPlaces = 2;
            this.numUDCash.Location = new System.Drawing.Point(117, 37);
            this.numUDCash.Margin = new System.Windows.Forms.Padding(4);
            this.numUDCash.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDCash.Name = "numUDCash";
            this.numUDCash.Size = new System.Drawing.Size(80, 21);
            this.numUDCash.TabIndex = 0;
            this.numUDCash.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(268, 275);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(207, 54);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 386);
            this.Controls.Add(this.grpBoxCash);
            this.Controls.Add(this.grpBoxCreditCard);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCredit)).EndInit();
            this.grpBoxCreditCard.ResumeLayout(false);
            this.grpBoxCreditCard.PerformLayout();
            this.grpBoxCash.ResumeLayout(false);
            this.grpBoxCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdButtonCash;
        private System.Windows.Forms.RadioButton rdButtonCreditCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.NumericUpDown numUDCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxCreditCard;
        private System.Windows.Forms.GroupBox grpBoxCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUDCash;
        private System.Windows.Forms.Button btnPayment;
    }
}