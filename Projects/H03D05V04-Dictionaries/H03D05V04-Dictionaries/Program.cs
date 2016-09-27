using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H03D05V04_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList radad = new SortedList();

            radad.Add(2, "baunir");
            radad.Add(1, "saltkjöt");
            radad.Add(4, "krónur");
            radad.Add(3, 2);

            foreach(DictionaryEntry þráinn in radad)
            {
                Console.WriteLine(þráinn.Value);
            }


            Console.ReadKey();

        }
    }
}
