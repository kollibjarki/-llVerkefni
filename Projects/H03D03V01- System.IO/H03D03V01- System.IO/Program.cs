using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H03D03V01__System.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo info = new FileInfo("C:\\Temp\\fileinfo.txt");
            if (info.Exists)
            {



                if (info.Length > 0)
                {

                    File.Copy("C:\\Temp\\fileinfo.txt", "C:\\Temp\\fileinfo2.txt");
                    FileAttributes attributes = info.Attributes;
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("the file does not exist");
            }
            


            Console.ReadKey();
        }
    }
}