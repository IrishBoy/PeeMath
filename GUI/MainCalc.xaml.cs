using System;
using System.Globalization;
using System.Windows;
using PeeMath;

namespace WelcomeScreen
{
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
        Parser parse = new Parser();

        public void PlusClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "+");
        }

        public void MinusClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "-");
        }

        public void MultiplyClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "*");
        }

        public void DivideClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "/");
        }

        public void LNClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "ln()");            
        }

        public void LogClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "log(base, number)");
        }

        public void SquareClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "^(2)");
        }

        public void PowerClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "^(y)");

        }
        public void SinClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "sin(x)");
        }

        public void CosClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "cos(x)");
        }

        public void TgClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "tg(x)");
        }

        public void CtgClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "ctg(x)");
        }

        public void FactorialClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "(x)!");            
        }

        public void PercentClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "%");
        }

        public void PeeClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "\u03C0");
        }


        public void SquareRootClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "\u221A");
        }
        
        public void DegreeClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "(x)\u00B0");
        }

        public void RadianClick(object sender, RoutedEventArgs e)
        {
            EnterField.Text = EnterField.Text.Insert(EnterField.CaretIndex, "rad(x)");
        }
        public void EqualClick(object sender, RoutedEventArgs e)
        {
            double answer = parse.Parsing(Convert.ToString(EnterField.Text));
            EnterField.Clear();
            int cur_int = (int)answer;
            if(cur_int == answer)
            {
                EnterField.Text = answer.ToString();
            }
            else
            {
                EnterField.Text = answer.ToString("F6");
            }
            
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
                int cur_int = (int)cur_dollars;
                if(cur_int == cur_dollars)
                {
                    DolToRub.Text = cur_dollars.ToString();
                }
                else
                {
                    DolToRub.Text = cur_dollars.ToString("F6");
                }
                

            }
            else if (!(Double.TryParse(Rub_Dol, out rubbles)) && (Double.TryParse(Dol_Rub, out dollars)))
            {
                double cur_rubbles = currs.FromDolToRub(double.Parse(Dol_Rub, styles, cur_culture));
                int cur_int = (int)cur_rubbles;
                if(cur_int == cur_rubbles)
                {
                    RubToDol.Text = cur_rubbles.ToString();
                }
                else
                {
                    RubToDol.Text = cur_rubbles.ToString("F6");
                }
                

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
                int cur_int = (int)cur_euros;
                if(cur_int == cur_euros)
                {
                    EurToRub.Text = cur_euros.ToString();
                }
                else
                {
                    EurToRub.Text = cur_euros.ToString("F6");
                }
                
            }
            else if (!(Double.TryParse(Rub_Eur, out rubbles)) && (Double.TryParse(Eur_Rub, out euros)))
            {
                double cur_rubbles = currs.FromEuroToRub(double.Parse(Eur_Rub, styles, cur_culture));
                int cur_int = (int)cur_rubbles;
                if(cur_int == cur_rubbles)
                {
                    RubToEuro.Text = cur_rubbles.ToString();
                }
                else
                {
                    RubToEuro.Text = cur_rubbles.ToString("F6");
                }
                
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
                double cur_euros = currs.FromDolToEuro(double.Parse(Dol_Eur, styles, cur_culture));
                int cur_int = (int)cur_euros;
                if(cur_int == cur_euros)
                {
                    EurToRub.Text = cur_euros.ToString();
                }
                else
                {
                    EurToRub.Text = cur_euros.ToString("F6");
                }
                
            }
            else if (!(Double.TryParse(Dol_Eur, out euros)) && (Double.TryParse(Eur_Dol, out dollars)))
            {
                double cur_rubbles = currs.FromEuroToDol(double.Parse(Eur_Dol, styles, cur_culture));
                int cur_int = (int)cur_rubbles;
                if(cur_int == cur_rubbles)
                {
                    RubToEuro.Text = cur_rubbles.ToString();
                }
                else
                {
                    RubToEuro.Text = cur_rubbles.ToString("F6");
                }
                

            }
            else
            {
                DolToEur.Clear();
                DolToEur.Text = formatError;
            }

        }



        public void SecMinClick(object sender, RoutedEventArgs e)
        {
            string Sec_Min = SecToMin.Text;
            string Min_Sec = MinToSec.Text;
            double secs;
            double mins;
            if (Double.TryParse(Sec_Min, out mins))
            {
                double cur_mins = currs.FromSecondsToMinutes(double.Parse(Sec_Min, styles, cur_culture));
                int cur_int = (int)cur_mins;
                if(cur_mins == cur_int)
                {
                    MinToSec.Text = cur_mins.ToString();
                }
                else
                {
                    MinToSec.Text = cur_mins.ToString("F6");
                }
                
            }
            else if (!(Double.TryParse(Sec_Min, out mins)) && (Double.TryParse(Min_Sec, out secs)))
            {
                double cur_secs = currs.FromMinutesToSeconds(double.Parse(Min_Sec, styles, cur_culture));
                int cur_int = (int)cur_secs;
                if (cur_secs == cur_int)
                {
                    SecToMin.Text = cur_secs.ToString();
                }
                else
                {
                    SecToMin.Text = cur_secs.ToString("F6");
                }
            }
            else
            {
                SecToMin.Clear();
                SecToMin.Text = formatError;
            }
        }
        public void SecHoursClick(object sender, RoutedEventArgs e)
        {
            string Sec_Hour = SecToHours.Text;
            string Hour_Sec = HoursToSec.Text;
            double secs;
            double hours;
            if (Double.TryParse(Sec_Hour, out hours))
            {
                double cur_hours = currs.FromSecondsToHours(double.Parse(Sec_Hour, styles, cur_culture));
                int cur_int = (int)cur_hours;
                if (cur_hours == cur_int)
                {
                    HoursToSec.Text = cur_hours.ToString();
                }
                else
                {
                    HoursToSec.Text = cur_hours.ToString("F6");
                }
            }
            else if (!(Double.TryParse(Sec_Hour, out hours)) && (Double.TryParse(Hour_Sec, out secs)))
            {
                double cur_secs = currs.FromHoursToSeconds(double.Parse(Hour_Sec, styles, cur_culture));
                int cur_int = (int)cur_secs;
                if (cur_secs == cur_int)
                {
                    SecToHours.Text = cur_int.ToString();
                }
                else
                {
                    SecToHours.Text = cur_secs.ToString("F6");
                }
            }
            else
            {
                SecToHours.Clear();
                SecToHours.Text = formatError;
            }
        }

        public void SecDaysClick(object sender, RoutedEventArgs e)
        {
            string Sec_Day = SecToDays.Text;
            string Day_Sec = DaysToSec.Text;
            double secs;
            double days;
            if (Double.TryParse(Sec_Day, out days))
            {
                double cur_days = currs.FromSecondsToDays(double.Parse(Sec_Day, styles, cur_culture));
                int cur_int = (int)cur_days;
                if (cur_days == cur_int)
                {
                    DaysToSec.Text = cur_int.ToString();
                }
                else
                {
                    DaysToSec.Text = cur_days.ToString("F6");
                }
            }
            else if (!(Double.TryParse(Sec_Day, out days)) && (Double.TryParse(Day_Sec, out secs)))
            {
                double cur_secs = currs.FromDaysToSeconds(double.Parse(Day_Sec, styles, cur_culture));
                int cur_int = (int)cur_secs;
                if (cur_secs == cur_int)
                {
                    SecToDays.Text = cur_int.ToString();
                }
                else
                {
                    SecToDays.Text = cur_secs.ToString("F6");
                }
            }
            else
            {
                SecToDays.Clear();
                SecToDays.Text = formatError;
            }
        }

        public void MinHoursClick(object sender, RoutedEventArgs e)
        {
            string Min_Hour = MinToHours.Text;
            string Hour_Min = HoursToMin.Text;
            double mins;
            double hours;
            if (Double.TryParse(Min_Hour, out hours))
            {
                double cur_hours = currs.FromMinutesToHours(double.Parse(Min_Hour, styles, cur_culture));
                int cur_int = (int)cur_hours;
                if (cur_hours == cur_int)
                {
                    HoursToMin.Text = cur_int.ToString();
                }
                else
                {
                    HoursToMin.Text = cur_hours.ToString("F6");
                }

            }
            else if (!(Double.TryParse(Min_Hour, out hours)) && (Double.TryParse(Hour_Min, out mins)))
            {
                double cur_mins = currs.FromHoursToMinutes(double.Parse(Hour_Min, styles, cur_culture));
                int cur_int = (int)cur_mins;
                if (cur_mins == cur_int)
                {
                    MinToHours.Text = cur_int.ToString();
                }
                else
                {
                    MinToHours.Text = cur_mins.ToString("F6");
                }
                
            }
            else
            {
                MinToHours.Clear();
                MinToHours.Text = formatError;
            }
        }

        public void MinDaysClick(object sender, RoutedEventArgs e)
        {
            string Min_Day = MinToDays.Text;
            string Day_Min = DaysToMin.Text;
            double mins;
            double days;
            if (Double.TryParse(Min_Day, out days))
            {
                double cur_days = currs.FromMinutesToDays(double.Parse(Min_Day, styles, cur_culture));
                int cur_int = (int)cur_days;
                if (cur_days == cur_int)
                {
                    DaysToMin.Text = cur_int.ToString();
                }
                else
                {
                    DaysToMin.Text = cur_days.ToString("F6");
                }
            }
            else if (!(Double.TryParse(Min_Day, out days)) && (Double.TryParse(Day_Min, out mins)))
            {
                double cur_mins = currs.FromDaysToMinutes(double.Parse(Day_Min, styles, cur_culture));
                int cur_int = (int)cur_mins;
                if (cur_mins == cur_int)
                {
                    MinToDays.Text = cur_int.ToString();
                }
                else
                {
                    MinToDays.Text = cur_mins.ToString("F6");
                }
            }
            else
            {
                DaysToMin.Clear();
                DaysToMin.Text = formatError;
            }
        }

        public void HoursDaysClick(object sender, RoutedEventArgs e)
        {
            string Hour_Day = HoursToDays.Text;
            string Day_Hour = DaysToHours.Text;
            double hours;
            double days;
            if (Double.TryParse(Hour_Day, out days))
            {
                double cur_days = currs.FromHoursToDays(double.Parse(Hour_Day, styles, cur_culture));
                int cur_int = (int)cur_days;
                if (cur_days == cur_int)
                {
                    DaysToHours.Text = cur_int.ToString();
                }
                else
                {
                    DaysToHours.Text = cur_days.ToString("F6");
                }
            }
            else if (!(Double.TryParse(Hour_Day, out days)) && (Double.TryParse(Day_Hour, out hours)))
            {
                double cur_hours = currs.FromDaysToHours(double.Parse(Day_Hour, styles, cur_culture));
                int cur_int = (int)cur_hours;
                if (cur_hours == cur_int)
                {
                    HoursToDays.Text = cur_int.ToString();
                }
                else
                {
                    HoursToDays.Text = cur_hours.ToString("F6");
                }
            }
            else
            {
                DaysToHours.Clear();
                DaysToHours.Text = formatError;
            }
        }

    }
}
