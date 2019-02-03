using System;

namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string _string;
        private int _width;

        public StringDisplayImpl(string str)
        {
            _string = str;
            _width = _string.Length;
        }

        public override void RawClose()
        {
            PrintLine();
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{_string}|");
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}