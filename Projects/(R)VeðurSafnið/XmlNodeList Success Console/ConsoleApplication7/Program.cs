using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {



            string filePath = "http://xmlweather.vedur.is/?op_w=xml&type=obs&lang=is&view=xml&ids=422";
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(filePath);
            string xmlString = (myXmlDocument.OuterXml);

            //Console.WriteLine(xmlString);


            XmlNodeList stadur = myXmlDocument.GetElementsByTagName("name"),
                        timi = myXmlDocument.GetElementsByTagName("time"),
                        hiti = myXmlDocument.GetElementsByTagName("T"),
                        vindstefna = myXmlDocument.GetElementsByTagName("D"),
                        vindhradi = myXmlDocument.GetElementsByTagName("F"),
                        vedurLysing = myXmlDocument.GetElementsByTagName("W");







            Console.WriteLine(stadur[0].InnerXml);
            Console.WriteLine(timi[0].InnerXml);
            Console.WriteLine(hiti[0].InnerXml);
            Console.WriteLine(vindhradi[0].InnerXml);
            Console.WriteLine(vindstefna[0].InnerXml);
            Console.WriteLine(vedurLysing[0].InnerXml);


            Console.ReadKey();
            




        }
    }
}
