using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace H03D05V01_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("Saltkjöt");
            list.Add("baunir");

            list.Add(2);
            list.Add("krónur");

            list.Remove("krónur");
            list.Insert(2, "evrur");





            foreach (Object l in list)
            {
                Console.WriteLine("{0}",l.ToString());

            }



            Console.ReadKey();

        }
    }
}
