using System;
using System.Collections.Generic;

namespace ProjectTerm2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Metric metric = new Metric(MetricType.CounterMetric,"myMetric", 1);
            Metric metricProblem = new Metric();
            Metric metricSolution = new Metric();

            //Before having the Prototype, cloning had to be manual, or this happens.
            //Sometimes, if it had to be manual, private properties could not be set.
            metricProblem = metric;
            metricProblem.metricName = "Metric problem uh oh";

            //Cloning it with a prototype. It gets rid of that problem
            metricSolution = metric.Clone();
            metricSolution.metricName = "Metric problem solved with prototype";
            
            //Generating dummy metrics
            Metric metricItem1 = metric.Clone();
            Metric metricItem2 = metric.Clone();
            Metric metricItem3 = metric.Clone();
            Metric metricItem4 = metric.Clone();
            Metric metricItem5 = metric.Clone();
            metricItem1.metricIndex = new Random().Next(1000, 42069);
            metricItem2.metricIndex = new Random().Next(1000, 42069);
            metricItem3.metricIndex = new Random().Next(1000, 42069);
            metricItem4.metricIndex = new Random().Next(1000, 42069);
            metricItem5.metricIndex = new Random().Next(1000, 42069);

            List<Metric> unSortedMetrics = new List<Metric>()
            {
                metricItem1,
                metricItem2,
                metricItem3,
                metricItem4,
                metricItem5
            };

            //Using the same class, we can do two behaviours,
            //instead of creating one each time we need to do something
            //Also, it can be changed on runtime, making the code cleaner.
            var sorter = new Sorter(new InMemorySortStrategy());
            sorter.Sort(unSortedMetrics); 

            sorter = new Sorter(new SwapMemorySortStrategy());
            sorter.Sort(unSortedMetrics);

        }
    }
}
