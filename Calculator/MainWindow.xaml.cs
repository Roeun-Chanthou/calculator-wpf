using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double fNumber = 0;
        double sNumber = 0;
        private int option;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                string a = txtDisplay.Text;
                txtDisplay.Text = a.Remove(a.Length - 1, 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }
        private void btAC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btdot_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {


            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtDisplay.Text += ((Button)sender).Content.ToString();
            }
        }
        private void btx2_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = Math.Pow(fNumber, 2.0);
            txtDisplay.Text = result.ToString();

        }

        private void btx3_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = Math.Pow(fNumber, 3.0);
            txtDisplay.Text = result.ToString();
        }

        private void bt2x_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = Math.Pow(fNumber, 0.5);
            txtDisplay.Text = result.ToString();
        }

        private void bt3x_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = Math.Pow(fNumber, 1.0 / 3.0);
            txtDisplay.Text = result.ToString();
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }
        private void btsin_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());

            double radians = DegreesToRadians(fNumber);

            double result = Math.Sin(radians);

            txtDisplay.Text = result.ToString();
        }

        private void btcos_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double radians = DegreesToRadians(fNumber);
            double result = Math.Cos(radians);
            txtDisplay.Text = result.ToString();
        }

        private void bttan_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());

            double radians = DegreesToRadians(fNumber);


            if (fNumber % 180 == 90)
            {
                txtDisplay.Text = "∞";
            }
            else
            {

                double result = Math.Tan(radians);

                if (Math.Abs(result) < 1e-10)
                {
                    result = 0;
                }

                txtDisplay.Text = result.ToString();
            }
        }

        private void bt1x_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = 1 / fNumber;
            txtDisplay.Text = result.ToString();
        }

        private void bt100x_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            double result = fNumber / 100;
            txtDisplay.Text = result.ToString();
        }
        private void btnNegativeOrPositive_Click(object sender, RoutedEventArgs e)
        {
            double temp = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (temp * -1).ToString();
        }

        private void btp_Click(object sender, RoutedEventArgs e)
        {

            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 1;
        }
        private void bts_Click(object sender, RoutedEventArgs e)
        {

            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 2;
        }

        private void btnx_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 3;
        }

        private void btper_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 4;
        }

        private void btmi_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 5;
        }

        private void btm_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 6;
        }

        private void btxn_Click(object sender, RoutedEventArgs e)
        {
            fNumber = double.Parse(txtDisplay.Text.ToString());
            txtDisplay.Text = "0";
            option = 7;
        }

        private void btass_Click(object sender, RoutedEventArgs e)
        {
            sNumber = double.Parse(txtDisplay.Text.ToString());

            switch (option)
            {
                case 1:
                    txtDisplay.Text = (fNumber + sNumber).ToString();
                    break;
                case 2:
                    txtDisplay.Text = (fNumber - sNumber).ToString();
                    break;
                case 3:
                    txtDisplay.Text = Math.Pow(fNumber, 1 / sNumber).ToString();
                    break;
                case 4:
                    txtDisplay.Text = (fNumber % sNumber).ToString();
                    break;
                case 5:
                    txtDisplay.Text = (fNumber / sNumber).ToString();
                    break;
                case 6:
                    txtDisplay.Text = (fNumber * sNumber).ToString();
                    break;
                case 7:
                    txtDisplay.Text = Math.Pow(fNumber, sNumber).ToString();
                    break;
            }
        }


    }
}
