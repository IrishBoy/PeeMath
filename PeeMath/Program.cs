using System;
using System.Xml;

namespace PeeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string USDXml = "";
            string EuroXML = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Valute")
                        {
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ID")
                                    {
                                        if (reader.Value == "R01235")
                                        {
                                            reader.MoveToElement();
                                            USDXml = reader.ReadOuterXml();
                                        }
                                    }

                                    if (reader.Name == "ID")
                                    {
                                        if (reader.Value == "R01239")
                                        {
                                            reader.MoveToElement();
                                            EuroXML = reader.ReadOuterXml();
                                        }
                                    }
                                }
                            }
                        }

                        break;
                }
            }

            XmlDocument usdXmlDocument = new XmlDocument();
            usdXmlDocument.LoadXml(USDXml);
            XmlDocument euroXmlDocument = new XmlDocument();
            euroXmlDocument.LoadXml(EuroXML);
            XmlNode xmlNode = usdXmlDocument.SelectSingleNode("Valute/Value");

            double usdValue = Convert.ToDouble(xmlNode.InnerText);
            xmlNode = euroXmlDocument.SelectSingleNode("Valute/Value");
            double euroValue = Convert.ToDouble(xmlNode.InnerText);

            Currencies currentCur = new Currencies(usdValue, euroValue);
            Calculations calc = new Calculations();
        }
    }
}
