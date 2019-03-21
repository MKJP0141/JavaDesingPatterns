using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample.Draw
{
    class DrawCommand : ICommand
    {
        protected internal IDrawable _drawable;

        private Point _position;

        public DrawCommand(IDrawable drawable, Point position)
        {
            _drawable = drawable;
            _position = position;
        }

        public void Execute()
        {
            _drawable.Draw(_position.X, _position.Y);
        }
    }
}
