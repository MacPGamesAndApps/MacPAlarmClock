using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacPWindowsSoundControl;

namespace MacPAlarmClock
{
    public partial class frmClock : Form
    {
        SoundPlayer alarmSound = null;
        MacPVolumeControl macPVolumenControl = null;
        bool alarmStarted = false;

        public frmClock()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            dtpAlarm.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 59, 0);
            lblAlarmTime.Text = dtpAlarm.Value.ToString("HH:mm");
        }

        private void frmClock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                this.Left-=10;
            }
            if (e.KeyCode == Keys.Right)
            {
                this.Left+=10;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.Top-=10;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.Top+=10;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime alarmTime = dtpAlarm.Value;
            lblTime.Text = currentTime.ToString("HH:mm:ss");
            if (picAlarmOn.Visible)
            {
                if (!alarmStarted)
                {
                    if (currentTime >= alarmTime)
                    {
                        alarmStarted = true;
                        this.WindowState = FormWindowState.Normal;
                        picFireworks.Visible = true;
                        alarmSound = new SoundPlayer("Sounds\\Alarm-1.wav");
                        alarmSound.PlayLooping();
                    }
                }
            }
        }

        private void picAlarmOff_Click(object sender, EventArgs e)
        {
            picAlarmOn.Visible = true;
            picAlarmOff.Visible = false;
            picAlarmIcon.Visible = true;
            SetAlarm();
        }

        private void picAlarmOn_Click(object sender, EventArgs e)
        {
            picAlarmOff.Visible = true;
            picAlarmOn.Visible = false;
            picAlarmIcon.Visible = false;
            picFireworks.Visible = false;
            alarmStarted = false;
            if(alarmSound != null)
            {
                alarmSound.Stop();
            }
        }

        private void lblAlarmTime_Click(object sender, EventArgs e)
        {
            lblAlarmTime.Visible = false;
            if (!dtpAlarm.Value.Date.Equals(DateTime.Now))
            {
                DateTime currentDate = DateTime.Now;
                dtpAlarm.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, dtpAlarm.Value.Hour, dtpAlarm.Value.Minute, dtpAlarm.Value.Second);
            }
            dtpAlarm.Visible = true;
            dtpAlarm.Focus();
        }

        private void dtpAlarm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SetAlarm();
            }
        }

        private void SetAlarm()
        {
            lblAlarmTime.Text = dtpAlarm.Value.ToString("HH:mm");
            dtpAlarm.Visible = false;
            lblAlarmTime.Visible = true;
        }

        private void picVolumeOff_Click(object sender, EventArgs e)
        {
            picVolumeOn.Visible = true;
            picVolumeOff.Visible = false;
            macPVolumenControl = new MacPVolumeControl(this.Handle);
            macPVolumenControl.TurnVolumeUp(15);
        }

        private void picVolumeOn_Click(object sender, EventArgs e)
        {
            picVolumeOff.Visible = true;
            picVolumeOn.Visible = false;
            macPVolumenControl.TurnVolumeDown(15);
        }
    }
}
