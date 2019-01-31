using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class LowDeviceFactory : DeviceFactory
    {
        public override DisplayDevice GetDisplayDevice()
        {
            return new LowDisplayDevice();
        }

        public override PrinterDevice GetPrinterDevice()
        {
            return new LowPrinterDevice();
        }
    }
}
