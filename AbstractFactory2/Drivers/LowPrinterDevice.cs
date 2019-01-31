using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class LowPrinterDevice : PrinterDevice
    {
        public override PrinterSpec GetPrinterSpec()
        {
            return PrinterSpec.Low;
        }

        public override string ToString()
        {
            return "Low Printer Device";
        }
    }
}
