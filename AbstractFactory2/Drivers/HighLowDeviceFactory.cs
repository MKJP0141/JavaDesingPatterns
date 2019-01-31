using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class HighLowDeviceFactory : DeviceFactory
    {
        public override DisplayDevice GetDisplayDevice()
        {
            return new HighDisplayDevice();
        }

        public override PrinterDevice GetPrinterDevice()
        {
            return new LowPrinterDevice();
        }
    }
}
