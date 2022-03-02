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

namespace WPFCalculator
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
        string emeliyyat;
        int firstnumber;
        int secondnumber;
        private void button_1_Click(object sender, RoutedEventArgs e)
        {

            if(string.IsNullOrWhiteSpace( ekran.Text))  ekran.Text = "1";
            else {
                ekran.Text += "1";
                 
             }
                    
       
        }

        private void button_2_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "2";
            else ekran.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "3";
            else ekran.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "4";
            else ekran.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "5";
            else ekran.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "6";
            else ekran.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "7";
            else ekran.Text += "7";
        }
        private void button_8_Click_1(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "8";
            else ekran.Text += "8";
        }
        private void button_9_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "9";
            else ekran.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {

            if (ekran.Text == "0") ekran.Text = "0";
            else ekran.Text += "0";
        }

        private void button_bolbire_Click(object sender, EventArgs e)
        {
            double number = int.Parse(ekran.Text);
            ekran.Text = (1 / number).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = int.Parse(ekran.Text);
            ekran.Text = (Math.Sqrt(number)).ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            emeliyyat = "+";
            firstnumber = int.Parse(ekran.Text);

            ekran.Text += "+";

        }

        private void button_beraber_Click(object sender, EventArgs e)
        {
            if (emeliyyat != null)
            {
                secondnumber = int.Parse(ekran.Text);
                if (emeliyyat == "+")
                {
                    ekran.Text = "0";
                    ekran.Text = (firstnumber + secondnumber).ToString();

                }
                else if (emeliyyat == "-")
                {
                    ekran.Text = "0";
                    ekran.Text = (firstnumber - secondnumber).ToString();

                }
                else if (emeliyyat == "*")
                {
                    ekran.Text = "0";
                    ekran.Text = (firstnumber * secondnumber).ToString();

                }
                else if (emeliyyat == "/")
                {
                    if (secondnumber == 0)
                    {
                        ekran.Text = "Xeta";

                    }
                    else
                    {
                        ekran.Text = "0";
                        ekran.Text = (firstnumber / secondnumber).ToString();
                    }


                }
                else if (emeliyyat == "^")
                {
                    ekran.Text = "0";

                    ekran.Text = (Math.Pow(firstnumber, secondnumber)).ToString();

                }
            }

            emeliyyat = null;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            emeliyyat = "-";
            firstnumber = int.Parse(ekran.Text);


            ekran.Text = "0";

        }

        private void button_vur_Click(object sender, EventArgs e)
        {
            emeliyyat = "*";
            firstnumber = int.Parse(ekran.Text);

            ekran.Text = "0";

        }

        private void button_bolme_Click(object sender, EventArgs e)
        {
            emeliyyat = "/";
            firstnumber = int.Parse(ekran.Text);

            ekran.Text = "0";

        }

        private void button_kvadrat_Click(object sender, EventArgs e)
        {
            emeliyyat = "^";
            firstnumber = int.Parse(ekran.Text);

            ekran.Text = "0";


        }
        private void button_plusminus_Click(object sender, EventArgs e)
        {
            double number = int.Parse(ekran.Text);
            ekran.Text = (number * (-1)).ToString();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (ekran.Text != null && ekran.Text != "0")
            {
                string number = (ekran.Text);
                ekran.Text = (number.Remove(number.Length - 1)).ToString();
            }

        }

        private void button_vergul_Click(object sender, EventArgs e)
        {
            string number = (ekran.Text);

            if (number[number.Length - 1] != ',') ekran.Text += ",";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }

        private void button_faiz_Click(object sender, EventArgs e)
        {
            double number = int.Parse(ekran.Text);
            ekran.Text = (number / 100).ToString();
        }



    }
}
