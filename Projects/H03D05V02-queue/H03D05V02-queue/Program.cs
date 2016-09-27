using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H03D05V02_queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue rod = new Queue();
            rod.Enqueue("Halló");
            rod.Enqueue("Hafnarfjörður");

            int fjoldi = rod.Count;

            for (int i = 0; i < fjoldi; i++) 
            {
                Console.WriteLine(rod.Dequeue().ToString());
            }

            Console.ReadKey();
        }
    }
}
