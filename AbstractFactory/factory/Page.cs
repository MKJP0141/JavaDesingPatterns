using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbstractFactory.factory
{
    public abstract class Page
    {
        protected string _title;
        protected string _author;
        protected List<Item> _contents = new List<Item>();

        public Page(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public void Add(Item item)
        {
            _contents.Add(item);
        }

        public void Output()
        {
            try
            {
                string fileName = $"{_title}.html";
                File.WriteAllText(fileName, this.MakeHTML());
                Console.WriteLine($"{fileName}が作成されました");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public abstract string MakeHTML();
    }
}
