using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace H03D07V01__Threading
{
    class Program
    {
        public static void telja()
        {
            for (int i = 0; i < 1000; i++) Console.WriteLine(i);
        }

        static void Thradur(object StateInfo)
        {
            string nafn = (string)StateInfo;

            Console.WriteLine("þráður seigir hallo {0}", nafn);
        }

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(telja));

            reikna r = new reikna(1, 2);

            Thread t2 = new Thread(new ThreadStart(r.leggjasaman));

            ThreadPool.QueueUserWorkItem(Thradur, "jón");

            t1.Start();
            t2.Start();

            Thread.Sleep(100);

            Console.WriteLine(r.nidurstada);

            Console.ReadLine();

        }
    }
}
