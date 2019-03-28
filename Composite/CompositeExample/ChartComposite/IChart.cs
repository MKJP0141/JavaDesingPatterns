using System;
using System.Collections.Generic;

namespace ChartComposite
{
    public interface IChart : ICloneable
    {
        int Code { get; }
        
        string Name { get; }

        void Add(IChart chart);

        void Remove(IChart chart);

        IEnumerable<IChart> Get();

        void Print();

        void Print(int indent);

         int GetPoint();
    }
}