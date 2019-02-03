using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.TableFactory
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"<html><head><title>{_title}</title></head>");
            builder.AppendLine("<body>");
            builder.AppendLine($"<h1>{_title}</h1>");
            builder.AppendLine("<table width=\"80%\" border\"3\"");
            var iterator = _contents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var item = iterator.Current;
                builder.AppendLine($"<tr>{item.MakeHTML()}</tr>");
            }
            builder.AppendLine("</table>");
            builder.AppendLine($"<hr><address>{_author}</address>");
            builder.AppendLine("</body></html>");
            return builder.ToString();
        }
    }
}
