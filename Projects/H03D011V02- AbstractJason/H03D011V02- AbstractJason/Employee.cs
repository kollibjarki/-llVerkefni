using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D011V02__AbstractJason
{
   public class Employee

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("Employee: {0}, {1}", LastName, FirstName);
        }
    }
}
