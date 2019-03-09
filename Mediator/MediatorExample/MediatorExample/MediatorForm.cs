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

namespace MediatorExample
{
    public partial class MediatorForm : Form, IMediator
    {
        public MediatorForm()
        {
            InitializeComponent();
            CreateColleagues();
            ColleagueChanged();
        }

        public void CreateColleagues()
        {
            guestRadioButton.SetMediator(this);
            userRadioButton.SetMediator(this);
            usernameTextBox.SetMediator(this);
            passwordTextBox.SetMediator(this);
            okButton.SetMediator(this);
        }

        public void ColleagueChanged()
        {
            if (guestRadioButton.Checked)
            {
                usernameTextBox.SetColleagueEnabled(false);
                passwordTextBox.SetColleagueEnabled(false);
                okButton.SetColleagueEnabled(true);
            }
            else
            {
                usernameTextBox.SetColleagueEnabled(true);
                UserPassChanged();
            }
        }

        private void UserPassChanged()
        {
            if (usernameTextBox.Text.Length > 0)
            {
                passwordTextBox.SetColleagueEnabled(true);
                if (passwordTextBox.Text.Length > 0)
                {
                    okButton.SetColleagueEnabled(true);
                }
                else
                {
                    okButton.SetColleagueEnabled(false);
                }
            }
            else
            {
                passwordTextBox.SetColleagueEnabled(false);
                okButton.SetColleagueEnabled(false);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{sender}:{e.ToString()}");
            Close();
        }
    }
}
