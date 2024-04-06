namespace Tutorial_02
{
    public partial class tutorial_02 : Form
    {
        public tutorial_02()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string fromCurrencyName = txtFromCurrencyName.Text;
            string toCurrencyName = txtToCurrencyName.Text;
            double fromCurrencyAnmount;
            double exchangeRate;

            if (!double.TryParse(txtFromCurrencyAmount.Text, out fromCurrencyAnmount))
            {
                MessageBox.Show("Please ender a valid Currency Amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                fromCurrencyAnmount= Math.Round(fromCurrencyAnmount, 2);
            }

            if (!double.TryParse(txtExchangeRate.Text, out exchangeRate))
            {
                MessageBox.Show("Please ender a valid Exchange Rate", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double toCurrencyAmount = fromCurrencyAnmount * exchangeRate;
            toCurrencyAmount = Math.Round(toCurrencyAmount, 6);
            string message = $"From Currency = {fromCurrencyAnmount} {fromCurrencyName}\nExchange Rate (1 {fromCurrencyName} = {exchangeRate} {toCurrencyName})\nTo Currency = {toCurrencyAmount} {toCurrencyName}";
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}