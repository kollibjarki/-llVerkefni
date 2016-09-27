using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
namespace H03D04V01_WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skráðu inn línu að eigin vali herra minn góður: ");
            string svar = Console.ReadLine();


            string line;
            File.AppendAllText(@"c:\Temp\fileinfo.txt", svar + Environment.NewLine);

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

                using (Stream fs = File.OpenRead(@"C:\Temp\fileinfo.txt"))
                using (Stream fd = File.Create(@"C:\Temp\fileinfo.zip"))
                using (Stream csStream = new GZipStream(fd, CompressionMode.Compress))
                {
                    byte[] buffer = new byte[1024];
                    int nRead;
                    while ((nRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        csStream.Write(buffer, 0, nRead);
                    }
                }

            }

            using (Stream fd = File.Create(@"C:\Temp\fileinfo5.txt"))
            using (Stream fs = File.OpenRead(@"C:\Temp\fileinfo.zip"))
            using (Stream csStream = new GZipStream(fs, CompressionMode.Decompress))
            {
                byte[] buffer = new byte[1024];
                int nRead;
                while ((nRead = csStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fd.Write(buffer, 0, nRead);
                }
            }


            Console.ReadKey();
        }
    }
}
