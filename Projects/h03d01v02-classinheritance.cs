using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.kt = "0709926549";
            p1.nafn = "gunnar á hlíðarenda";
            p1.simi = "5551234";

            employee e1 = new employee();
            e1.kt = "1612932889";
            e1.nafn = "kolbeinn bjarki";
            e1.simi = "6595920";
            e1.employeeNumber = "stg534ff";


            //Console.WriteLine("persónan heitir {0}", p1.nafn);
            //Console.WriteLine("starfsmaðurinn heitir {0}", e1.nafn);
            p1.BirtaUpplysingar();
            e1.BirtaUpplysingar();

            Console.ReadKey();

        }
    }
}
