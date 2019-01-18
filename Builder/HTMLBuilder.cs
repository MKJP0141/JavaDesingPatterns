using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Builder
{
    public class HTMLBuilder : Builder
    {
        private string _filename;
        private StreamWriter _file;

        public override void Close()
        {
            _file.WriteLine("</body></html>");
            _file.Close();
        }

        public override void MakeItems(string[] items)
        {
            _file.WriteLine("<ul>");
            for (int i = 0; i < items.Length; i++)
            {
                _file.WriteLine($"<li>{items[i]}</li>");
            }
            _file.WriteLine("</ul>");
        }

        public override void MakeString(string str)
        {
            _file.WriteLine($"<p>{str}</p>");
        }

        public override void MakeTitle(string title)
        {
            _filename = title + ".html";
            try
            {
                _file = new StreamWriter(_filename, append: false, encoding: Encoding.UTF8);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            _file.WriteLine($"<html><head><title>{title}</title></head><body>");
            _file.WriteLine($"<h1>{title}</h1>");
        }

        public string GetResult()
        {
            return _filename;
        }
    }
}
