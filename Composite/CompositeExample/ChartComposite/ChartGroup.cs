using System;
using System.Collections.Generic;
using System.Linq;

namespace ChartComposite
{
    public class ChartGroup : IChart, IEquatable<ChartGroup>
    {
        public ChartGroup(int code, string name)
        {
            Code = code;
            Name = name;
        }

        public int Code { get; private set; }

        public string Name { get; private set; }

        private List<IChart> _charts = new List<IChart>();

        public void Add(IChart chart)
        {
            _charts.Add(chart);
        }

        private void Add(IEnumerable<IChart> charts)
        {
            _charts.AddRange(charts);
        }

        public IEnumerable<IChart> Get()
        {
            var results = new List<IChart>();
            foreach (var chart in _charts)
            {
                results.AddRange(chart.Get().ToList());
            }
            return results;
        }

        public int GetPoint()
        {
            return _charts.Sum(x => x.GetPoint());
        }

        public void Remove(IChart chart)
        {
            _charts.Remove(chart);
        }

        public bool Equals(ChartGroup other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;

            if (other == null || this.GetType() != other.GetType())
                return false;
            
            var chartGroup = other as ChartGroup;
            return chartGroup.Code == this.Code && chartGroup.Name == this.Name;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ChartGroup);
        }

        public override int GetHashCode()   
        {
            return Code.GetHashCode() ^ _charts.GetHashCode();
        }

        public object Clone()
        {
            var clone = (ChartGroup)MemberwiseClone();
            clone._charts = new List<IChart>(this._charts);
            return clone;
        }

        public void Print()
        {
            this.Print(4);
        }

        public void Print(int indent)
        {
            var space = string.Concat(Enumerable.Repeat(" ", indent));
            Console.WriteLine($"{space}{Name}");
            foreach (var chart in _charts)
            {
                chart.Print(indent);
            }            
        }
    }
}