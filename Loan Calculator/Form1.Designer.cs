namespace Loan_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLoanAmount = new TextBox();
            txtDownPayment = new TextBox();
            txtInterestRate = new TextBox();
            txtTerms = new TextBox();
            btnMortgage = new Button();
            btnAuto = new Button();
            lblMonthlyPayment = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 36);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 95);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 0;
            label2.Text = "Down Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 152);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 0;
            label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 207);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 0;
            label4.Text = "Terms in Years:";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(300, 30);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(280, 31);
            txtLoanAmount.TabIndex = 1;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(300, 89);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(280, 31);
            txtDownPayment.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(300, 146);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(280, 31);
            txtInterestRate.TabIndex = 1;
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(300, 201);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(280, 31);
            txtTerms.TabIndex = 1;
            // 
            // btnMortgage
            // 
            btnMortgage.Location = new Point(300, 276);
            btnMortgage.Name = "btnMortgage";
            btnMortgage.Size = new Size(112, 34);
            btnMortgage.TabIndex = 2;
            btnMortgage.Text = "Mortgage";
            btnMortgage.UseVisualStyleBackColor = true;
            btnMortgage.Click += btnMortgage_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(468, 276);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(112, 34);
            btnAuto.TabIndex = 2;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(74, 332);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(170, 25);
            lblMonthlyPayment.TabIndex = 3;
            lblMonthlyPayment.Text = "Monthly Payment: $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(btnAuto);
            Controls.Add(btnMortgage);
            Controls.Add(txtTerms);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDownPayment);
            Controls.Add(txtLoanAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLoanAmount;
        private TextBox txtDownPayment;
        private TextBox txtInterestRate;
        private TextBox txtTerms;
        private Button btnMortgage;
        private Button btnAuto;
        private Label lblMonthlyPayment;
    }
}