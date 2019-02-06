using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy2
{
    class SelectionSorter : Sorter
    {
        public void Sort(IComparable[] datas)
        {
            for (int i = 0; i < datas.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < datas.Length; j++)
                {
                    if (datas[min].CompareTo(datas[j]) > 0)
                    {
                        min = j;
                    }
                }
                IComparable passingPlace = datas[min];
                datas[min] = datas[i];
                datas[i] = passingPlace;
            }
        }
    }
}
