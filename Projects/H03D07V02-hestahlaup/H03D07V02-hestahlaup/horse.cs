using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D07V02_hestahlaup
{
        public class horse
    {
        public string name;

        public int distance;

        public DateTime? finishedTime = null;

        public void run()
        {

            for (; distance < 1000; distance++) Console.WriteLine("{0} has run {1}", name, distance);



            distance += 1;


            finishedTime = DateTime.Now;
            Console.WriteLine(finishedTime);

        }

        public horse(string _name)
        {
            name = _name;
        }
    }
}
