using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class HighDisplayDevice : DisplayDevice
    {
        public override DisplayResolution GetResolution()
        {
            return DisplayResolution.High;
        }

        public override string ToString()
        {
            return "High Display Device";
        }
    }
}
