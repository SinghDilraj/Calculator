using System;
using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for IntegerConversions.xaml
    /// </summary>
    public partial class IntegerConversions : Window
    {
        public IntegerConversions()
        {
            InitializeComponent();
        }
        private void ConvertToBinary_Click(object sender, RoutedEventArgs e)
        {
            bool isNum = int.TryParse(InputConvertToBinary.Text, out int num);
            if (!string.IsNullOrEmpty(InputConvertToBinary.Text) && isNum)
            {
                string hexadecimal = Convert.ToString(Convert.ToInt32(InputConvertToBinary.Text), 16);

                string octal = Convert.ToString(Convert.ToInt32(InputConvertToBinary.Text), 8);

                string binary = Convert.ToString(Convert.ToInt32(InputConvertToBinary.Text), 2);

                MessageBox.Show($"Int {InputConvertToBinary.Text} = {hexadecimal} hexadecimal = {octal} octal = {binary} binary", "Conversions");

                InputConvertToBinary.Text = "";
            }
        }
    }
}
