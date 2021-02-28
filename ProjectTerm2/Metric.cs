using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTerm2
{
    public enum MetricType
    {
        CounterMetric,
        GaugeMetric,
        EtcMetric
    }
    class Metric
    {
        
        public MetricType metricType { get; set; }
        public string metricName { get; set; }
        private MetricValue metricValue { get; set; }

        internal Metric Clone()
        {
            return MemberwiseClone() as Metric;
        }

        public DateTime metricTime { get; set; }
        public int metricIndex { get; set;  }

        public Metric(MetricType type, string name, int index)
        {
            metricType = type;
            metricName = name;
            metricIndex = new Random().Next(1000, 42069);
            metricTime = DateTime.Now;
            metricValue = new MetricValue();
        }

        public Metric()
        {
        }
    }

    
}
