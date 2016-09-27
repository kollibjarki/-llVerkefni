using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
    class kassi : Form

    {
        public int length { get; set; }

        public override void draw()
        {
            Console.WriteLine("starting point: ({0},{1})", x, y);
            Console.WriteLine("color:  {0}", color);
            Console.WriteLine("height: {0}", length);
        }
    }
}
