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
            EnterField.Text += "\u221A";
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
            double rubbles;
            double dollars;
            if (((Double.TryParse(Rub_Dol, out rubbles))))
            {
                double cur_dollars = currs.FromRubToDol(double.Parse(Rub_Dol, styles, cur_culture));
                DolToRub.Text = cur_dollars.ToString("F6");

            }
            else if (!(Double.TryParse(Rub_Dol, out rubbles)) && (Double.TryParse(Dol_Rub, out dollars)))
            {
                double cur_rubbles = currs.FromDolToRub(double.Parse(Dol_Rub, styles, cur_culture));
                RubToDol.Text = cur_rubbles.ToString("F6");

            }
            else
            {
                RubToDol.Clear();
                RubToDol.Text = formatError;
                DolToRub.Clear();
                DolToRub.Text = formatError;
            }
        }

        public void RubEurClick(object sender, RoutedEventArgs e)
        {
            string Rub_Eur = RubToEuro.Text;
            string Eur_Rub = EurToRub.Text;
            double rubbles;
            double euros;
            
            if (Double.TryParse(Rub_Eur, out rubbles))
            {
                double cur_euros = currs.FromRubToEuro(double.Parse(Rub_Eur, styles, cur_culture));
                EurToRub.Text = cur_euros.ToString("F6");
            }
            else if (!(Double.TryParse(Rub_Eur, out rubbles)) && (Double.TryParse(Eur_Rub, out euros)))
            {
                double cur_rubbles = currs.FromEuroToRub(double.Parse(Eur_Rub, styles, cur_culture));
                RubToEuro.Text = cur_rubbles.ToString("F6");
            }
            else
            {
                RubToEuro.Clear();
                RubToEuro.Text = formatError;
            }
        }

        public void DolEurClick(object sender, RoutedEventArgs e)
        {
            string Dol_Eur = DolToEur.Text;
            string Eur_Dol = EurToDol.Text;
            double dollars;
            double euros;
            if (Double.TryParse(Dol_Eur, out euros))
            {
                double cur_euros = currs.FromDolToEur(double.Parse(Dol_Eur, styles, cur_culture));
                EurToRub.Text = cur_euros.ToString("F6");
            }
            else if (!(Double.TryParse(Dol_Eur, out euros)) && (Double.TryParse(Eur_Dol, out dollars)))
            {
                double cur_rubbles = currs.FromEuroToDol(double.Parse(Eur_Dol, styles, cur_culture));
                RubToEuro.Text = cur_rubbles.ToString("F6");
            }
            else
            {
                DolToEur.Clear();
                DolToEur.Text = formatError;
            }

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
