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
        private MacroCommand _history = new MacroCommand();
        private Stack<ICommand> _oneStroke = new Stack<ICommand>();
        private bool _drag = false;

        public Form1()
        {
            InitializeComponent();
            drawCanvas.SetHistory(_history);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _history.Clear();
            drawCanvas.Invalidate();
        }

        private void drawCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
            _oneStroke.Clear();
        }

        private void drawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                ICommand cmd = new DrawCommand(drawCanvas, e.Location);
                _oneStroke.Push(cmd);
                cmd.Execute();
            }
        }

        private void drawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
            _history.Append(_oneStroke);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawCanvas.EraseCanvas();
            _history.Undo();
            _history.Execute();
        }
    }
}
