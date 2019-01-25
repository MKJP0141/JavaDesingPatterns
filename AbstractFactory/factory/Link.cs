using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factory
{
    public abstract class Link : Item
    {
        protected string _url;

        public Link(string caption, string url) : base(caption)
        {
            _url = url;
        }
    }
}
