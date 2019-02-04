using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class WinningStrategy : Strategy
    {
        private Random _random;
        private bool _won = false;
        private Hand _prevHand;

        public WinningStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            if (!_won)
            {
                _prevHand = Hand.GetHand(_random.Next(3));
            }
            return _prevHand;
        }

        public void Study(bool win)
        {
            _won = win;
        }

    }
}
