using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample.Draw
{
    public class Shapes
    {
        private List<Shape> _shapes;

        public Shapes()
        {
            _shapes = new List<Shape>();
        }

        public int NumberOfShapes()
        {
            return _shapes.Count;
        }

        public void AddShape(Point location, float width, Color color, int shapeNumber)
        {
            _shapes.Add(new Shape(location, width, color, shapeNumber));
        }

        public Shape GetShape(int index)
        {
            return _shapes[index];
        }

        public void RemoveShape(Point location, float threshold)
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                if ((Math.Abs(location.X - _shapes[i].Location.X) < threshold) &&
                    (Math.Abs(location.Y = _shapes[i].Location.Y) < threshold))
                {
                    _shapes.RemoveAt(i);

                    for (int n = i; n < _shapes.Count; n++)
                    {
                        _shapes[n].ShapeNumber += 1;
                    }
                    i -= 1;
                }
            }
        }
    }
}
