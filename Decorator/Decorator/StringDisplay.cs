namespace Decorator
{
    public class StringDisplay : Display
    {
        private string _string;

        public StringDisplay(string value)
        {
            _string = value;
        }

        public override int GetColumns()
        {
            return _string.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return _string;
            }
            else
            {
                return null;
            }
        }
    }
}