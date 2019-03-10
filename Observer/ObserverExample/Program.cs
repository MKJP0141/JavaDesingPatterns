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
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.Execute();
        }
    }
}
