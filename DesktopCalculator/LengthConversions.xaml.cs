using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for LengthConversions.xaml
    /// </summary>
    public partial class LengthConversions : Window
    {
        public LengthConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Kilometers.Text))
            {
                Empty = false;

                decimal km = System.Convert.ToDecimal(Kilometers.Text);
                Meters.Text = (km * 1000).ToString();
                Centimeters.Text = (km * 100000).ToString();
                Milimeters.Text = (km * 1000000).ToString();
                Feet.Text = (km * 3280.84m).ToString();
                Inches.Text = (km * 39370.08m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Meters.Text))
            {
                Empty = false;

                decimal m = System.Convert.ToDecimal(Meters.Text);
                Kilometers.Text = (m * 0.001m).ToString();
                Centimeters.Text = (m * 100).ToString();
                Milimeters.Text = (m * 1000).ToString();
                Feet.Text = (m * 3.28084m).ToString();
                Inches.Text = (m * 39.37008m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Centimeters.Text))
            {
                Empty = false;

                decimal cm = System.Convert.ToDecimal(Centimeters.Text);
                Kilometers.Text = (cm * 0.00001m).ToString();
                Meters.Text = (cm * 0.01m).ToString();
                Milimeters.Text = (cm * 10).ToString();
                Feet.Text = (cm * 0.0328084m).ToString();
                Inches.Text = (cm * 0.393701m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Milimeters.Text))
            {
                Empty = false;

                decimal mm = System.Convert.ToDecimal(Milimeters.Text);
                Kilometers.Text = (mm * 0.000001m).ToString();
                Meters.Text = (mm * 0.001m).ToString();
                Centimeters.Text = (mm * 100).ToString();
                Feet.Text = (mm * 3.28084m).ToString();
                Inches.Text = (mm * 39.3701m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Feet.Text))
            {
                Empty = false;

                decimal f = System.Convert.ToDecimal(Feet.Text);
                Kilometers.Text = (f * 0.0003048m).ToString();
                Meters.Text = (f * 0.3048m).ToString();
                Centimeters.Text = (f * 30.48m).ToString();
                Milimeters.Text = (f * 304.8m).ToString();
                Inches.Text = (f * 12).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Inches.Text))
            {
                Empty = false;

                decimal i = System.Convert.ToDecimal(Inches.Text);
                Kilometers.Text = (i * 0.0000254m).ToString();
                Meters.Text = (i * 0.0254m).ToString();
                Centimeters.Text = (i * 2.54m).ToString();
                Milimeters.Text = (i * 25.4m).ToString();
                Feet.Text = (i * 0.0833333m).ToString();

                Empty = true;
            }
        }

        private void Kilometers_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Meters.Text = "";
                Centimeters.Text = "";
                Milimeters.Text = "";
                Feet.Text = "";
                Inches.Text = "";
            }
        }

        private void Meters_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilometers.Text = "";
                Centimeters.Text = "";
                Milimeters.Text = "";
                Feet.Text = "";
                Inches.Text = "";
            }
        }

        private void Centimeters_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilometers.Text = "";
                Meters.Text = "";
                Milimeters.Text = "";
                Feet.Text = "";
                Inches.Text = "";
            }
        }

        private void Milimeters_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilometers.Text = "";
                Meters.Text = "";
                Centimeters.Text = "";
                Feet.Text = "";
                Inches.Text = "";
            }
        }

        private void Feet_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilometers.Text = "";
                Meters.Text = "";
                Centimeters.Text = "";
                Milimeters.Text = "";
                Inches.Text = "";
            }
        }

        private void Inches_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilometers.Text = "";
                Meters.Text = "";
                Centimeters.Text = "";
                Milimeters.Text = "";
                Feet.Text = "";
            }
        }
    }
}
