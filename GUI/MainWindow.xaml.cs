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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainCalc CalcWind = new MainCalc();
        FAQWindow FAQWind = new FAQWindow();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void EnterAppClick(object sender, RoutedEventArgs e)
        {
            CalcWind.Show();
            this.Close();
        }

        private void FAQButtonClick(object sender, RoutedEventArgs e)
        {
            FAQWind.Show();
            this.Close();
        }
    }
}
