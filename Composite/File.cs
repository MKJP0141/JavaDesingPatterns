using System;

namespace Composite
{
    public class File : Entry
    {
        private readonly string _name;
        private readonly int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        internal override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this.ToString()}");
        }
    }
}