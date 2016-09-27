using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D011V06_LottoJson
{
    class Lotto
    {
        
            public string date { get; set; }
            public string lotto { get; set; }
            public string joker { get; set; }
            public string prize { get; set; }
            public string link { get; set; }


        public override string ToString()
        {
            string Lotto = string.Format("\nDate\t: {0}", date);

            return lotto;
        }

    }
}
