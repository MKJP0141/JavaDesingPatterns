using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy2
{
    public class SortAndPrint
    {
        IComparable[] _datas;
        Sorter _sorter;

        public SortAndPrint(IComparable[] datas, Sorter sorter)
        {
            _datas = datas;
            _sorter = sorter;
        }

        public void Execute()
        {
            Print();
            _sorter.Sort(_datas);
            Print();
        }

        public void Print()
        {
            for (int i = 0; i < _datas.Length; i++)
            {
                Console.Write($"{_datas[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
