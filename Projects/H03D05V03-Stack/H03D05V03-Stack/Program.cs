using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace H03D05V03_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack hladi = new Stack();
            hladi.Push("hallo");
            hladi.Push("hafnarfjörður");

            int fjöldi = hladi.Count;

            for (int i = 0; i < fjöldi; i++)
            {
                Console.WriteLine(hladi.Pop().ToString());
            }


            Console.ReadKey();

        }
    }
}
