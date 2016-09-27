using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
    class Box : kassi
    {
        public int  length { get; set; }
        public int  Height { get; set; }

        public override void draw()
        {
            Console.WriteLine("starting point: ({0},{1})", x, y);
            Console.WriteLine("color:  {0}", color);
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("height: {0}", Height);
        }
    }
}
