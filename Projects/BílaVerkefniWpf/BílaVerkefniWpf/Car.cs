using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonReader;

namespace BílaVerkefniWpf
{
    class Car
    {

        public string type { get; set; }
        public string subType { get; set; }
        public string color { get; set; }
        public string registryNumber { get; set; }
        public string number { get; set; }
        public string factoryNumber { get; set; }
        public string registeredAt { get; set; }
        public string pollution { get; set; }
        public string weight { get; set; }
        public string status { get; set; }
        public string nextCheck { get; set; }
        public string path = "http://apis.is/car?number=";


        public Car fletta(string bilnr)
        {
            JsonReader<Carlist> car = new JsonWebReader<Carlist>(path + bilnr);
            Carlist carList = car.GetObject();

            return carList.results[0];
        }


        public override string ToString()
        {
            string retStr = string.Format(type);
            retStr += string.Format(subType);
            retStr += string.Format(color);
            retStr += string.Format(registryNumber);
            retStr += string.Format(number);
            retStr += string.Format(factoryNumber);
            retStr += string.Format(registeredAt);
            retStr += string.Format(pollution);
            retStr += string.Format(weight);
            retStr += string.Format(status);
            retStr += string.Format(nextCheck);






            byte[] hja = Encoding.Default.GetBytes(retStr);
            retStr = Encoding.UTF8.GetString(hja);

            return retStr;
        }

        public string convertToUtf8(string ctf8)
        {
            byte[] hja = Encoding.Default.GetBytes(ctf8);
            return Encoding.UTF8.GetString(hja);
        }


    }
}
