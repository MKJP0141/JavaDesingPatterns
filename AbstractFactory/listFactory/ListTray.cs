using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            var builder = new StringBuilder();
            builder.AppendLine("<li>");
            builder.AppendLine($"{_caption}");
            builder.AppendLine("<ul>");

            var iterator = _tray.GetEnumerator();
            while (iterator.MoveNext())
            {
                var item = iterator.Current;
                builder.AppendLine(item.MakeHTML());
            }
            builder.Append("</ul>");
            builder.Append("</li>");

            return builder.ToString();
        }
    }
}
