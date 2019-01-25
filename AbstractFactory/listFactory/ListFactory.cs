using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.listFactory
{
    public class ListFactory : Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new ListPage(title, author);
        }

        public override Tray CreateTray(string caption)
        {
            return new ListTray(caption);
        }
    }
}
