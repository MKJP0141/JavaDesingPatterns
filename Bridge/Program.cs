using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new Display(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));
            d1.DisplayText();
            d2.DisplayText();
            d3.DisplayText();
            d3.MultiDisplay(5);

            RandomDisplay d4 = new RandomDisplay(new StringDisplayImpl("Hello, Galaxy."));
            d4.RandomDisplayText(10);

            CountDisplay d5 = new CountDisplay(new DisplayFile("Sample.txt"));
           d5.DisplayText();
           d5.MultiDisplay(3);
        }
    }
}
