using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public interface IPostOffice
    {
        void Receive(ILetter letter);

        void AttachSubscriber(ISubscriber subscriber);

        void DetachSubscriber(ISubscriber subscriber);

        void Notify();

        ILetter GetLetter();
    }
}
