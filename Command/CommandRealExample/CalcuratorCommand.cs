using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealExample
{
    /// <summary>
    /// the 'ConcreateCommand' class
    /// </summary>
    class CalcuratorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calcurator;

        public CalcuratorCommand(Calculator calculator, char @operator, int operand)
        {
            _calcurator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            set { _operator = value; }
        }

        public override void Execute()
        {
            _calcurator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calcurator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
