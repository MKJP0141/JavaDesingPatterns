using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public interface ISubscriber
    {
        void Update(IPostOffice postOffice);
    }
}
