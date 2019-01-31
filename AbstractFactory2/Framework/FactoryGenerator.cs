using AbstractFactory2.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2.Framework
{
    public enum DeviceType
    {
        Low = 0,
        High = 1,
        HighLow = 2
    }

    class FactoryGenerator
    {
        private readonly DeviceType _type;

        public FactoryGenerator(DeviceType type)
        {
            _type = type;
        }

        public DeviceFactory GetDeviceFactory()
        {
            switch (_type)
            {
                case DeviceType.Low:
                    return new LowDeviceFactory();

                case DeviceType.High:
                    return new HighDeviceFactory();

                default:
                    return new HighLowDeviceFactory();
            }
        }
    }
}
