using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy2
{
    public interface Sorter
    {
        void Sort(IComparable[] datas);
    }
}
