using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "いちご",
                "もも",
                "いちじく"
            };

            Console.WriteLine("五十音順で表示：");
            new DictionaryOrderListPrinter().PrintList(list);

            Console.WriteLine("");

            Console.WriteLine("長さ順で表示：");
            new LengthOrderListPrinter().PrintList(list);

            Console.ReadKey();
        }
    }
}
