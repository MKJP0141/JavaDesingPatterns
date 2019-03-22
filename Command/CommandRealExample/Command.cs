using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealExample
{
    /// <summary>
    /// the 'Command' class
    /// </summary>
    abstract class Command
    {
        public abstract void Execute();

        public abstract void UnExecute();
    }
}
