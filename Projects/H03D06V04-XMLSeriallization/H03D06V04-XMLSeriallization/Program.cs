using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace H03D06V04_XMLSeriallization
{
    class Program
    {
        static void Main(string[] args)
        {
            string nafn = "jón sigurðsson";

            FileStream fs = new FileStream(@"C:\Temp\starfsm.xml", FileMode.OpenOrCreate);

            XmlSerializer xs = new XmlSerializer(typeof(string));
            xs.Serialize(fs, nafn);
            fs.Close();





        }
    }
}
