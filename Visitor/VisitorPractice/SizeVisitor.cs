using System;

namespace VisitorPractice
{
    public class SizeVisitor : Visitor
    {
        private int _size = 0;

        public override void Visit(File file)
        {
            _size += file.GetSize();
            Console.WriteLine($"file name:{file.GetName()} ({file.GetSize()})");
        }

        public override void Visit(Directory directory)
        {
            var itr = directory.GetEnumerator();
            int totalSize = 0;
            while (itr.MoveNext())
            {
                var item = (Entry)itr.Current;
                item.Accept(this);
                totalSize += item.GetSize();
            }
            Console.WriteLine($"directory name:{directory.GetName()} ({totalSize})");
        }

        public int Size => _size;
    }
}