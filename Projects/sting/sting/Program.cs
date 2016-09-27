using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sting
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "hér er smá texti ";
            
            Console.WriteLine(t.Replace("er", "mun vera"));

            Console.WriteLine(t.ToUpper());

            Console.WriteLine(t.Substring(4));
            Console.WriteLine(t.Substring(4,12));

            // hún tekur fyrstu 4 í burtu 

            string fulltafbilum = "         MÁNUDAGUR             ";
            Console.WriteLine("'{0}'", fulltafbilum.Trim().ToLower().Substring(2));
            





            Console.ReadKey();
        }
    }
}
