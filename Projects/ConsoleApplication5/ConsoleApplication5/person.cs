using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class person
    {
        public string kt { get; set; }
        public string nafn { get; set; }
        public string simi { get; set; }

        public virtual void BirtaUpplysingar()
        {
            Console.WriteLine("nafn: {0}", nafn);
            Console.WriteLine("Kennitala: {0}", kt);
            Console.WriteLine("Sími: {0}", simi);

        }


    }
}
