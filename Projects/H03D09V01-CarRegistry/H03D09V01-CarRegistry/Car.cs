using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D09V01_CarRegistry
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

        public override string ToString()
        {
            string retStr = string.Format("Type: {0}", type);
                   retStr += string.Format("\nSubType: {0}", subType);
                   retStr += string.Format("\nColor: {0}", color);
                   retStr += string.Format("\nRegistry Number: {0}", registryNumber);
            byte[] hja = Encoding.Default.GetBytes(retStr);
            retStr = Encoding.UTF8.GetString(hja);
            
            return retStr;
        }
    }
}
