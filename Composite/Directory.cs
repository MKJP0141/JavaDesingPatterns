using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Entry
    {
        private readonly string _name;
        private readonly List<object> _directory = new List<object>();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            int size = 0;
            var it = _directory.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.GetSize();
            }
            return size;
        }

        public override Entry Add(Entry entry)
        {
            _directory.Add(entry);
            entry._parent = this;
            return this;
        }

        internal override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this.ToString()}");
            var it = _directory.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.PrintList($"{prefix}/{_name}");
            }
        }
    }
}