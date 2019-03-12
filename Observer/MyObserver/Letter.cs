using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public class Letter : ILetter
    {
        private string _from;
        private string _to;

        public Letter(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public override string ToString()
        {
            return $"From:{_from}, To:{_to}";
        }
    }
}
