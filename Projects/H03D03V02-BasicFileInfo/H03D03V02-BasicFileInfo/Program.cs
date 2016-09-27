using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace H03D03V02_BasicFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("C:\\Temp\\fileinfo2.txt");
           // Console.WriteLine(fi.Length, fi.FullName, fi.DirectoryName, fi.Exists);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.Exists);

            FileInfo fi2 = new FileInfo("C:\\Temp\\fileinfo3.txt");
            if (!fi2.Exists)
            {
                fi2.Create();
            }
            Console.WriteLine("fileinfo3.txt has these attributes: {0}", fi2.Attributes);





            Console.ReadKey();
        }
    }
}
