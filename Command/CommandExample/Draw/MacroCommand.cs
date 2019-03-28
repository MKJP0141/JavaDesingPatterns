using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample.Draw
{
    public class MacroCommand : ICommand
    {
        private Stack<Stack<ICommand>> _commands = new Stack<Stack<ICommand>>();

        public void Execute()
        {
            _commands.ForEach(item => item.ForEach(cmd => cmd.Execute()));
        }

        public void Append(Stack<ICommand> cmds)
        {
            _commands.Push(cmds);
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
