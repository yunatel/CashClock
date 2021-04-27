using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashClock
{
    
    public partial class MainForm : Form
    {
        public static BindingList<string> choosedProcessesName = new BindingList<string>();
        private bool releaseStopwatch;

        private System.Diagnostics.Stopwatch stopWatch;

        public MainForm()
        {
            InitializeComponent();

        }

        SettingsForm settingsForm;

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopWatch = new System.Diagnostics.Stopwatch();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            releaseStopwatch = true;
            if (choosedProcessesName.Count > 0)
            {
                StartButton.Text= "Monitoring";
                StartButton.Enabled = false;

            }
            this.stopWatch.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            releaseStopwatch = false;
            StartButton.Text = "Start";
            StartButton.Enabled = true;
            this.stopWatch.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.stopWatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.stopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
            this.stopWatchLabel2.Text = string.Format("{0:fff}", stopWatch.Elapsed);
            double money = double.Parse(stopWatch.Elapsed.TotalHours.ToString()) * Settings1.Default.wage;
            this.moneyLabel.Text = string.Format("{0:f2} {1}", money, Settings1.Default.currency);
            //this.stopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);

            if ((choosedProcessesName.Count > 0)&&releaseStopwatch)
            {
                if (choosedProcessesName.Contains(Program.GetActiveProcess().ProcessName)
                    && !stopWatch.IsRunning)
                {
                    
                    stopWatch.Start();
                }
                else
                {
                    if (!choosedProcessesName.Contains(Program.GetActiveProcess().ProcessName)
                        && stopWatch.IsRunning)
                        stopWatch.Stop();
                }
            }
        }
    }
}
