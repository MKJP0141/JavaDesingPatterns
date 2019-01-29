using AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.TableFactory
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            var builder = new StringBuilder();
            builder.AppendLine("<td>");
            builder.AppendLine($"<talbe width=\"100%\" border=\"1\"><tr>");
            builder.AppendLine($"<td bgcolor=\"cccccc\" align=\"center\" colspan=\"{_tray.Count}\"><b>{_caption}</b></td>");
            builder.AppendLine("</tr>");
            builder.AppendLine("<tr>");
            var iterator = _tray.GetEnumerator();
            while (iterator.MoveNext())
            {
                var item = iterator.Current;
                builder.AppendLine(item.MakeHTML());
            }
            builder.AppendLine("</tr></table>");
            builder.AppendLine("</td>");
            return builder.ToString();
        }
    }
}
