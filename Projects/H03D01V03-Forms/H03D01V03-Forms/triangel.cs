using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
    class triangel : iForm
    {
        public string color { get; set; }
        public int x        { get; set; }
        public int y        { get; set; }
        public int length   { get; set; }
        public int Height   { get; set; }

        public void draw()
        {
            Console.WriteLine("starting point: ({0},{1})", x, y);
            Console.WriteLine("color:  {0}", color);
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("height: {0}", Height);
        }

    }
}
