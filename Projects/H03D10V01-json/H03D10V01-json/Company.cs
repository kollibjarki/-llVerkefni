using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D10V01_json
{
    class Company
    {

        
            public string name { get; set; }
            public string sn { get; set; }
            public int active { get; set; }
            public string address { get; set; }

        public override string ToString()
        {
            string comp = string.Format("\nName\t: {0}", name);
                   comp += string.Format("\nSocialSecurityNumber\t: {0}", sn);
                   comp += string.Format("\nActive:\t {0}", active);
                   comp += string.Format("\nAddress:\t {0}", address);

            byte[] hja = Encoding.Default.GetBytes(comp);
            comp = Encoding.UTF8.GetString(hja);
            return comp;

        }


    }
}
