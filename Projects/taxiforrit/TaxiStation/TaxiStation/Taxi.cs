using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    class Taxi
    {
        public int Number { get; set; }
        public string Driver { get; set; }
        public string Car { get; set; }

        public Taxi(int num, string car, string driver)
        {
            Number = num;
            Driver = driver;
            Car = car;
        }

        public override string ToString()
        {
            return string.Format("Nr: {0}, Driver: {1}, Car: {2}", Number, Driver, Car);
        }
    }
}
