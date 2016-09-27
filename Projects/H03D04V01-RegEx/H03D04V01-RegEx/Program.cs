using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace H03D04V01_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sláðu inn kennitölu");
            string kt = Console.ReadLine();
            string kt2 = Regex.Replace(kt, @"\-","");
            string exp = @"^[0-9]{6}[- ]?[0-9]{4}$";

            //if (Regex.IsMatch(kt,exp))
            //{
            //    Console.WriteLine("kennitala á réttu formi");
            //}

            Match m = Regex.Match(kt, exp);

            Console.WriteLine(m.Groups[0]);
            Console.ReadKey();
        }
    }
}
