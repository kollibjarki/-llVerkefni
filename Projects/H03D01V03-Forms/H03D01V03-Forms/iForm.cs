using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D01V03_Forms
{
   interface iForm
    {
         int x { get; set; }
         int y { get; set; }
         string color { get; set; }

        void draw();

    }
}
