using System;

namespace ChartComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            IChart item1 = new ChartItem(100, "歯周基本治療処置（20歯以上）", 234);
            IChart item2 = new ChartItem(200, "歯科衛生実地指導", 100);
            IChart pConsuleSets = new ChartGroup(300, "歯周指導");
            IChart item3 = new ChartItem(400, "歯磨きを指導", 0);
            IChart item4 = new ChartItem(500, "フロスの重要性を説明", 0);
            IChart item5 = new ChartItem(600, "PMTC", 160);
            pConsuleSets.Add(item3);
            pConsuleSets.Add(item4);
            pConsuleSets.Add(item5);

            IChart pSets = new ChartGroup(700, "P基本検査");
            pSets.Add(item1);
            pSets.Add(item2);
            pSets.Add(pConsuleSets);

            foreach (var item in pSets.Get())
            {
                Console.WriteLine($"Name : {item.Name}");
            }
            Console.WriteLine($"Total Points: {pSets.GetPoint()}");
            pSets.Print();

            pSets.Remove(item1);
            Console.WriteLine($"Total Points: {pSets.GetPoint()}");
            pSets.Print();
        }
    }
}
