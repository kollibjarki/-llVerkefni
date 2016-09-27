using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H03D03V05_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {


            /*

            StreamReader s = new StreamReader(@"C:\Temp\fileinfo.txt");

            while (true)
            {

                string line = s.ReadLine();
                if(line == null)
                {
                    break;
                }
                Console.WriteLine(line);
            }
            //FileStream f = new FileStream(@"C:\Temp\fileinfo.txt", FileMode.Open, FileAccess.Read, FileShare.Read);


            //Console.WriteLine(f.ReadByte());
            */



            string line;
            using (StreamReader sr = new StreamReader(@"C:\Temp\fileinfo.txt"))
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



            }


                Console.ReadKey();
                //sr.Close();
        }
    }
}
