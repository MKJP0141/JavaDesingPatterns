using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.TableFactory
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $"<td><a href=\"{_url}\">{_caption}</a></td>\n";
        }
    }
}
