using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for Conversions.xaml
    /// </summary>
    public partial class Conversions : Window
    {
        public Conversions()
        {
            InitializeComponent();
        }

        private void IntegerConversions_Click(object sender, RoutedEventArgs e)
        {
            IntegerConversions integerConversions = new IntegerConversions();
            integerConversions.Show();
        }

        private void WeightConversions_Click(object sender, RoutedEventArgs e)
        {
            WeightConversions WeightConversions = new WeightConversions();
            WeightConversions.Show();
        }

        private void TemperatureConversions_Click(object sender, RoutedEventArgs e)
        {
            TemperatureConversions TemperatureConversions = new TemperatureConversions();
            TemperatureConversions.Show();
        }

        private void LengthConversions_Click(object sender, RoutedEventArgs e)
        {
            LengthConversions LengthConversions = new LengthConversions();
            LengthConversions.Show();
        }
    }
}
