using System;
using System.Collections.Generic;
using System.Text;

namespace ProxySample
{
    public class ProxyInternet : IInternet
    {
        private IInternet _internet = new RealInternet();
        private static List<string> _bannedSites = new List<string>
        {
            "abc.com",
            "def.com",
            "ijk.com",
            "lnm.com"
        };

        public virtual void ConnectTo(string serverHost)
        {
            if (_bannedSites.Contains(serverHost.ToLower()))
            {
                throw new Exception("Accesdd Denied.");
            }
            _internet.ConnectTo(serverHost);
        }
    }
}
