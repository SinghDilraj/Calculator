﻿using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for WeightConversions.xaml
    /// </summary>
    public partial class WeightConversions : Window
    {
        public WeightConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Kilograms.Text))
            {
                Empty = false;

                decimal kg = System.Convert.ToDecimal(Kilograms.Text);
                Grams.Text = (kg * 1000).ToString();
                Miligrams.Text = (kg * 1000000).ToString();
                Pounds.Text = (kg * 2.205m).ToString();
                Ounces.Text = (kg * 35.274m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Grams.Text))
            {
                Empty = false;

                decimal g = System.Convert.ToDecimal(Grams.Text);
                Kilograms.Text = (g / 1000).ToString();
                Miligrams.Text = (g * 1000).ToString();
                Pounds.Text = (g / 453.592m).ToString();
                Ounces.Text = (g / 28.35m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Miligrams.Text))
            {
                Empty = false;

                decimal mg = System.Convert.ToDecimal(Miligrams.Text);
                Kilograms.Text = (mg / 1000000).ToString();
                Grams.Text = (mg / 1000).ToString();
                Pounds.Text = (mg / 453592.37m).ToString();
                Ounces.Text = (mg / 28349.523m).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Pounds.Text))
            {
                Empty = false;

                decimal p = System.Convert.ToDecimal(Pounds.Text);
                Kilograms.Text = (p / 2.205m).ToString();
                Grams.Text = (p * 453.592m).ToString();
                Miligrams.Text = (p * 453592.37m).ToString();
                Ounces.Text = (p * 16).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Ounces.Text))
            {
                Empty = false;

                decimal o = System.Convert.ToDecimal(Ounces.Text);
                Kilograms.Text = (o / 35.274m).ToString();
                Grams.Text = (o * 28.35m).ToString();
                Miligrams.Text = (o * 28349.523m).ToString();
                Pounds.Text = (o / 16).ToString();

                Empty = true;
            }
        }

        private void Kilograms_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Ounces.Text = "";
                Grams.Text = "";
                Miligrams.Text = "";
                Pounds.Text = "";
            }
        }

        private void Grams_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Ounces.Text = "";
                Kilograms.Text = "";
                Miligrams.Text = "";
                Pounds.Text = "";
            }
        }

        private void Miligrams_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Ounces.Text = "";
                Kilograms.Text = "";
                Grams.Text = "";
                Pounds.Text = "";
            }
        }

        private void Pounds_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Ounces.Text = "";
                Kilograms.Text = "";
                Grams.Text = "";
                Miligrams.Text = "";
            }
        }

        private void Ounces_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Kilograms.Text = "";
                Grams.Text = "";
                Miligrams.Text = "";
                Pounds.Text = "";
            }
        }
    }
}
