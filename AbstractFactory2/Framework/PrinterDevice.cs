using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Framework
{
    public enum PrinterSpec
    {
        Low = 0,
        High = 1
    }

    public abstract class PrinterDevice
    {
        public abstract PrinterSpec GetPrinterSpec();
    }
}
