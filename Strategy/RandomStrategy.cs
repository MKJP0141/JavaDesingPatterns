using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class RandomStrategy : Strategy
    {
        private readonly Random _random;

        public RandomStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            int maxHandValue = 3;
            return Hand.GetHand(_random.Next(maxHandValue));
        }

        public void Study(bool win)
        {
            ;
        }
    }
}
