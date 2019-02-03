using System;
using System.Collections.Generic;
using System.IO;

namespace Bridge
{
    public class DisplayFile : DisplayImpl
    {
        private string _filePath;
        private List<string> _lines = new List<string>();

        public DisplayFile(string filePath)
        {
            _filePath = filePath;
        }

        public override void RawClose()
        {
            _lines.Clear();
        }

        public override void RawOpen()
        {
            var lines = File.ReadAllLines(_filePath);
            _lines.AddRange(lines);
        }

        public override void RawPrint()
        {
            _lines.ForEach(Console.WriteLine);
        }
    }
}