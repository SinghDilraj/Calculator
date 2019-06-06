using System.Windows;

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for TimeConversions.xaml
    /// </summary>
    public partial class TimeConversions : Window
    {
        public TimeConversions()
        {
            InitializeComponent();
        }

        public bool Empty = true;

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Hours.Text))
            {
                Empty = false;

                decimal h = System.Convert.ToDecimal(Hours.Text);

                Minutes.Text = (h * 60).ToString();
                Seconds.Text = (h * 3600).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Minutes.Text))
            {
                Empty = false;

                decimal m = System.Convert.ToDecimal(Minutes.Text);

                Hours.Text = (m / 60).ToString();
                Seconds.Text = (m * 60).ToString();

                Empty = true;
            }
            else if (!string.IsNullOrEmpty(Seconds.Text))
            {
                Empty = false;

                decimal s = System.Convert.ToDecimal(Seconds.Text);

                Hours.Text = (s / 3600).ToString();
                Minutes.Text = (s / 60).ToString();

                Empty = true;
            }
        }

        private void Hours_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Minutes.Text = "";
                Seconds.Text = "";
            }
        }

        private void Minutes_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Hours.Text = "";
                Seconds.Text = "";
            }
        }

        private void Seconds_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Empty)
            {
                Hours.Text = "";
                Minutes.Text = "";
            }
        }
    }
}
