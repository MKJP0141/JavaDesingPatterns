using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Framework
{
    public enum DisplayResolution
    {
        Low = 0,
        High = 1
    }

    public abstract class DisplayDevice
    {
        public abstract DisplayResolution GetResolution();
    }
}
