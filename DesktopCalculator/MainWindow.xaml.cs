using System;
using System.Data;
using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }


        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                DataTable dt = new DataTable();
                Result.Text = dt.Compute(Result.Text.Trim(), "").ToString();
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "9";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "6";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "3";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "0";
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                DataTable dt = new DataTable();
                Result.Text = dt.Compute(Result.Text.Trim(), "").ToString();
                Result.Text = (Convert.ToDecimal(Result.Text) * -1).ToString();
            }
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            int fact = 1;
            for (int i = 1; i <= Convert.ToInt32(Result.Text); i++)
            {
                fact = fact * i;
            }

            Result.Text = fact.ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "-";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "+";
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "0";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "/";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "*";
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                Result.Text += "%";
            }
        }

        private void SquareRoot_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                Result.Text = Math.Sqrt(Convert.ToDouble(Result.Text)).ToString();
            }
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                Result.Text = Math.Pow(Convert.ToDouble(Result.Text), 2).ToString();
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                Result.Text += ".";
            }
        }
    }
}
