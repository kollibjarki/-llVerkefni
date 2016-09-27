using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H03D03V03_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Directory");
            string path = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(path);

            Console.WriteLine(path);


            //DirectoryInfo dir = new DirectoryInfo(@"c:\temp");
            Console.WriteLine("--The directory contains these files aka notepad files:");
            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine("*****{0}", file.Name);

            }

            //Console.WriteLine("--The directory contains these files aka notepad files:");
            foreach (var file in dir.GetFiles())
            {
                if (file.IsReadOnly)
                {
                    Console.WriteLine("* {0}", file.Name);
                }
            }

            Console.WriteLine("--THe directory containts these directories aka folders:");
            foreach(var folder in dir.GetDirectories())
            {
                Console.WriteLine("******{0}", folder.Name);
            }


            Console.ReadKey();


        }
    }
}
