using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class LowDisplayDevice : DisplayDevice
    {
        public override DisplayResolution GetResolution()
        {
            return DisplayResolution.Low;
        }

        public override string ToString()
        {
            return "Low Display Device";
        }
    }
}
