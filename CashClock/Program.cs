using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CashClock
{


    

    static class Program
    {
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

        private static bool IsProcessForegroundByName(string processName)
        {
            System.Diagnostics.Process foregroundProcess = GetActiveProcess();
            if (processName == foregroundProcess.ProcessName)
                return true;
            return false;
        }
        private static bool IsProcessForegroundByRange(string[] processesNames)
        {
            System.Diagnostics.Process foregroundProcess = GetActiveProcess();
            foreach (string processName in processesNames)
            {
                if (foregroundProcess.ProcessName == processName)
                    return true;
            }
            return false;
        }



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
