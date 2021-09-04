using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKulagin.SoftDev.Domain.People
{
    public class Employee : Staff
    {
        public Employee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {

        }
    }
}
