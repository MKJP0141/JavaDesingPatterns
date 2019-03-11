using System;

namespace ObserverExample
{
    public class PaddingObserver : Observer
    {
        private string _str;

        public PaddingObserver(string str)
        {
            _str = str;
        }

        public void Update(NumberGenerator generator)
        {
            var padCount = generator.GetNumber();
            Console.WriteLine(_str.PadLeft(padCount, ' '));
        }
    }
}