namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
                int years = Convert.ToInt32(txtYears.Text);

                int months = years * 12;
                decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                decimal futureValue = CalculateFutureValue(0, monthlyInvestment, monthlyInterestRate, months);

                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("You enter incorrect data");
            }
        }

        private decimal CalculateFutureValue(decimal futureValue, decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFutureValues(object sender, EventArgs e)
        {
            txtInterestRate.Text = "";
            txtYears.Text = "";
            txtFutureValue.Text = "";
        }



        
        

        private void ReturnColor(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
            btnCalculate.ForeColor = Color.Black;
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Black;
        }

        private void CalculateChangeColor(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Navy;
            btnCalculate.ForeColor = Color.White;
        }

        private void ExitChangeColor(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Olive;
            btnExit.ForeColor = Color.White;
        }
    }
}
