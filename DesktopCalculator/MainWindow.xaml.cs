using System;
using System.Data;
using System.Numerics;
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
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9") || Result.Text.EndsWith(")"))
            {
                if (!Result.Text.Contains("^"))
                {
                    DataTable dt = new DataTable();
                    Result.Text = dt.Compute(Result.Text.Trim(), "").ToString();
                }
                else
                {
                    string[] nums = Result.Text.Split('^');
                    string[] num1Arr = nums[0].Split(new char[] { '+', '-', '*', '/', '%' });
                    string[] num2Arr = nums[1].Split(new char[] { '+', '-', '*', '/', '%' });
                    string num1 = num1Arr[num1Arr.Length - 1];
                    string num2 = num2Arr[0];
                    int result = Convert.ToInt32(Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)));
                    string result1Arr = nums[0].Remove(nums[0].Length - (num1.Length), num1.Length);
                    string result2Arr = nums[1].Remove(0, num1.Length);
                    string[] resultArr = new string[] { result1Arr, result2Arr };
                    Result.Text = string.Join(result.ToString(), resultArr);
                }
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "7";
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "8";
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "9";
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "4";
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "6";
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "1";
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "3";
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (!Result.Text.EndsWith(")"))
            {
                Result.Text += "0";
            }
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                string[] numArr = Result.Text.Split(new char[] { '+', '-', '*', '/', '%' });
                string num = numArr[numArr.Length - 1];
                num = "(-" + num + ")";
                string result = Result.Text.Remove(Result.Text.Length - (num.Length - 3), num.Length - 3);
                Result.Text = result + num;
            }
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text))
            {
                BigInteger fact = 1;
                for (int i = 1; i <= Convert.ToInt64(Result.Text); i++)
                {
                    fact = fact * i;
                }

                Result.Text = fact.ToString();
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "-";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "+";
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

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                if (!Result.Text.Contains("^"))
                {
                    Result.Text += "^";
                }
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.EndsWith("0") || Result.Text.EndsWith("1") || Result.Text.EndsWith("2") || Result.Text.EndsWith("3") || Result.Text.EndsWith("4") || Result.Text.EndsWith("5") || Result.Text.EndsWith("6") || Result.Text.EndsWith("7") || Result.Text.EndsWith("8") || Result.Text.EndsWith("9"))
            {
                string[] numArr = Result.Text.Split(new char[] { '+', '-', '*', '/', '%' });
                if (!numArr[numArr.Length - 1].Contains("."))
                {
                    Result.Text += ".";
                }
            }
        }

        private void Conversions_Click(object sender, RoutedEventArgs e)
        {
            Conversions conversion = new Conversions();
            conversion.Show();
        }
    }
}
