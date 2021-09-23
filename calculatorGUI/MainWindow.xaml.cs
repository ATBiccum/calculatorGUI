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

namespace calculatorGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Division
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                firstTextBox.Text = "Error: Invalid Char";
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                secondTextBox.Text = "Error: Invalid Char";
            }

            if (cleanNum2 == 0)                                         //Check if we are trying to divide by zero
            {                                                           //Returns an error if trying to divide by zero
                secondTextBox.Clear();
                secondTextBox.Text = "Error: Div by 0";
            }

            double temp = cleanNum1 / cleanNum2;
            textAnswer.Text = Convert.ToString(temp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Mupliplication
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                firstTextBox.Text = "Error: Invalid Char";
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                secondTextBox.Text = "Error: Invalid Char";
            }

            double temp = cleanNum1 * cleanNum2;
            textAnswer.Text = Convert.ToString(temp);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Subtraction
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                firstTextBox.Text = "Error: Invalid Char";
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                secondTextBox.Text = "Error: Invalid Char";
            }

            double temp = cleanNum1 - cleanNum2;
            textAnswer.Text = Convert.ToString(temp);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Addition
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                firstTextBox.Text = "Error: Invalid Char";
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                secondTextBox.Text = "Error: Invalid Char";
            }

            double temp = cleanNum1 + cleanNum2;
            textAnswer.Text = Convert.ToString(temp);
        }
    }
}
