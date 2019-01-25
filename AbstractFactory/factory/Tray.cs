using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.factory
{
    public abstract class Tray : Item
    {
        protected List<Item> _tray = new List<Item>();

        public Tray(string caption) : base(caption)
        {
        }

        public void Add(Item item)
        {
            _tray.Add(item);
        }
    }
}
