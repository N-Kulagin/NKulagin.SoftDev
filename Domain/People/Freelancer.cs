using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKulagin.SoftDev.Domain
{
    public class Freelancer : Person
    {
        public Freelancer(string name, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {

        }
    }
}
