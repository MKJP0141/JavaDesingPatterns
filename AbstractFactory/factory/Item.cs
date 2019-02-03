using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factory
{
    public abstract class Item
    {
        protected string _caption;

        public Item(string caption)
        {
            _caption = caption;
        }

        public abstract string MakeHTML();
    }
}
