using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandExample.Draw;

namespace CommandExample
{
    public partial class DrawCanvas : UserControl, IDrawable
    {
        public DrawCanvas()
        {
            InitializeComponent();
        }

        private Color _color = Color.Red;
        private int _radius = 6;
        private MacroCommand _history = null;

        public void Draw(int x, int y)
        {
            using (Graphics g = CreateGraphics())
            using (Brush brush = new SolidBrush(_color))
            {
                g.FillEllipse(brush, x - _radius, y - _radius, _radius * 2, _radius * 2);
            }
        }

        public void SetHistory(MacroCommand history)
        {
            this._history = history;
        }

        public void EraseCanvas()
        {
            using (Graphics g = CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_history != null)
                _history.Execute();
        }
    }
}
