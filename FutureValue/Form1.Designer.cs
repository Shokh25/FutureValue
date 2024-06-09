namespace FutureValue
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
            txtMonthlyInvestment = new TextBox();
            txtInterestRate = new TextBox();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 43);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 137);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Number of Years:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 179);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(194, 40);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(125, 27);
            txtMonthlyInvestment.TabIndex = 1;
            txtMonthlyInvestment.TextChanged += ClearFutureValues;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(194, 79);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(125, 27);
            txtInterestRate.TabIndex = 2;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(194, 130);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(125, 27);
            txtYears.TabIndex = 3;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(194, 172);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(125, 27);
            txtFutureValue.TabIndex = 7;
            txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(65, 273);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            btnCalculate.MouseLeave += ReturnColor;
            btnCalculate.MouseHover += CalculateChangeColor;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(182, 273);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += ReturnColor;
            btnExit.MouseHover += ExitChangeColor;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtFutureValue);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            DoubleClick += ClearFutureValues;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonthlyInvestment;
        private TextBox txtInterestRate;
        private TextBox txtYears;
        private TextBox txtFutureValue;
        private Button btnCalculate;
        private Button btnExit;
    }
}
