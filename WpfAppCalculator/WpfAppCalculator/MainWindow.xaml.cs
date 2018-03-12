using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfAppCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number = null;
        string operation = null;
        public MainWindow()
        {
            InitializeComponent();
            new PresenterCalculator(this);
        }
                
        public event EventHandler sqrt = null;
        public event EventHandler pow = null;
        public event EventHandler equal = null;


        private void Number_Click(object sender, RoutedEventArgs e)
        {
            ///TODO number 0-9 for one Number_Click
            number = ((Button)sender).Name;
            if(number == "Coma" && Field.Text=="")
            {
                Field.Text = "0";
            }
            switch (number)
            {
                case "Zero":
                    Field.Text = Field.Text + 0;
                    break;
                case "One":
                    Field.Text = Field.Text + 1;
                    break;
                case "Two":
                    Field.Text = Field.Text + 2;
                    break;
                case "Three":
                    Field.Text = Field.Text + 3;
                    break;
                case "Four":
                    Field.Text = Field.Text + 4;
                    break;
                case "Five":
                    Field.Text = Field.Text + 5;
                    break;
                case "Six":
                    Field.Text = Field.Text + 6;
                    break;
                case "Seven":
                    Field.Text = Field.Text + 7;
                    break;
                case "Eight":
                    Field.Text = Field.Text + 8;
                    break;
                case "Nine":
                    Field.Text = Field.Text + 9;
                    break;
                case "Coma":
                    Field.Text = Field.Text + ",";
                    break;
                default:
                    break;
            }
        }
        
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            operation = ((Button)sender).Name;
            
            switch (operation)
            {
                case "Add":
                    Field.Text = Field.Text + " + ";                        
                    break;
                case "Sub":
                    Field.Text = Field.Text + " - ";
                    break;
                case "Mult":
                    Field.Text = Field.Text + " * ";
                    break;
                case "Div":
                    Field.Text = Field.Text + " / ";
                    break;
                default:
                    break;
            }
        }
        
        private void SQRT_Click(object sender, RoutedEventArgs e)
        {
            sqrt.Invoke(sender, e);
        }

        private void Pow_Click(object sender, RoutedEventArgs e)
        {
            pow.Invoke(sender, e);
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {            
            equal.Invoke(sender, e);
        }
        // delete text int textbox
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if(Field.Text.Length != 0)
            Field.Text = Field.Text.Substring(0, Field.Text.Length - 1);
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "";
        }
    }
}
