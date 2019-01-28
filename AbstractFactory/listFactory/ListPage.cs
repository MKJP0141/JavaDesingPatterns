using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.listFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"<html><head><title>{_title}</title></head>");
            builder.AppendLine("<body>");
            builder.AppendLine($"<h1>{_title}</h1>");
            builder.AppendLine("<ul>");
            var iterator = _contents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var item = iterator.Current;
                builder.AppendLine(item.MakeHTML());
            }
            builder.AppendLine("</ul>");
            builder.AppendLine($"<hr><address>{_author}</address>");
            builder.AppendLine("</body></html>");
            return builder.ToString();
        }
    }
}
