using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CashClock
{
    public partial class MainForm : Form
    {
        public static BindingList<string> choosedProcessesName = new BindingList<string>();
        private bool releaseStopwatch;


        private System.Diagnostics.Stopwatch stopWatch;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        public static System.Diagnostics.Process GetActiveProcess()
        {
            //http://www.blackwasp.co.uk/GetActiveProcess.aspx
            IntPtr hwnd = GetForegroundWindow();
            return hwnd != null ? GetProcessByHandle(hwnd) : null;
        }
        private static System.Diagnostics.Process GetProcessByHandle(IntPtr hwnd)
        {
            try
            {
                uint processID;
                GetWindowThreadProcessId(hwnd, out processID);
                return System.Diagnostics.Process.GetProcessById((int)processID);
            }
            catch { return null; }
        }

        SettingsForm settingsForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        { 
            settingsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopWatch = new System.Diagnostics.Stopwatch();
            settingsForm = new SettingsForm();
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

            // StopWatch Label
            this.stopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
            this.stopWatchLabel2.Text = string.Format("{0:fff}", stopWatch.Elapsed);



            // Money Label
            double money;
            this.wageInfoLabel.Text = string.Format("{0} {1} per ", Settings1.Default.wage, Settings1.Default.currency); // Wage information Label
            switch (Settings1.Default.per)
            {
                case 0:
                    money = double.Parse(stopWatch.Elapsed.TotalHours.ToString()) * Settings1.Default.wage;
                    this.moneyLabel.Text = string.Format("{0:f2} {1}", money, Settings1.Default.currency);
                    this.wageInfoLabel.Text += "hour";
                    break;
                case 1: 
                    money = double.Parse(stopWatch.Elapsed.TotalMinutes.ToString()) * Settings1.Default.wage;
                    this.moneyLabel.Text = string.Format("{0:f2} {1}", money, Settings1.Default.currency);
                    this.wageInfoLabel.Text += "minute";
                    break;
                case 2:
                    money = double.Parse(stopWatch.Elapsed.TotalSeconds.ToString()) * Settings1.Default.wage;
                    this.moneyLabel.Text = string.Format("{0:f2} {1}", money, Settings1.Default.currency);
                    this.wageInfoLabel.Text += "second";
                    break;
            }
            

            // Main mechanic
            if ((choosedProcessesName.Count > 0)&&releaseStopwatch)
            {
                if (choosedProcessesName.Contains(GetActiveProcess().ProcessName)
                    && !stopWatch.IsRunning)
                {
                    
                    stopWatch.Start();
                }
                else
                {
                    if (!choosedProcessesName.Contains(GetActiveProcess().ProcessName)
                        && stopWatch.IsRunning)
                        stopWatch.Stop();
                }
            }


            
        }

        // This is making form movable      [ https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable ]
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
