using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy2
{
    public class LengthSorter : Sorter
    {
        public void Sort(IComparable[] datas)
        {
            for (int i = 0; i < datas.Length; i++)
            {
                string current = (string)datas[i];
                for (int j = i + 1; j < datas.Length - 1; j++)
                {
                    string next = (string)datas[j];
                    if (current.Length > next.Length)
                    {
                        datas[i] = next;
                        datas[j] = current;
                    }
                }
            }
        }
    }
}
