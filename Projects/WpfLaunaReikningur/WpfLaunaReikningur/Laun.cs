using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLaunaReikningur
{
    class Laun
    {
        public double manadarlaun    { get; set; }
        public double skattur = 0.37;
        public double orlof   = 0.10;
        public double launfradrattur = 0; 
        public double útborgað          { get; set; }
        public double personuafslattur = 50000; 

        public double Calculate1()
        {
            if (Convert.ToBoolean(skattur))
            {
                return manadarlaun - (manadarlaun * skattur);
            }
            else
            {
                return 0;
            }
        }
        public double Calculate2()
        {
            if (Convert.ToBoolean(orlof))
            {
                return manadarlaun * orlof;
            }
            else
            {
                return 0;
            }
        }

        public double Calculate3()
        {
            if (Convert.ToBoolean(personuafslattur))
            {
                return manadarlaun - (manadarlaun * skattur) + personuafslattur;
            }
            else
            {
                return 0;
            }
        }
             public double Calculate4()
        {
            if (Convert.ToBoolean(launfradrattur)==false)
            {
                
                //return 5000;
                return manadarlaun - personuafslattur + (manadarlaun*orlof)+(manadarlaun * skattur) -manadarlaun;
                //return Calculate2() + Calculate3();
            }
            else
            {
                return 0;
            }

        }
    }
}
