using AbstractFactory2.Framework;
using System;

namespace AbstractFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new FactoryGenerator(DeviceType.HighLow);
            var factory = generator.GetDeviceFactory();

            var display = factory.GetDisplayDevice().ToString();
            var printer = factory.GetPrinterDevice().ToString();

            Console.WriteLine(display);
            Console.WriteLine(printer);
        }
    }
}
