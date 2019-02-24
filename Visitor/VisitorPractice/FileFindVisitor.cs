using System;
using Composite;

namespace VisitorPractice
{
    public class FileFindVisitor : Visitor
    {
        private string _currentDir = string.Empty;

        private string _ext;

        public FileFindVisitor(string ext)
        {
            _ext = ext;
        }

        public override void Visit(File file)
        {
            var ext = System.IO.Path.GetExtension(file.GetName());
            if (ext == _ext)
                Console.WriteLine(file.GetName());
        }

        public override void Visit(Directory directory)
        {
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                var entry = (Entry)it.Current;
                entry.Accept(this);
            }
        }
    }
}