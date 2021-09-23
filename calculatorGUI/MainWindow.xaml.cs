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
            double num1 = Convert.ToDouble(firstTextBox.Text);
            double num2 = Convert.ToDouble(secondTextBox.Text);
            double temp = num1 + num2;
            textAnswer.Text = Convert.ToString(temp);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Equals

        }

        private void operation1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Operation 1 Input

        }

        private void operation2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Operation 2 Input 

        }
        private void answer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Answer Output

        }
    }
}
