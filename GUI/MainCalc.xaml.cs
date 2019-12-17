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

        public void EqualClick(object sender, RoutedEventArgs e)
        {
            EnterField.Clear();
        }
    }
}
