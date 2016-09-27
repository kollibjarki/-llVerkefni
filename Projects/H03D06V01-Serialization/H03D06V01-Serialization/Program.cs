using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace H03D06V01_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skráðu inn möppu að eigin vali herra minn góður: ");
            string svar = Console.ReadLine();


            string valinskra = (@"C:\Temp\" + svar + ".xml");
            Console.WriteLine(valinskra);

            Console.WriteLine("veldu nuna dýr ur þessari möppu sem tok þig 10 tima að bua til frekja annað hvort bua til eða sækja");
            string val = Console.ReadLine();
            string line;
            File.AppendAllText(val , Environment.NewLine);

            using (StreamReader sr = new StreamReader(valinskra))
            {
                while (true)
                {

                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }

                Console.ReadKey();

            }
        }
    }
}
