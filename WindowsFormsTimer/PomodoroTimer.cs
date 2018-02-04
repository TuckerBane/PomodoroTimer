using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimer
{
    public partial class PomodoroTimer : Form
    {
        private TimeSpan internalCurrentTime;
        private TimeSpan currentTime { get { return internalCurrentTime; }
                                       set {
                internalCurrentTime = value;
                if (TimeRemainingLabel != null)
                    TimeRemainingLabel.Text = internalCurrentTime.ToString("mm") + ":" + internalCurrentTime.ToString("ss");
            }
        }

        private TimeSpan[] seriesOfTimes;
        private int timeSeriesIndex = 0;
        private bool timerPaused = true;
        
        public PomodoroTimer()
        {
            TimeSpan work = new TimeSpan(0, 25, 0);
            TimeSpan shortBreak = new TimeSpan(0, 5, 0);
            TimeSpan longBreak = new TimeSpan(0, 15, 0);

            seriesOfTimes = new TimeSpan[] { work, shortBreak, work, shortBreak, work, shortBreak, work, longBreak };
            currentTime = seriesOfTimes[timeSeriesIndex];
            InitializeComponent();
        }

        private void StartButton_MouseUp(object sender, MouseEventArgs e)
        {
            TogglePause();
        }


        private void TogglePause()
        {
            timerPaused = !timerPaused;
            if (timerPaused)
                StartButton.Text = "Start";
            else
                StartButton.Text = "Pause";
        }

        private void TimeRemainingUpdater_Tick_1(object sender, EventArgs e)
        {
            if (timerPaused)
                return;
            Timer time = sender as Timer;
            currentTime -= new TimeSpan(0, 0, 0, 0, time.Interval * 100);

            if (currentTime.TotalMilliseconds <= 0)
            {
                TogglePause();
                if (timeSeriesIndex % 2 == 0) // working
                    MessageBox.Show("Take a break!", "Time's up!", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Back to work!", "Time's up!", MessageBoxButtons.OK);
                TogglePause();

                TimeSpan oldTime = currentTime;
                ++timeSeriesIndex;
                timeSeriesIndex %= seriesOfTimes.Length;
                currentTime = seriesOfTimes[timeSeriesIndex];
                // so we don't lose time in the transition
                currentTime += oldTime;
            }
        }

        private void RestartPattern_MouseUp(object sender, MouseEventArgs e)
        {
            timeSeriesIndex = 0;
            RestartRound_MouseUp(sender, e);
        }

        private void RestartRound_MouseUp(object sender, MouseEventArgs e)
        {
            currentTime = seriesOfTimes[timeSeriesIndex];
            if (!timerPaused)
                TogglePause();
        }
    }
}
