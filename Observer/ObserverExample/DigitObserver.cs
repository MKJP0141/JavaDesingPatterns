using System;
using System.Threading;

namespace ObserverExample
{
    public class DigitObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine($"DigitObserver:{generator.GetNumber()}");
            try
            {
                Thread.Sleep(100);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}