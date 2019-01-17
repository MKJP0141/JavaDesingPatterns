using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CSVBuilder : Builder
    {
        private string _csv;

        public override void Close()
        {
            _csv = string.Concat(_csv, "====");
        }

        public override void MakeItems(string[] items)
        {
            var datas = string.Empty;
            string delimiter = string.Empty;
            foreach (var item in items)
            {
                datas = string.Concat(datas, delimiter, item);
                delimiter = "::";
            }
            _csv = string.Concat(_csv, datas);
        }

        public override void MakeString(string str)
        {
            _csv = string.Concat(_csv, "****", str, "****,");
        }

        public override void MakeTitle(string title)
        {
            _csv = string.Concat("[[", title,  "]],");
        }

        public string GetResult()
        {
            return _csv;
        }
    }
}
