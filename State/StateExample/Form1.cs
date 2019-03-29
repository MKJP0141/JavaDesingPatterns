using StateExample.Safe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateExample
{
    public class HourDto
    {
        public int Hour { get; set; }
    }

    public partial class Form1 : Form, IContext
    {
        private IState _state = NightState.Instance;

        public Form1()
        {
            InitializeComponent();
            RunTick();
        }

        public async void RunTick()
        {
            var progress = new Progress<HourDto>(SetHour);

            await Task.Run(() => Tick(progress));
        }

        private void SetHour(HourDto dto)
        {
            SetClock(dto.Hour);
        }

        public void Tick(IProgress<HourDto> progress)
        {
            for (int i = 0; i < 24; i++)
            {
                Thread.Sleep(1000);
                progress.Report(new HourDto
                {
                    Hour = i
                });

                if (i == 23)
                    i = 0;
            }
        }

        public void CallSecurityCenter(string msg)
        {
            outputListbox.Items.Add("call: " + msg + "\r\n");
        }

        public void ChangeState(IState state)
        {
            Console.WriteLine($"{this._state}から{state}へ状態が変化しました。");
            this._state = state;
        }

        public void RecordLog(string msg)
        {
            outputListbox.Items.Add("record ..." + msg + "\r\n");
        }

        public void SetClock(int hour)
        {
            string clockString = "現在時刻は";
            if (hour < 10)
            {
                clockString += "0" + hour + ":00";
            }
            else
            {
                clockString += hour + ":00";
            }
            Console.WriteLine(clockString);
            datetimeLabel.Text = clockString;
            _state.DoClock(this, hour);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useSafeButton_Click(object sender, EventArgs e)
        {
            _state.DoUse(this);
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            _state.DoAlarm(this);
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            _state.DoPhone(this);
        }
    }
}
