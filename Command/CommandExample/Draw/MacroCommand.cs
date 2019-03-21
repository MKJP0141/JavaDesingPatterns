using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample.Draw
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void Execute()
        {
            _commands.ForEach(cmd => cmd.Execute());
        }

        public void Append(ICommand cmd)
        {
            if (cmd != this)
            {
                _commands.Push(cmd);
            }
        }

        public void Undo()
        {
            if (!(_commands.Count == 0))
            {
                _commands.Pop();
            }
        }

        public void Clear()
        {
            _commands.Clear();
        }
    }
}
