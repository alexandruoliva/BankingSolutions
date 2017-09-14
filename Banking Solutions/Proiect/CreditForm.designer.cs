namespace BankingSolutions
{
    partial class CreditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditForm));
            this.comboBox_CreditType = new System.Windows.Forms.ComboBox();
            this.creditTypeLabel = new System.Windows.Forms.Label();
            this.comboBox_CreditOption = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageName = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelLoanDuration = new System.Windows.Forms.Label();
            this.labelInterestType = new System.Windows.Forms.Label();
            this.labelARPC = new System.Windows.Forms.Label();
            this.labelFirstRateAmount = new System.Windows.Forms.Label();
            this.labelFinalPayment = new System.Windows.Forms.Label();
            this.buttonApplyForCredit = new System.Windows.Forms.Button();
            this.textBox_LoanAmount = new System.Windows.Forms.TextBox();
            this.textBox_Currency = new System.Windows.Forms.TextBox();
            this.textBox_LoanDuration = new System.Windows.Forms.TextBox();
            this.textBox_InterestType = new System.Windows.Forms.TextBox();
            this.textBox_APRC = new System.Windows.Forms.TextBox();
            this.textBox_FirstRate = new System.Windows.Forms.TextBox();
            this.textBox_TotalSum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_CreditType
            // 
            this.comboBox_CreditType.BackColor = System.Drawing.Color.PaleGreen;
            this.comboBox_CreditType.FormattingEnabled = true;
            this.comboBox_CreditType.Items.AddRange(new object[] {
            "Personal Needs",
            "Real Estate Investment",
            "Auto"});
            this.comboBox_CreditType.Location = new System.Drawing.Point(175, 292);
            this.comboBox_CreditType.Name = "comboBox_CreditType";
            this.comboBox_CreditType.Size = new System.Drawing.Size(150, 21);
            this.comboBox_CreditType.TabIndex = 2;
            this.comboBox_CreditType.SelectedIndexChanged += new System.EventHandler(this.creditTypeComboBox_SelectedIndexChanged);
            // 
            // creditTypeLabel
            // 
            this.creditTypeLabel.AutoSize = true;
            this.creditTypeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditTypeLabel.Location = new System.Drawing.Point(21, 290);
            this.creditTypeLabel.Name = "creditTypeLabel";
            this.creditTypeLabel.Size = new System.Drawing.Size(148, 21);
            this.creditTypeLabel.TabIndex = 8;
            this.creditTypeLabel.Text = "Select credit type: ";
            // 
            // comboBox_CreditOption
            // 
            this.comboBox_CreditOption.AllowDrop = true;
            this.comboBox_CreditOption.BackColor = System.Drawing.Color.PaleGreen;
            this.comboBox_CreditOption.Enabled = false;
            this.comboBox_CreditOption.FormattingEnabled = true;
            this.comboBox_CreditOption.Location = new System.Drawing.Point(175, 319);
            this.comboBox_CreditOption.Name = "comboBox_CreditOption";
            this.comboBox_CreditOption.Size = new System.Drawing.Size(150, 21);
            this.comboBox_CreditOption.TabIndex = 9;
            this.comboBox_CreditOption.SelectedIndexChanged += new System.EventHandler(this.secondOptionComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankingSolutions.Properties.Resources.BankingSolutions2011_logo;
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 189);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pageName
            // 
            this.pageName.AutoSize = true;
            this.pageName.BackColor = System.Drawing.SystemColors.Info;
            this.pageName.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageName.ForeColor = System.Drawing.Color.YellowGreen;
            this.pageName.Location = new System.Drawing.Point(159, 214);
            this.pageName.Name = "pageName";
            this.pageName.Size = new System.Drawing.Size(324, 36);
            this.pageName.TabIndex = 11;
            this.pageName.Text = "Application for credits";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(172, 343);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 16);
            this.descriptionLabel.TabIndex = 12;
            // 
            // labelLoanAmount
            // 
            this.labelLoanAmount.AutoSize = true;
            this.labelLoanAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanAmount.Location = new System.Drawing.Point(21, 371);
            this.labelLoanAmount.Name = "labelLoanAmount";
            this.labelLoanAmount.Size = new System.Drawing.Size(112, 21);
            this.labelLoanAmount.TabIndex = 13;
            this.labelLoanAmount.Text = "Loan amount:";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(314, 371);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(167, 21);
            this.labelCurrency.TabIndex = 14;
            this.labelCurrency.Text = "Currency of the loan:";
            // 
            // labelLoanDuration
            // 
            this.labelLoanDuration.AutoSize = true;
            this.labelLoanDuration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanDuration.Location = new System.Drawing.Point(21, 413);
            this.labelLoanDuration.Name = "labelLoanDuration";
            this.labelLoanDuration.Size = new System.Drawing.Size(121, 21);
            this.labelLoanDuration.TabIndex = 15;
            this.labelLoanDuration.Text = "Loan Duration:";
            // 
            // labelInterestType
            // 
            this.labelInterestType.AutoSize = true;
            this.labelInterestType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterestType.Location = new System.Drawing.Point(314, 411);
            this.labelInterestType.Name = "labelInterestType";
            this.labelInterestType.Size = new System.Drawing.Size(106, 21);
            this.labelInterestType.TabIndex = 16;
            this.labelInterestType.Text = "Interest type:";
            // 
            // labelARPC
            // 
            this.labelARPC.AutoSize = true;
            this.labelARPC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelARPC.Location = new System.Drawing.Point(21, 454);
            this.labelARPC.Name = "labelARPC";
            this.labelARPC.Size = new System.Drawing.Size(64, 21);
            this.labelARPC.TabIndex = 17;
            this.labelARPC.Text = "APRC:";
            // 
            // labelFirstRateAmount
            // 
            this.labelFirstRateAmount.AutoSize = true;
            this.labelFirstRateAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstRateAmount.Location = new System.Drawing.Point(314, 450);
            this.labelFirstRateAmount.Name = "labelFirstRateAmount";
            this.labelFirstRateAmount.Size = new System.Drawing.Size(140, 21);
            this.labelFirstRateAmount.TabIndex = 18;
            this.labelFirstRateAmount.Text = "First rate amount:";
            // 
            // labelFinalPayment
            // 
            this.labelFinalPayment.AutoSize = true;
            this.labelFinalPayment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPayment.Location = new System.Drawing.Point(21, 517);
            this.labelFinalPayment.Name = "labelFinalPayment";
            this.labelFinalPayment.Size = new System.Drawing.Size(140, 21);
            this.labelFinalPayment.TabIndex = 19;
            this.labelFinalPayment.Text = "Total sum to pay:";
            // 
            // buttonApplyForCredit
            // 
            this.buttonApplyForCredit.BackColor = System.Drawing.Color.LightGreen;
            this.buttonApplyForCredit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyForCredit.Location = new System.Drawing.Point(213, 561);
            this.buttonApplyForCredit.Name = "buttonApplyForCredit";
            this.buttonApplyForCredit.Size = new System.Drawing.Size(217, 55);
            this.buttonApplyForCredit.TabIndex = 20;
            this.buttonApplyForCredit.Text = "Apply for credit";
            this.buttonApplyForCredit.UseVisualStyleBackColor = false;
            // 
            // textBox_LoanAmount
            // 
            this.textBox_LoanAmount.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_LoanAmount.Enabled = false;
            this.textBox_LoanAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoanAmount.Location = new System.Drawing.Point(175, 371);
            this.textBox_LoanAmount.Name = "textBox_LoanAmount";
            this.textBox_LoanAmount.Size = new System.Drawing.Size(100, 25);
            this.textBox_LoanAmount.TabIndex = 21;
            this.textBox_LoanAmount.Text = "(none)";
            this.textBox_LoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Currency
            // 
            this.textBox_Currency.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_Currency.Enabled = false;
            this.textBox_Currency.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Currency.Location = new System.Drawing.Point(487, 371);
            this.textBox_Currency.Name = "textBox_Currency";
            this.textBox_Currency.Size = new System.Drawing.Size(100, 25);
            this.textBox_Currency.TabIndex = 22;
            this.textBox_Currency.Text = "(none)";
            this.textBox_Currency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_LoanDuration
            // 
            this.textBox_LoanDuration.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_LoanDuration.Enabled = false;
            this.textBox_LoanDuration.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoanDuration.Location = new System.Drawing.Point(175, 413);
            this.textBox_LoanDuration.Name = "textBox_LoanDuration";
            this.textBox_LoanDuration.Size = new System.Drawing.Size(100, 25);
            this.textBox_LoanDuration.TabIndex = 23;
            this.textBox_LoanDuration.Text = "(none)";
            this.textBox_LoanDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InterestType
            // 
            this.textBox_InterestType.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_InterestType.Enabled = false;
            this.textBox_InterestType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InterestType.Location = new System.Drawing.Point(487, 411);
            this.textBox_InterestType.Name = "textBox_InterestType";
            this.textBox_InterestType.Size = new System.Drawing.Size(100, 25);
            this.textBox_InterestType.TabIndex = 24;
            this.textBox_InterestType.Text = "(none)";
            this.textBox_InterestType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_APRC
            // 
            this.textBox_APRC.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_APRC.Enabled = false;
            this.textBox_APRC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_APRC.Location = new System.Drawing.Point(175, 452);
            this.textBox_APRC.Name = "textBox_APRC";
            this.textBox_APRC.Size = new System.Drawing.Size(100, 25);
            this.textBox_APRC.TabIndex = 25;
            this.textBox_APRC.Text = "(none)";
            this.textBox_APRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FirstRate
            // 
            this.textBox_FirstRate.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_FirstRate.Enabled = false;
            this.textBox_FirstRate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstRate.Location = new System.Drawing.Point(487, 452);
            this.textBox_FirstRate.Name = "textBox_FirstRate";
            this.textBox_FirstRate.Size = new System.Drawing.Size(100, 25);
            this.textBox_FirstRate.TabIndex = 26;
            this.textBox_FirstRate.Text = "(none)";
            this.textBox_FirstRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_TotalSum
            // 
            this.textBox_TotalSum.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_TotalSum.Enabled = false;
            this.textBox_TotalSum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalSum.Location = new System.Drawing.Point(175, 517);
            this.textBox_TotalSum.Name = "textBox_TotalSum";
            this.textBox_TotalSum.Size = new System.Drawing.Size(100, 25);
            this.textBox_TotalSum.TabIndex = 27;
            this.textBox_TotalSum.Text = "(none)";
            this.textBox_TotalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(387, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 28;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_TotalSum);
            this.Controls.Add(this.textBox_FirstRate);
            this.Controls.Add(this.textBox_APRC);
            this.Controls.Add(this.textBox_InterestType);
            this.Controls.Add(this.textBox_LoanDuration);
            this.Controls.Add(this.textBox_Currency);
            this.Controls.Add(this.textBox_LoanAmount);
            this.Controls.Add(this.buttonApplyForCredit);
            this.Controls.Add(this.labelFinalPayment);
            this.Controls.Add(this.labelFirstRateAmount);
            this.Controls.Add(this.labelARPC);
            this.Controls.Add(this.labelInterestType);
            this.Controls.Add(this.labelLoanDuration);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelLoanAmount);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pageName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_CreditOption);
            this.Controls.Add(this.creditTypeLabel);
            this.Controls.Add(this.comboBox_CreditType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditForm";
            this.Text = "Credit Appliance";
            this.Load += new System.EventHandler(this.CreditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_CreditType;
        private System.Windows.Forms.Label creditTypeLabel;
        private System.Windows.Forms.ComboBox comboBox_CreditOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pageName;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label labelLoanAmount;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelLoanDuration;
        private System.Windows.Forms.Label labelInterestType;
        private System.Windows.Forms.Label labelARPC;
        private System.Windows.Forms.Label labelFirstRateAmount;
        private System.Windows.Forms.Label labelFinalPayment;
        private System.Windows.Forms.Button buttonApplyForCredit;
        private System.Windows.Forms.TextBox textBox_LoanAmount;
        private System.Windows.Forms.TextBox textBox_Currency;
        private System.Windows.Forms.TextBox textBox_LoanDuration;
        private System.Windows.Forms.TextBox textBox_InterestType;
        private System.Windows.Forms.TextBox textBox_APRC;
        private System.Windows.Forms.TextBox textBox_FirstRate;
        private System.Windows.Forms.TextBox textBox_TotalSum;
        private System.Windows.Forms.Panel panel1;
    }
}

