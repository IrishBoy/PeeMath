using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PeeMath
{
    //got class ValuteRate from http://www.cyberforum.ru/windows-forms/thread941874.html and adapted to our cod
    public class ValuteRate
    {
        public class CurrencyRate
        {
            public string CurrencyStringCode;
            public string CurrencyName;
            public double ExchangeRate;
        }

        public class CurrencyRates
        {
            public class ValCurs
            {
                [XmlElementAttribute("Valute")]
                public ValCursValute[] ValuteList;
            }

            public class ValCursValute
            {

                [XmlElementAttribute("CharCode")]
                public string ValuteStringCode;

                [XmlElementAttribute("Name")]
                public string ValuteName;

                [XmlElementAttribute("Value")]
                public string ExchangeRate;
            }

            public static List<CurrencyRate> GetExchangeRates()
            {
                List<CurrencyRate> result = new List<CurrencyRate>();
                XmlSerializer xs = new XmlSerializer(typeof(ValCurs));
                XmlReader xr = new XmlTextReader(@"http://www.cbr.ru/scripts/XML_daily.asp");
                foreach (ValCursValute valute in ((ValCurs)xs.Deserialize(xr)).ValuteList)
                {
                    result.Add(new CurrencyRate()
                    {
                        CurrencyName = valute.ValuteName,
                        CurrencyStringCode = valute.ValuteStringCode,
                        ExchangeRate = Convert.ToDouble(valute.ExchangeRate)
                    });
                }
                return result;
            }
        }


        public static List<CurrencyRate> tmp = CurrencyRates.GetExchangeRates();
    }
}
