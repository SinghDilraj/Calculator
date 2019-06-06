using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for TemperatureConversions.xaml
    /// </summary>
    public partial class TemperatureConversions : Window
    {
        public TemperatureConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Celcius.Text))
            {
                Empty = false;

                decimal c = System.Convert.ToDecimal(Celcius.Text);

                Fahrenheit.Text = ((c * 9) / 5 + 32).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Fahrenheit.Text))
            {
                Empty = false;

                decimal f = System.Convert.ToDecimal(Fahrenheit.Text);

                Celcius.Text = ((f - 32) * 5 / 9).ToString();

                Empty = true;
            }
        }

        private void Celcius_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Fahrenheit.Text = "";
            }
        }

        private void Fahrenheit_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Celcius.Text = "";
            }
        }
    }
}
