using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for FileSizeConversions.xaml
    /// </summary>
    public partial class FileSizeConversions : Window
    {
        public FileSizeConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Terabytes.Text))
            {
                Empty = false;

                decimal tb = System.Convert.ToDecimal(Terabytes.Text);

                Gigabytes.Text = (tb * 1000).ToString();
                Megabytes.Text = (tb * 1000000).ToString();
                Kilobytes.Text = (tb * 1000000000).ToString();
                Bytes.Text = (tb * 1000000000000).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Gigabytes.Text))
            {
                Empty = false;

                decimal gb = System.Convert.ToDecimal(Gigabytes.Text);

                Terabytes.Text = (gb * 0.001m).ToString();
                Megabytes.Text = (gb * 1000).ToString();
                Kilobytes.Text = (gb * 1000000).ToString();
                Bytes.Text = (gb * 1000000000).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Megabytes.Text))
            {
                Empty = false;

                decimal mb = System.Convert.ToDecimal(Megabytes.Text);

                Terabytes.Text = (mb * 0.000001m).ToString();
                Gigabytes.Text = (mb * 0.000001m).ToString();
                Kilobytes.Text = (mb * 1000).ToString();
                Bytes.Text = (mb * 1000000).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Kilobytes.Text))
            {
                Empty = false;

                decimal kb = System.Convert.ToDecimal(Kilobytes.Text);

                Terabytes.Text = (kb * 0.000000001m).ToString();
                Gigabytes.Text = (kb * 0.000001m).ToString();
                Megabytes.Text = (kb * 0.001m).ToString();
                Bytes.Text = (kb * 1000).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Bytes.Text))
            {
                Empty = false;

                decimal b = System.Convert.ToDecimal(Bytes.Text);

                Terabytes.Text = (b * 0.000000000001m).ToString();
                Gigabytes.Text = (b * 0.000000001m).ToString();
                Megabytes.Text = (b * 0.000001m).ToString();
                Kilobytes.Text = (b * 0.001m).ToString();

                Empty = true;
            }
        }

        private void Bytes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Terabytes.Text = "";
                Gigabytes.Text = "";
                Megabytes.Text = "";
                Kilobytes.Text = "";
            }
        }

        private void Kilobytes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Terabytes.Text = "";
                Gigabytes.Text = "";
                Megabytes.Text = "";
                Bytes.Text = "";
            }
        }

        private void Megabytes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Terabytes.Text = "";
                Gigabytes.Text = "";
                Kilobytes.Text = "";
                Bytes.Text = "";
            }
        }

        private void Gigabytes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Terabytes.Text = "";
                Megabytes.Text = "";
                Kilobytes.Text = "";
                Bytes.Text = "";
            }
        }

        private void Terabytes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Gigabytes.Text = "";
                Megabytes.Text = "";
                Kilobytes.Text = "";
                Bytes.Text = "";
            }
        }
    }
}
