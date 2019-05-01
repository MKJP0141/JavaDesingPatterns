using System;
using System.Collections.Generic;
using System.Text;

namespace ProxySample
{
    public interface IInternet
    {
        void ConnectTo(string serverHost);
    }
}
