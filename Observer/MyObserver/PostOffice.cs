using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public class PostOffice : IPostOffice
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private ILetter _letter;

        public PostOffice()
        {
        }

        public void AttachSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void DetachSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public virtual void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public virtual void Receive(ILetter letter)
        {
            _letter = letter;
            Notify();
        }

        public ILetter GetLetter()
        {
            return _letter;
        }
    }
}
