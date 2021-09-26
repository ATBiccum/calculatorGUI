

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

        private void buttDivide_Click(object sender, RoutedEventArgs e)
        {
            //Division
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            if (cleanNum2 == 0)                                         //Check if we are trying to divide by zero
            {                                                           //Returns an error if trying to divide by zero
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Div by 0";
                errorFlag = true;
            }

            if (!errorFlag)
            {
                double temp = cleanNum1 / cleanNum2;
                textAnswer.Text = Convert.ToString(temp);
            }
        }

        private void buttMultiplication_Click(object sender, RoutedEventArgs e)
        {
            //Mupliplication
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            if (!errorFlag)
            {
                double temp = cleanNum1 * cleanNum2;
                textAnswer.Text = Convert.ToString(temp);
            }
        }

        private void buttSubtraction_Click(object sender, RoutedEventArgs e)
        {
            //Subtraction
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //Checks for valid characters and if div by 0
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            if(!errorFlag)
            {
                double temp = cleanNum1 - cleanNum2;
                textAnswer.Text = Convert.ToString(temp);
            }
        }

        private void buttAddition_Click(object sender, RoutedEventArgs e)
        {
            //Addition
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;


            //Checks for valid characters
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                           //If a unvalid character will trigger warning
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           //Will check if unvalid value and return warning
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            if(!errorFlag)
            {
                double temp = cleanNum1 + cleanNum2;
                textAnswer.Text = Convert.ToString(temp);
            }
        }

        private void firstTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            firstTextBox.Clear();
            textAnswer.Clear();
        }

        private void secondTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            secondTextBox.Clear();
            textAnswer.Clear();
        }
    }
}
