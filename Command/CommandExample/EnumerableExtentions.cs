using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public static class EnumerableExtentions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var x in source)
            {
                action(x);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> func)
        {
            int i = 0;
            foreach (var x in source)
            {
                func(x, i);
                i++;
            }
        }
    }
}
