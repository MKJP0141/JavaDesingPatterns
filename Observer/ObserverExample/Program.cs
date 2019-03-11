using System;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            Observer observer3 = new PaddingObserver("C#");
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.AddObserver(observer3);
            generator.Execute();

            Console.WriteLine("Practice No.1");
            NumberGenerator generator2 = new IncrementalNumberGenerator(10, 50, 5);
            generator2.AddObserver(observer1);
            generator2.AddObserver(observer2);
            generator2.AddObserver(observer3);
            generator2.Execute();
        }
    }
}
