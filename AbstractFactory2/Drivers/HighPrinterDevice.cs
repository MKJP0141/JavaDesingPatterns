using AbstractFactory2.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Drivers
{
    class HighPrinterDevice : PrinterDevice
    {
        public override PrinterSpec GetPrinterSpec()
        {
            return PrinterSpec.High;
        }

        public override string ToString()
        {
            return "High Printer Device";
        }
    }
}
