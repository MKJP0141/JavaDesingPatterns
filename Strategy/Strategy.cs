using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface Strategy
    {
        Hand NextHand();

        void Study(bool win);
    }
}
