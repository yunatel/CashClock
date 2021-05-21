using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashClock
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            currencyTextBox.Text = Settings1.Default.currency;
            wageTextBox.Text = Settings1.Default.wage.ToString();
            comboBox1.SelectedIndex = Settings1.Default.per;
            processesListBox.DisplayMember = "ProcessName";
            chosedProcessesListBox.DisplayMember = "ProcessName";
            chosedProcessesListBox.DataSource = MainForm.choosedProcessesName;
            //chosedProcessesListBox.Items.AddRange(Settings1.Default.choosedProcesses);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            refreshProcessCollections();
        }

        private void refreshProcessCollections()
        {
            this.processesListBox.Items.Clear();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process process in processes) {
                if (!this.processesListBox.Items.Contains(process.ProcessName))
                this.processesListBox.Items.Add(process.ProcessName);
                    }
        }

        private void currencyTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings1.Default.currency = this.currencyTextBox.Text;
        }

        private void wageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.wageTextBox.Text.Length > 0)
            {
                Settings1.Default.wage = double.Parse(this.wageTextBox.Text);
            }
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
                MainForm.choosedProcessesName.AddS(processesListBox.SelectedItem.ToString());
        }
        private void processesListBox_MouseDoubleClick(object sender, EventArgs e)
        {
                MainForm.choosedProcessesName.AddS(processesListBox.SelectedItem.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
                MainForm.choosedProcessesName.AddS(addByNameTextBox.Text.ToString());
        }

        private void deletoProcessButton_Click(object sender, EventArgs e)
        {
            MainForm.choosedProcessesName.RemoveAt(chosedProcessesListBox.SelectedIndex);
        }

        private void wageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void processesRefreshButton_Click(object sender, EventArgs e)
        {
            refreshProcessCollections();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings1.Default.per = comboBox1.SelectedIndex;
        }


    }
}
