using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for DecimalPercentConversions.xaml
    /// </summary>
    public partial class DecimalPercentConversions : Window
    {
        public DecimalPercentConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Percent.Text))
            {
                Empty = false;

                decimal p = System.Convert.ToDecimal(Percent.Text);

                Decimal.Text = (p / 100).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Decimal.Text))
            {
                Empty = false;

                decimal d = System.Convert.ToDecimal(Decimal.Text);

                Percent.Text = (d * 100).ToString();

                Empty = true;
            }
        }

        private void Decimal_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Percent.Text = "";
            }
        }

        private void Percent_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Decimal.Text = "";
            }
        }
    }
}
