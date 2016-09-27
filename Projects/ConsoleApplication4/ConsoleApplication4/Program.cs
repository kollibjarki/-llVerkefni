using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    struct coordinate
    {
        public double x, y;

        public double distance(coordinate c)
        {
            return 0;

        }
    }

    struct spil
    {
        public tegund tegund;
        public byte gildi;
    }
    
    enum tegund { Hjarta, spadi, tigull, lauf};



    class Program
    {
        static void Main(string[] args)
        {
            coordinate hnit; ;
            hnit.x = 10.0;
            hnit.y = 11;


            Console.WriteLine(" hnit x er{0} ", hnit.x);
            Console.WriteLine(" hnit y er{0} ", hnit.y);
            coordinate hnit2;
            hnit2.x = 4;
            hnit2.y = 4;

            Console.WriteLine(hnit2.distance(hnit));


            spil spil;
            spil.tegund = tegund.lauf;
            spil.gildi = 4;
            if (spil.tegund == tegund.Hjarta)
            {
                Console.WriteLine("Þú ert með hjarta");
            }

            Console.ReadKey();
        }
    }
}
