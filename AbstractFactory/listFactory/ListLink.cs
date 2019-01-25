using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.listFactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $"  <li><a href={_url}>{_caption}</a></li>" + "\n";
        }
    }
}
