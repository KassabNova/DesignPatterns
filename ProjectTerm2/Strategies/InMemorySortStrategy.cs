using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTerm2
{
    class InMemorySortStrategy : IMetricMemoryStrategy
    {
        public List<Metric> Sort(List<Metric> metrics)
        {
            Console.WriteLine("Sorting using memory! Using: {0}K of ram memory", new Random().Next(1000,42069));
            return metrics.OrderBy(m => m.metricIndex).ToList();
        }
    }
}
