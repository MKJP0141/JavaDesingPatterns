using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace InterpreterSample
{
    public class Context
    {
        private string _text;

        private Queue<string> _tokens = new Queue<string>();

        private string _currentToken;

        public Context(string text)
        {
            _text = text;
            _tokens = new Queue<string>(_text.Split(' '));
            NextToken();
        }

        public string CurrentToken()
        {
            return _currentToken;
        }

        public string NextToken()
        {
            var iterator = _tokens.GetEnumerator();
            if (iterator.MoveNext())
            {
                _currentToken = _tokens.Dequeue();
            }
            else
            {
                _currentToken = null;
            }
            return _currentToken;
        }

        public void SkipToken(string token)
        {
            if (!token.Equals(_currentToken))
            {
                throw new System.FormatException();
            }
            NextToken();
        }

        public int CurrentNumber()
        {
            int number = 0;
            try
            {
                number = int.Parse(_currentToken);
            }
            catch (System.Exception)
            {
                throw;
            }
            return number;
        }
    }
}