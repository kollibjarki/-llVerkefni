using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H03D03V04_Driveinfo
{
    class Program
    {
        static void Main(string[] args)
        {
          
        
            DriveInfo drive = new DriveInfo("C");

            var drivetype = drive.DriveType;
            var freespace = drive.AvailableFreeSpace;
            var totalspace = drive.TotalSize;
            var usedspace = totalspace - freespace;
            var percentageused = (usedspace / (double)totalspace) * 100;

            Console.WriteLine("Laust pláss:\t{0} GB (u.þ.b)", freespace/1024/1024/1024);
            Console.WriteLine("upptekið:\t{0:.0.0} %", percentageused);
            Console.WriteLine("Tegund drifs:\t{0}", drivetype);


            Console.ReadKey();
        }
    }
}
