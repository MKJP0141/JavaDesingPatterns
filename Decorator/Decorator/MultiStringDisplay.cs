using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class MultiStringDisplay : Display
    {
        private List<string> _list;
        private int _columns = 0;

        public MultiStringDisplay() : base()
        {
            _list = new List<string>();
        }

        public void Add(string line)
        {
            _list.Add(line);
            UpdateColumn(line);
        }

        private void UpdateColumn(string line)
        {
            if (line.Length > _columns)
                _columns = line.Length;
        }

        public override int GetColumns()
        {
            int maxLength = 0;
            for (int i = 0; i < _list.Count; i++)
            {
                if (maxLength < _list[i].Length)
                    maxLength = _list[i].Length;
            }
            return maxLength;
        }

        public override int GetRows()
        {
            return _list.Count;
        }

        public override string GetRowText(int row)
        {
            return _list[row];
        }
    }
}
