using System;
using System.Collections.Generic;
using System.Text;

namespace PeeMath
{
    public class Currencies
    {
        double usdValue;
        double euroValue;

        public double FromDaysToHours(double a)
        {
            return a * 24;
        }

        public double FromHoursToDays(double a)
        {
            return a / 24;
        }

        public double FromDaysToMinutes(double a)
        {
            return a * 24 * 60;
        }
        
        public double FromMinutesToDays(double a)
        {
            return a / (24 * 60);
        }

        public double FromDaysToSeconds(double a)
        {
            return a * 24 * 60 * 60;
        }

        public double FromSecondsToDays(double a)
        {
            return a / (24 * 60 * 60);
        }

        public double FromHoursToMinutes(double a)
        {
            return a * 60;
        }

        public double FromMinutesToHours(double a)
        {
            return a / 60;
        }

        public double FromHoursToSeconds(double a)
        {
            return a * 60 * 60;
        }

        public double FromSecondsToHours(double a)
        {
            return a / (60 * 60);
        }

        public double FromMinutesToSeconds(double a)
        {
            return a * 60;
        }

        public double FromSecondsToMinutes(double a)
        {
            return a / 60;
        }


        public double FromDegreeToRadians(double a)
        {
            return a * Math.PI / 180;
        }

        public double FromRadiansToDegree(double a)
        {
            return a * 180 / Math.PI;
        }

        public string From10toChosen(int a, int b)
        {
            string result = "";
            int temp = 0;

            if (a > 0)
                while (a >= (b - 1))
                {
                    temp = a % b;
                    a = (a - temp) / b;
                    result = Convert.ToString(temp) + result;
                }

            result = Convert.ToString(a) + result;
            return result;
        }


        public double FromRubToDol(double a)
        {
            return a / usdValue;
        }

        public double FromRubToEuro(double a)
        {
            return a / euroValue;
        }

        public double FromEuroToRub(double a)
        {
            return a * euroValue;
        }

        public double FromDolToRub(double a)
        {
            return a * usdValue;
        }
    }
}
