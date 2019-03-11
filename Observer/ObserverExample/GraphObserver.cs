using System;
using System.Threading;

namespace ObserverExample
{
    public class GraphObserver : Observer
    {
        public virtual void Update(NumberGenerator generator)
        {
            Console.Write("GraphOvserver:");
            int count = generator.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
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