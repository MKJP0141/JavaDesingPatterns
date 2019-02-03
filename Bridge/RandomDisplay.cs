using System;

namespace Bridge
{
    public class RandomDisplay : CountDisplay
    {
        Random _rand = new Random();

        public RandomDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void RandomDisplayText(int times)
        {
            MultiDisplay(_rand.Next(0, times));
        }
    }
}