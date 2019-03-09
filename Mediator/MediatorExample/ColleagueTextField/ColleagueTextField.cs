using Mediator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColleagueTextField
{
    public partial class ColleagueTextField : TextBox, IColleague
    {
        private IMediator _mediator;

        public ColleagueTextField() : base()
        {
            InitializeComponent();
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (_mediator != null)
                _mediator.ColleagueChanged();
        }
    }
}
