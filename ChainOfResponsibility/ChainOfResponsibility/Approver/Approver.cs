using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Approver
{
    public abstract class Approver
    {
        protected Approver _next;

        public void SetNext(Approver next)
        {
            _next = next;
        }

        public abstract void ProcessRequest(int price);
    }
}
