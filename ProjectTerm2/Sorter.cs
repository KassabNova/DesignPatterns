using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTerm2
{
    class Sorter
    {
        private readonly IMetricMemoryStrategy mSorter;

        public Sorter(IMetricMemoryStrategy sorter)
        {
            mSorter = sorter;
        }

        public List<Metric> Sort(List<Metric> unSortedList)
        {
            return mSorter.Sort(unSortedList);
        }

    }
}
