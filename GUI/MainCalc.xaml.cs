using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WelcomeScreen
{
    /// <summary>
    /// Логика взаимодействия для MainCalc.xaml
    /// </summary>
    public partial class MainCalc : Window
    {
        public MainCalc()
        {
            InitializeComponent();
        }

        public void PlusClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "+";
        }

        public void MinusClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "-";
        }

        public void MultiplyClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "*";
        }

        public void DivideClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "/";
        }

        public void LNClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "ln()";
        }

        public void LogClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "log(base, number)";
        }

        public void SquareClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "^(2)";
        }

        public void PowerClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "^(y)";
        }
        public void SinClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "sin(x)";
        }

        public void CosClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "cos(x)";
        }

        public void TgClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "tg(x)";
        }

        public void CtgClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "ctg(x)";
        }

        public void FactorialClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "!";
        }

        public void PercentClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "%";
        }

        public void PeeClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "\u03C0";
        }


        public void SquareRootClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "\u221A";
        }

        public void DegreeClicl(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "\u00B0";
        }

        public void RadianClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text += "(rad)";
        }

        public void EqualClick(object sender, RoutedEventArgs e)
        {
            EnterField.Clear();
        }

    }
}
