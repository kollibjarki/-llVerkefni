using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D05V06_ListOfPeople
{
    class employee : person
    {
        public string employeeNumber { get; set; }
        public override void BirtaUpplysingar()
        {
            base.BirtaUpplysingar();
            Console.WriteLine("stafsmannanúmer: {0}",employeeNumber);
        }
    }
}
