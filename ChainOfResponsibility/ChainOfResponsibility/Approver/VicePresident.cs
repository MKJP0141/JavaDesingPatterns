using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Approver
{
    class VicePresident : Approver
    {
        public override void ProcessRequest(int price)
        {
            if (price < 25000)
            {
                Console.WriteLine($"{this.GetType().Name} approved request#{price}");
            }
            else if (_next != null)
            {
                _next.ProcessRequest(price);
            }
        }
    }
}
