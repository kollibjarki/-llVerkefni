using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4laun3
{
    class Program
    {
        static void Main(string[] args)
        {




            double fyrirskatt, utborgad,eftirskatt;

         
            Console.Write("launin þin: ");
            double laun = Convert.ToDouble(Console.ReadLine());
            Console.Write("lífeyrisjóður: ");
            double líf = 0.01 * Convert.ToDouble(Console.ReadLine());
            Console.Write("stéttarfelag: ");
            double stett = 0.01 * Convert.ToDouble(Console.ReadLine());
            Console.Write("skattur: ");
            double skatt = 0.01 * Convert.ToDouble(Console.ReadLine());
            Console.Write("personuafsláttur: ");
            double personu =Convert.ToDouble(Console.ReadLine());

            fyrirskatt = laun - (laun * líf) - (laun * stett);
            utborgad = fyrirskatt -(fyrirskatt * skatt) + personu;
            eftirskatt = skatt*fyrirskatt;

            Console.WriteLine("laun fyrir skatt {0}", fyrirskatt);
            Console.WriteLine("skattur af launum {0}", laun - eftirskatt);
            Console.WriteLine("útborguð laun fyrir kallinn {0}", utborgad);


            Console.ReadKey();

        }
    }
}
