using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTerm2
{
    interface IMetricMemoryStrategy
    {
        List<Metric> Sort(List<Metric> metrics);
    }
}
