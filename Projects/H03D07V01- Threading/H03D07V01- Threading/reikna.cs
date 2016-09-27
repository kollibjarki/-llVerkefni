using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D07V01__Threading
{
    class reikna
    {
        public int tala1, tala2, nidurstada;

        public reikna(int _tala1, int _tala2)
        {
            tala1 = _tala1;
            tala2 = _tala2;
        }

        public void leggjasaman()
        {
            nidurstada = tala1 + tala2;
        }


    }
}
