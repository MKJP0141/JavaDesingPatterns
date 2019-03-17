using System;
using System.Collections.Generic;
using System.Linq;

namespace ChartComposite
{
    public class ChartItem : IChart, IEquatable<ChartItem>
    {
        public ChartItem(int code, string name, int point)
        {
            Code = code;
            Name = name;
            Point = point;
        }

        public int Code {get;private set;}

        public string Name { get; }

        public int Point { get; }

        public void Add(IChart chart)
        {
            throw new System.InvalidOperationException();
        }

        public object Clone()
        {
            return (ChartItem)MemberwiseClone();
        }

        public IEnumerable<IChart> Get()
        {
            return new List<IChart> { this };
        }

        public int GetPoint()
        {
            return Point;
        }

        public void Remove(IChart chart)
        {
            //
        }

        public bool Equals(ChartItem item)
        {
            if (Object.ReferenceEquals(this, item))
                return true;

            if (item == null)
                return false;

            if (item.GetType() != this.GetType())
                return false;
            
            return this.Name == item.Name && this.Code == item.Code && this.Point == item.Point;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ChartItem);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Code.GetHashCode() ^ Point.GetHashCode();
        }

        public void Print()
        {
            this.Print(4);
        }

        public void Print(int indent)
        {
            var space = string.Concat(Enumerable.Repeat(" ", indent));
            Console.WriteLine($"{space}{Name}");
        }
    }
}