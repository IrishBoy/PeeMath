using System;
using System.Globalization;
using System.Windows;
using PeeMath;

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

        private NumberStyles styles = NumberStyles.Currency |
                    NumberStyles.Number|NumberStyles.AllowThousands |
                    NumberStyles.AllowTrailingSign | NumberStyles.AllowCurrencySymbol;

        private CultureInfo cur_culture = CultureInfo.CreateSpecificCulture("fr-FR");

        private string formatError = "Wrong format";

        Currencies currs = new Currencies();

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
            EnterField.Text += "\u221A" + "()";
        }

        public void DegreeClick(object sender, RoutedEventArgs e)
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




        public void RubDolClick(object sender, RoutedEventArgs e)
        {
            string Rub_Dol = RubToDol.Text;
            string Dol_Rub = DolToRub.Text;
            decimal rubbles;
            decimal dollars;
            if (((Decimal.TryParse(Rub_Dol, styles, cur_culture, out rubbles)) && Decimal.TryParse(Dol_Rub, styles, cur_culture, out dollars)) ||
                    ((Decimal.TryParse(Rub_Dol, styles, cur_culture, out rubbles)) && !(Decimal.TryParse(Dol_Rub, styles, cur_culture, out dollars))))
            {
                DolToRub.Text = FromRubToDol(Decimal.Parse(Rub_Dol));

            }
            else if (!(Decimal.TryParse(Rub_Dol, styles, cur_culture, out rubbles)) && (Decimal.TryParse(Dol_Rub, styles, cur_culture, out dollars)))
            {
                //RubToDol.Text = Func(Decimal.Parse(Dol_Rub));

            }
            else
            {
                RubToDol.Clear();
                RubToDol.Text = formatError;
            }
        }

        public void RubEurClick(object sender, RoutedEventArgs e)
        {
            string Rub_Dol = RubToDol.Text;
            decimal number;
            if (!Decimal.TryParse(Rub_Dol, styles, cur_culture, out number))
            {

            }
            else
            {
                RubToDol.Clear();
                RubToDol.Text = formatError;
            }
        }

        public void DolEurClick(object sender, RoutedEventArgs e)
        {

        }



        public void SecMinClick(object sender, RoutedEventArgs e)
        {

        }
        public void SecHoursClick(object sender, RoutedEventArgs e)
        {

        }

        public void SecDaysClick(object sender, RoutedEventArgs e)
        {

        }

        public void MinHoursClick(object sender, RoutedEventArgs e)
        {

        }

        public void MinDaysClick(object sender, RoutedEventArgs e)
        {

        }

        public void HoursDaysClick(object sender, RoutedEventArgs e)
        {

        }

        private void OtherMeasClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
