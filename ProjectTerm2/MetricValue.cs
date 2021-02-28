using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTerm2
{
    class MetricValue
    {
        ulong intValue { get; set; }
        double doubleValue { get; set; }

        public MetricValue()
        {
            var rnd = new Random();
            intValue = (ulong)rnd.Next();
            doubleValue = rnd.NextDouble();
        }
    }
}
