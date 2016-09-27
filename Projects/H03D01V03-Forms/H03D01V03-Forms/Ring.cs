using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
    class Ring : Form
    {
        public int radius { get; set; }

        public override void draw()
        {
            Console.WriteLine("starting point: ({0},{1})", x, y);
            Console.WriteLine("color:  {0}", color);
            Console.WriteLine("radius: {0}", radius);

            double ummal = radius * radius * Math.PI;
            Console.WriteLine("ummal: {0}", ummal);
        }
    }
}
