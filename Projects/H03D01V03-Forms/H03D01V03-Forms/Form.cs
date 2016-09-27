using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
   abstract class Form
    {
        public int x { get; set; }
        public int y { get; set; }
        public string color { get; set; }

        public abstract void draw();

    }
}
