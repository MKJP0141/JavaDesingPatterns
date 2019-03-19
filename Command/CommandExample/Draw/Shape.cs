using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample.Draw
{
    public class Shape
    {
        public Point Location { get; set; }
        public float Width { get; set; }
        public Color Color { get; set; }
        public int ShapeNumber { get; set; }

        public Shape(Point location, float width, Color color, int shapeNumber)
        {
            Location = location;
            Width = width;
            Color = color;
            ShapeNumber = shapeNumber;
        }
    }
}
