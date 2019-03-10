using System;

namespace ObserverExample
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private int _number;
        private Random _rand = new Random();

        public override void Execute()
        {
            for (int i = 0; i < 20; i++)
            {
                _number = _rand.Next(0, 50);
                NotifyObservers();
            }
        }

        public override int GetNumber()
        {
            return _number;
        }
    }
}