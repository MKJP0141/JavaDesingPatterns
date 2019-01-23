using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class ListPrinter
    {
        public void PrintList(List<string> list)
        {
            var comparer = CreateComparer();
            var newList = new List<string>(list);

            newList.Sort(comparer);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }

        protected abstract IComparer<string> CreateComparer();
    }

    class DictionaryOrderListPrinter : ListPrinter
    {
        protected override IComparer<string> CreateComparer()
        {
            return new DictionaryOrderComparer();
        }
    }

    class DictionaryOrderComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }

    class LengthOrderListPrinter : ListPrinter
    {
        protected override IComparer<string> CreateComparer()
        {
            return new LengthOrderComparer();
        }
    }

    class LengthOrderComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }
}
