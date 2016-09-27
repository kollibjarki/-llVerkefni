using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D05V06_ListOfPeople

{
    class Person
    {
        public string Kt { get; set; }
        public string Nafn { get; set; }
        public string Simi { get; set; }

        public virtual void BirtaUpplysingar()
        {
            Console.WriteLine("nafn: {0}", Nafn);
            Console.WriteLine("Kennitala: {0}", Kt);
            Console.WriteLine("Sími: {0}", Simi);

        }


    }
}
