/* calculatorGUI project
 * 
 * Tony Biccum
 * ECET 230
 * Camosun College
 * Sepember 24th, 2021
 * 
 * This project uses a WPF format to create a calculator similar to windows calculator.
 * We utalize event driven programming to program buttons and text boxes.
 * The user enters two numbers into the text boxes and chooses an operator from the buttons.
 * The program will debug the users input for invalid character and divide by 0.
 * If an error is present no answer will be displayed. 
 * Secret easter egg in code too. 
 */

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

            //BEGIN DEBUG SECTION
            double cleanNum1 = 0;                                 //Initialize first variable for the clean number that is produced from tryparse
            if (!double.TryParse(num1, out cleanNum1))            //Try parse converts string to a double and saves under clean new name
            {                                                     //If a unvalid character will trigger an error 
                firstTextBox.Clear();                             //Clear the first text box and answer box
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";        //Print error message
                errorFlag = true;                                 //Set the error flag to true
            }

            double cleanNum2 = 0;                                 //Initialize second variable for the clean number that is produced from tryparse
            if (!double.TryParse(num2, out cleanNum2))            //Try parse converts string to a double and saves under clean new name
            {                                                     //If a unvalid character will trigger an error
                secondTextBox.Clear();                            //Clear the first text box and answer box
                textAnswer.Clear(); 
                secondTextBox.Text = "Error: Invalid Char";       //Print error message
                errorFlag = true;                                 //Set the error flag to true
            }

            if (cleanNum2 == 0)                                   //Check if we are trying to divide by zero
            {                                                     //Returns an error if trying to divide by zero
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Div by 0";           //Print error message
                errorFlag = true;                                 //Set the error flag to true
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = cleanNum1 / cleanNum2;              //Performs division on two double values 
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }

        private void buttMultiplication_Click(object sender, RoutedEventArgs e)
        {
            //Mupliplication
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //BEGIN DEBUG SECTION - See "buttDivide_Click" method for code explanation
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            
            {                                                           
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))        
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = cleanNum1 * cleanNum2;              //Performs multiplication on two double values
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }

        private void buttSubtraction_Click(object sender, RoutedEventArgs e)
        {
            //Subtraction
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //BEGIN DEBUG SECTION - See "buttDivide_Click" method for code explanation
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            
            {                                                          
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = cleanNum1 - cleanNum2;              //Performs subtraction on two double values
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }

        private void buttAddition_Click(object sender, RoutedEventArgs e)
        {
            //Addition
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;


            //BEGIN DEBUG SECTION - See "buttDivide_Click" method for code explanation
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))           
            {                                                           
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))           
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = cleanNum1 + cleanNum2;              //Performs addition on two double values
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }
        private void buttPower_Click(object sender, RoutedEventArgs e)
        {
            //Power
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //BEGIN DEBUG SECTION - See "buttDivide_Click" method for code explanation
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            
            {                                                          
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }

            double cleanNum2 = 0;
            if (!double.TryParse(num2, out cleanNum2))          
            {
                secondTextBox.Clear();
                textAnswer.Clear();
                secondTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = Math.Pow(cleanNum1, cleanNum2);     //cleanNum2 to the power of cleanNum1
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }        
        private void buttSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            //Square Root
            string num1 = firstTextBox.Text;
            string num2 = secondTextBox.Text;
            bool errorFlag = false;

            //BEGIN DEBUG SECTION - See "buttDivide_Click" method for code explanation
            double cleanNum1 = 0;
            if (!double.TryParse(num1, out cleanNum1))            
            {                                                           
                firstTextBox.Clear();
                textAnswer.Clear();
                firstTextBox.Text = "Error: Invalid Char";
                errorFlag = true;
            }
            //END DEBUG SECTION

            if (!errorFlag)                                       //If errorflag was NOT triggered in debug section perform math
            {
                double temp = Math.Sqrt(cleanNum1);               //Square root of cleanNum1
                textAnswer.Text = Convert.ToString(temp);         //Print the answer in answer text box
            }
        }        
        private void buttClear_Click(object sender, RoutedEventArgs e)
        {
            //Clears all text boxes when clear button is pushed
            firstTextBox.Clear();   
            secondTextBox.Clear();
            textAnswer.Clear();
        }
        private void firstTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Clears first text box when first text box is double clicked
            firstTextBox.Clear();
            textAnswer.Clear();
        }

        private void secondTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Clears second text box when second text box is double clicked
            secondTextBox.Clear();
            textAnswer.Clear();
        }


    }
}
