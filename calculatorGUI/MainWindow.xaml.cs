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
            double num1 = Convert.ToDouble(firstTextBox.Text);
            double num2 = Convert.ToDouble(secondTextBox.Text);
            double temp = num1 / num2;
            textAnswer.Text = Convert.ToString(temp);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Mupliplication
            double num1 = Convert.ToDouble(firstTextBox.Text);
            double num2 = Convert.ToDouble(secondTextBox.Text);
            double temp = num1 * num2;
            textAnswer.Text = Convert.ToString(temp);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Subtraction
            double num1 = Convert.ToDouble(firstTextBox.Text);
            double num2 = Convert.ToDouble(secondTextBox.Text);
            double temp = num1 - num2;
            textAnswer.Text = Convert.ToString(temp);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Addition

            //double num1 = Convert.ToDouble(firstTextBox.Text);
            //double num2 = Convert.ToDouble(secondTextBox.Text);

            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;

            double cleanNum1 = debugFirstBox(num1);
            double cleanNum2 = debugSecondBox(num2);

            double temp = cleanNum1 + cleanNum2;
            textAnswer.Text = Convert.ToString(temp);
        }

        public double debugFirstBox(string number)
        {
            //Goal: Return a double that has been error checked and converted from string

            double cleanNumber = 0;
            if (!double.TryParse(number, out cleanNumber))                     //Try parse converts string to a double and saves under clean new name
            {                                                                  //If a unvalid character will trigger warning
                firstTextBox.Clear();
                firstTextBox.Text = "Invalid Character: Try again";
            }
            return cleanNumber;
        }
        public double debugSecondBox(string number)
        {
            //Goal: Return a double that has been error checked and converted from string

            double cleanNumber = 0;
            if (!double.TryParse(number, out cleanNumber))                     //Try parse converts string to a double and saves under clean new name
            {                                                                  //If a unvalid character will trigger warning
                secondTextBox.Clear();
                secondTextBox.Text = "Invalid Character: Try again";
            }
            while (cleanNumber == 0)                                         //Check if we are trying to divide by zero
            {                                                           //Returns an error if trying to divide by zero
                secondTextBox.Clear();
                secondTextBox.Text = "Cannot Divide by 0: Try again";
            }
            return cleanNumber;
        }
    }
}
