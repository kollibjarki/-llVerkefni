using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip
{
    class Payslip
    {
        public double Salary { get; set; }
        public double? HolidayPercentage { get; set; }

        public double CalculateHoliday()
        {
            if (HolidayPercentage.HasValue)
            {
                return Salary * HolidayPercentage.Value;
            }
            else
            {
                return 0;
            }
        }
    }
}
