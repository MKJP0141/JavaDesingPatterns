using System;

namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datas =
            {
                "Dumpty",
                "Bowman",
                "Carroll",
                "Elfland",
                "Alice",
            };

            SortAndPrint sap = new SortAndPrint(datas, new SelectionSorter());
            sap.Execute();
        }
    }
}
