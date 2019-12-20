using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PeeMath
{
    public class Parser
    {
        public bool TryParse(string str)
        {
            try
            {
                Parsing(str);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public double Parsing(string str)
        {
            string[] func = {"sin", "cos", "ctg", "tg", "arcsin", "arccos", "arcctg", "arctg", "\u221A", "ln", "log" };
            for (int i = 0; i < func.Length; i++)
            {
                Match matchFunc = Regex.Match(str, string.Format(@"{0}\(({1})\)", func[i], @"[1234567890\.\+\-\*\/^%]*"));
                if (matchFunc.Groups.Count > 1)
                {
                    string middle = matchFunc.Groups[0].Value.Substring(1 + func[i].Length, matchFunc.Groups[0].Value.Trim().Length - 2 - func[i].Length);
                    string left = str.Substring(0, matchFunc.Index);
                    string right = str.Substring(matchFunc.Index + matchFunc.Length);

                    switch (i)
                    {
                        case 0:
                            return Parsing(left + Calculations.Sin(Convert.ToDouble(middle)) + right);

                        case 1:
                            return Parsing(left + Calculations.Cos(Convert.ToDouble(middle)) + right);

                        case 2:
                            return Parsing(left + Calculations.Tg(Convert.ToDouble(middle)) + right);

                        case 3:
                            return Parsing(left + Calculations.Ctg(Convert.ToDouble(middle)) + right);

                        case 4:
                            return Parsing(left + Calculations.Arcsin(Convert.ToDouble(middle)) + right);

                        case 5:
                            return Parsing(left + Calculations.Arccos(Convert.ToDouble(middle)) + right);

                        case 6:
                            return Parsing(left + Calculations.Arctg(Convert.ToDouble(middle)) + right);

                        case 7:
                            return Parsing(left + Calculations.Arcctg(Convert.ToDouble(middle)) + right);

                        case 8:
                            return Parsing(left + Calculations.SquareRoot(Convert.ToDouble(middle)) + right);

                        case 9:
                            return Parsing(left + Calculations.Ln(Convert.ToDouble(middle)) + right);

                        case 10:
                            string[] numbers = middle.Split(",");
                            return Parsing(left + Calculations.Log(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));

                    }
                }
            }

            // Парсинг скобок
            Match matchBrackets = Regex.Match(str, string.Format(@"\(({0})\)", @"[1234567890\.\+\-\*\/^%]*"));
            if (matchBrackets.Groups.Count > 1)
            {
                string middle = matchBrackets.Groups[0].Value.Substring(1, matchBrackets.Groups[0].Value.Trim().Length - 2);
                string left = str.Substring(0, matchBrackets.Index);
                string right = str.Substring(matchBrackets.Index + matchBrackets.Length);
                return Parsing(left + Parsing(middle) + right);
            }

            // Парсинг действий
            Match matchMulOp = Regex.Match(str, string.Format(@"({0})\s?({1})\s?({0})\s?", @"[-]?\d+\.?\d*", @"[\*\/^%]"));
            Match matchAddOp = Regex.Match(str, string.Format(@"({0})\s?({1})\s?({2})\s?", @"[-]?\d+\.?\d*", @"[\+\-]", @"[-]?\d+\.?\d*"));
            var match = (matchMulOp.Groups.Count > 1) ? matchMulOp : (matchAddOp.Groups.Count > 1) ? matchAddOp : null;
            if (match != null)
            {
                string left = str.Substring(0, match.Index);
                string right = str.Substring(match.Index + match.Length);
                string val = ParseAct(match).ToString(CultureInfo.CreateSpecificCulture("fr-FR"));
                return Parsing(string.Format("{0}{1}{2}", left, val, right));
            }

            // Парсинг числа
            try
            {
                return double.Parse(str, CultureInfo.CreateSpecificCulture("fr-FR"));
            }
            catch (FormatException)
            {
                throw new FormatException(string.Format("Wrong format '{0}'", str));
            }
        }


        private double ParseAct(Match match)
        {
            double a = double.Parse(match.Groups[1].Value, CultureInfo.CreateSpecificCulture("fr-FR"));
            double b = double.Parse(match.Groups[3].Value, CultureInfo.CreateSpecificCulture("fr-FR"));

            switch (match.Groups[2].Value)
            {
                case "+":
                    return Calculations.Summary(a, b);

                case "-":
                    return Calculations.Subtraction(a, b);

                case "*":
                    return Calculations.Multiplication(a, b);

                case "/":
                    return Calculations.Division(a, b);

                case "^":
                    return Calculations.Exponentiation(a, b);

                case "%":
                    return a % b;

                default:
                    throw new FormatException(string.Format("Wrong format '{0}'", match.Value));
            }
        }
    }
}
