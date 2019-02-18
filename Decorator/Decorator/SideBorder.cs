namespace Decorator
{
    public class SideBorder : Border
    {
        private char _borderChar;

        public SideBorder(Display display, char ch) : base(display)
        {
            _borderChar = ch;
        }

        public override int GetColumns()
        {
            return 1 + _display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return _display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return _borderChar + _display.GetRowText(row) + _borderChar;
        }
    }
}