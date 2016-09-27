using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D02V02_PHARSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int tala = 4;

            Console.WriteLine("give me a number and i will raise it by 4: ");
            //Console.ReadLine();
            //try
            //{
            //    int tala2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("im geting sick your doing somting wrong to me ");
            //}

            //catch (FormatException )

            //{
            //    Console.WriteLine("your method was not right");
            //}
            //catch(Exception e)
            //{
            //  Console.WriteLine(e.Message);
            // }


            int tala2;
            int.TryParse(Console.ReadLine(), out tala2);



            Console.WriteLine("the new number is {0} :-)", (tala + tala2));

            double a = 0.9;
            Console.WriteLine(a.ToString());
            Console.WriteLine("-------------------------------");

            double d = 3.56;
            int e = (int)d;
            Console.WriteLine(e);
            Console.WriteLine("-------------------------------");
            e = (int)(d + 0.5);



            Console.ReadKey();
        }
    }
}
