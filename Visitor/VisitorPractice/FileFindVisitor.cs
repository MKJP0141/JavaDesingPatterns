using System;
using System.Collections.Generic;
using Composite;

namespace VisitorPractice
{
    public class FileFindVisitor : Visitor
    {
        private string _currentDir = string.Empty;

        private string _ext;

        private List<File> _foundFiles;

        public FileFindVisitor(string ext)
        {
            _ext = ext;
            _foundFiles = new List<File>();
        }

        public override void Visit(File file)
        {
            var ext = System.IO.Path.GetExtension(file.GetName());
            if (ext == _ext)
                _foundFiles.Add(file);
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

        public IEnumerable<File> FoundFiles
        {
            get
            {
                foreach (var file in _foundFiles)
                {
                    yield return file;
                }
            }
        }
    }
}