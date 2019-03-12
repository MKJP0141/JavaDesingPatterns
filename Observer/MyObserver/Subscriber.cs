using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public class Subscriber : ISubscriber
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public virtual void Update(IPostOffice postOffice)
        {
            Console.WriteLine($"{postOffice.GetLetter().ToString()}");
        }
    }
}
