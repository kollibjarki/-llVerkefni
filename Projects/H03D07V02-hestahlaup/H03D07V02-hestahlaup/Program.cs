using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace H03D07V02_hestahlaup
{
    class Program
    {
        public static void Skipti()
        {
            for (int i = 0; i < 10; i++) Console.WriteLine();
        }

        //static void Hestur(object StateInfo)
        //{
        //    string hestur = (string)StateInfo;

        //    Console.WriteLine("hestur 1 {0}", hestur);
        //    Console.WriteLine("hestur 2 {0}", hestur);
        //    Console.WriteLine("hestur 3 {0}", hestur);
        //    Console.WriteLine("hestur 4 {0}", hestur);



        //}

        static void Main(string[] args)
        {
            

            //Thread skipti = new Thread(new ThreadStart(Skipti));


            horse h1 = new horse("Hestur 1");
            horse h2 = new horse("Hestur 2");
            horse h3 = new horse("Hestur 3");
            horse h4 = new horse("Hestur 4");
            //Console.WriteLine("your horses are: {0} {1} {2} {3}",h1 ,h2 ,h3 ,h4);


            
            
                Thread hestur1 = new Thread(new ThreadStart(h1.run));

                Thread hestur2 = new Thread(new ThreadStart(h2.run));

                Thread hestur3 = new Thread(new ThreadStart(h3.run));

                Thread hestur4 = new Thread(new ThreadStart(h4.run));

                hestur1.Start();
                hestur2.Start();
                hestur3.Start();
                hestur4.Start();





            //while (true)
            //{
            //    Thread hestur1 = new Thread(new ThreadStart(h1.run));
            //    Console.WriteLine(h1.distance);
            //}


            while (true)
            {
                if (h1.finishedTime != null
                 && h2.finishedTime != null
                 && h3.finishedTime != null
                 && h4.finishedTime != null)
                {
                    if (h1.finishedTime < h2.finishedTime
                        && h1.finishedTime < h3.finishedTime
                        && h1.finishedTime < h4.finishedTime)
                    {
                        Console.WriteLine("{0} won!", h1.name);
                    }
                    else if (h2.finishedTime < h1.finishedTime
                        && h2.finishedTime < h3.finishedTime
                        && h2.finishedTime < h4.finishedTime)
                    {
                        Console.WriteLine("{0} won!", h2.name);
                    }
                    else if (h3.finishedTime < h1.finishedTime
                        && h3.finishedTime < h2.finishedTime
                        && h3.finishedTime < h4.finishedTime)
                    {
                        Console.WriteLine("{0} won!", h3.name);
                    }
                    else if (h4.finishedTime < h1.finishedTime
                        && h4.finishedTime < h3.finishedTime
                        && h4.finishedTime < h2.finishedTime)
                    {
                        Console.WriteLine("{0} won!", h4.name);
                    }
                    else
                    {
                        Console.WriteLine("What... no one won?");
                    }
                    break;
                }


            }



                    Console.ReadLine();
        }

    }

}
