using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKulagin.SoftDev.Domain
{
    public class Staff : Person
    {
        public decimal MonthlySalary { get; set; }
        public Staff(string name, decimal monthSalary, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
            MonthlySalary = monthSalary;
        }
    }
}
