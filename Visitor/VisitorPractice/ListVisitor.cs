using System;
using Composite;

namespace VisitorPractice
{
    public class ListVisitor : Visitor
    {
        private string _currentDir = string.Empty;

        public override void Visit(File file)
        {
            Console.WriteLine($"{_currentDir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{_currentDir}/{directory}");
            string savedir = _currentDir;
            _currentDir = $"{_currentDir}/{directory.GetName()}";
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                var entry = (Entry)it.Current;
                entry.Accept(this);
            }
            _currentDir = savedir;
        }
    }
}