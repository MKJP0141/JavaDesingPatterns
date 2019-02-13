using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class MultiStringDisplay : Display
    {
        private StringBuilder _builder;

        public MultiStringDisplay() : base()
        {
            _builder = new StringBuilder();
        }

        public void Add(string line)
        {
            _builder.AppendLine(line);
        }

        public override int GetColumns()
        {
            int maxLength = 0;
            for (int i = 0; i < _builder.Length; i++)
            {
                if (maxLength < _builder[i].ToString().Length)
                    maxLength = _builder[i].ToString().Length;
            }
            return maxLength;
        }

        public override int GetRows()
        {
            return _builder.Length;
        }

        public override string GetRowText(int row)
        {
            return _builder[row].ToString();
        }
    }
}
