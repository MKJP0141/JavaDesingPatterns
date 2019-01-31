using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Framework
{
    public abstract class DeviceFactory
    {
        public abstract DisplayDevice GetDisplayDevice();

        public abstract PrinterDevice GetPrinterDevice();
    }
}
