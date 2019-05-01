using System;
using System.Collections.Generic;
using System.Text;

namespace ProxySample
{
    public class RealInternet : IInternet
    {
        public virtual void ConnectTo(string serverHost)
        {
            Console.WriteLine($"Connecting to {serverHost}");
        }
    }
}
