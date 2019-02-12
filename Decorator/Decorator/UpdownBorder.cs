using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class UpdownBorder : Border
    {
        private char _borderChar;

        public UpdownBorder(Display display, char ch) : base(display)
        {
            _borderChar = ch;
        }

        public override int GetColumns()
        {
            return _display.GetColumns();
        }

        public override int GetRows()
        {
            return 1 + _display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            var list = Enumerable.Repeat<char>(_borderChar, this.GetColumns()).ToList();
            if (row == 0)
            {
                return string.Join("", list).ToString();
            }
            else if (row == GetRows() - 1)
            {
                return string.Join("", list).ToString();
            }
            else
            {
                return _display.GetRowText(row - 1);
            }
        }
    }
}
