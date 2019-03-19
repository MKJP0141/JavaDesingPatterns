using CommandExample.Draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandExample
{
    public partial class Form1 : Form
    {
        private Shapes _shapes = new Shapes();
        private bool _isPainting = false;
        private Point _lastPos = new Point();
        private Color _currentColor = Color.Black;
        private float _currentWidth = 10;
        private int _shapeNumber = 0;

        public Form1()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
            paintPanel.GetType().GetMethod("SetStyle",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic).Invoke(paintPanel,
                new object[] { ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true });
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _isPainting = true;
            _shapeNumber++;
            _lastPos = new Point(0, 0);
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isPainting)
            {
                if (_lastPos != e.Location)
                {
                    _lastPos = e.Location;
                    _shapes.AddShape(_lastPos, _currentWidth, _currentColor, _shapeNumber);
                }
            }
            paintPanel.Refresh();
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isPainting)
            {
                _isPainting = false;
            }
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            for (int i = 0; i < _shapes.NumberOfShapes() - 1; i++)
            {
                var T = _shapes.GetShape(i);
                var T1 = _shapes.GetShape(i + 1);
                if (T.ShapeNumber == T1.ShapeNumber)
                {
                    Pen pen = new Pen(T.Color, T.Width);
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    e.Graphics.DrawLine(pen, T.Location, T1.Location);
                    pen.Dispose();
                }
            }
        }
    }
}
