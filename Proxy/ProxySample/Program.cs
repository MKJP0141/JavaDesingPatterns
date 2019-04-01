using System;

namespace ProxySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();
            try
            {
                internet.ConnectTo("geeks.org");
                internet.ConnectTo("abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.StackTrace}");
                //throw;
            }
        }
    }
}
