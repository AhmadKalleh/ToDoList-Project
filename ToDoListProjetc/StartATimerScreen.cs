using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ToDoListProjetc
{
    public partial class StartATimerScreen : Form
    {
        public StartATimerScreen()
        {
            InitializeComponent();
        }

        TimeSpan dateTime = new TimeSpan(0, 0, 0);
        TimeSpan timeSpan = new TimeSpan(0, 0, 1);

        private void StartATimerScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddTask.Text != string.Empty && Convert.ToInt32(cbMintues.Value.ToString()) > 0)
            {
                
                dateTime = new TimeSpan(Convert.ToInt32(cbHour.Value.ToString()), Convert.ToInt32(cbMintues.Value.ToString()), 0);
                lbTime.Text = dateTime.Hours.ToString("D2") + ":" + dateTime.Minutes.ToString("D2") + ":" + dateTime.Seconds.ToString("D2");
                lbTask.Text = txtAddTask.Text.Trim().ToString();
                txtAddTask.Text = string.Empty;
                timer1.Start();
            }
            else if(txtAddTask.Text == string.Empty)
            {
                MessageBox.Show("Please Enter A Task","Warn",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(Convert.ToInt32(cbMintues.Value.ToString()) == 0)
            {
                MessageBox.Show("Please Choose a values for timer", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime = dateTime.Subtract(timeSpan);
            lbTime.Text = dateTime.Hours.ToString("D2") + ":" + dateTime.Minutes.ToString("D2") + ":" + dateTime.Seconds.ToString("D2");

            if(lbTime.Text.Equals("00:00:00"))
            {
                timer1.Stop();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Note";
                notifyIcon1.BalloonTipText = "Ended Time";
                notifyIcon1.ShowBalloonTip(1000);
                return;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Tag.Equals("Start"))
            {
                btnPause.Tag = "Stop";
                btnPause.Text = "Resume";
                timer1.Stop();
            }
            else
            {
                btnPause.Tag = "Start";
                btnPause.Text = "Pause";
                timer1.Start();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cbHour.Value = 0;
            cbMintues.Value = 0;
            lbTask.Text = string.Empty;
            lbTime.Text = "00:00:00";

        }
    }
}
