using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Form form = new Form();
            form.x = 1;
            form.y = 5;
            form.color = "blue";
            */

            Box box = new Box();
            box.x = 4;
            box.y = 12;
            box.color = "yellow";
            box.length = 3;
            box.Height = 1;

            box.draw();

            Ring ring = new Ring();
            ring.x = 3;
            ring.y = 4;
            ring.color = "green";
            ring.radius = 15;
            ring.draw();



            Console.ReadKey();
        }
    }
}
