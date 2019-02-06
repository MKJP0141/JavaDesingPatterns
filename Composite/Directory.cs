using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Entry
    {
        private readonly string _name;
        private readonly List<string> _directory = new List<string>();

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
            Iterator it = _directory.GetEnumerator();
            while (it.HasNext())
            {
                Entry entry = (Entry)it.Next();
                size += entry.GetSize();
            }
            return size;
        }

        public Entry Add(Entry entry)
        {
            _directory.Add(entry);
            return this;
        }

        protected override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this.ToString()}");
            Iterator it = _directory.GetEnumerator();
            while (it.HasNext())
            {
                Entry entry = (Entry)it.Next();
                entry.PrintList($"{prefix}/{_name}");
            }
        }
    }
}