using System.Text;

namespace Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {
        }

        public override int GetColumns()
        {
            return 1 + _display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + _display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', _display.GetColumns()) + "+";
            }
            else if (row == _display.GetRows() + 1)
            {
                return "+" + MakeLine('-', _display.GetColumns()) + "+";
            }
            else
            {
                return "|" + _display.GetRowText(row - 1) + "|";
            }
        }

        private string MakeLine(char ch, int count)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}