using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            return new Stats
            {
                average = (numbers.Any()?numbers.Average():double.NaN),
                max =(numbers.Any()? numbers.Max():double.NaN),
                min = (numbers.Any()? numbers.Min():double.NaN),
            };
            //Implement statistics here
        }
    }

    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
}
