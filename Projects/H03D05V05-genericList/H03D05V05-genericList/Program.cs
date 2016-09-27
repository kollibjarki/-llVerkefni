using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace H03D05V05_genericList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> intlist = new List<int>();

            intlist.Add(4);
            intlist.Add(9);
            intlist.Add(12);

            foreach(var num in intlist)
            {
                Console.WriteLine(num.ToString());
            }

            List<string> strengir = new List<string>();

            strengir.Add("hallo");
            strengir.Add("hafnarfjörður");
            strengir.Add("bærinn");
            strengir.Add("í");
            strengir.Add("hrauninu");

            strengir.Sort();

            foreach(string s in strengir)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
