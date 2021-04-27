
namespace CashClock
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.wageTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perLabel = new System.Windows.Forms.Label();
            this.processesListBox = new System.Windows.Forms.ListBox();
            this.labelProcesses = new System.Windows.Forms.Label();
            this.processesRefreshButton = new System.Windows.Forms.Button();
            this.labelChosedProcesses = new System.Windows.Forms.Label();
            this.chosedProcessesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProcessButton = new System.Windows.Forms.Button();
            this.deleteProcessButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(12, 12);
            this.currencyTextBox.MaxLength = 3;
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(46, 23);
            this.currencyTextBox.TabIndex = 0;
            this.currencyTextBox.TextChanged += new System.EventHandler(this.currencyTextBox_TextChanged);
            // 
            // wageTextBox
            // 
            this.wageTextBox.Location = new System.Drawing.Point(65, 12);
            this.wageTextBox.Name = "wageTextBox";
            this.wageTextBox.Size = new System.Drawing.Size(152, 23);
            this.wageTextBox.TabIndex = 1;
            this.wageTextBox.TextChanged += new System.EventHandler(this.wageTextBox_TextChanged);
            this.wageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wageTextBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hour",
            "minute",
            "second"});
            this.comboBox1.Location = new System.Drawing.Point(254, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.Location = new System.Drawing.Point(223, 15);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(24, 15);
            this.perLabel.TabIndex = 3;
            this.perLabel.Text = "per";
            // 
            // processesListBox
            // 
            this.processesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processesListBox.FormattingEnabled = true;
            this.processesListBox.ItemHeight = 15;
            this.processesListBox.Location = new System.Drawing.Point(3, 18);
            this.processesListBox.Name = "processesListBox";
            this.processesListBox.Size = new System.Drawing.Size(158, 139);
            this.processesListBox.TabIndex = 4;
            this.processesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processesListBox_MouseDoubleClick);
            // 
            // labelProcesses
            // 
            this.labelProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.Location = new System.Drawing.Point(3, 0);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(58, 15);
            this.labelProcesses.TabIndex = 5;
            this.labelProcesses.Text = "Processes";
            // 
            // processesRefreshButton
            // 
            this.processesRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processesRefreshButton.Location = new System.Drawing.Point(3, 176);
            this.processesRefreshButton.Name = "processesRefreshButton";
            this.processesRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.processesRefreshButton.TabIndex = 6;
            this.processesRefreshButton.Text = "Refresh";
            this.processesRefreshButton.UseVisualStyleBackColor = true;
            this.processesRefreshButton.Click += new System.EventHandler(this.processesRefreshButton_Click);
            // 
            // labelChosedProcesses
            // 
            this.labelChosedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChosedProcesses.AutoSize = true;
            this.labelChosedProcesses.Location = new System.Drawing.Point(3, 0);
            this.labelChosedProcesses.Name = "labelChosedProcesses";
            this.labelChosedProcesses.Size = new System.Drawing.Size(101, 15);
            this.labelChosedProcesses.TabIndex = 8;
            this.labelChosedProcesses.Text = "Chosed processes";
            // 
            // chosedProcessesListBox
            // 
            this.chosedProcessesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chosedProcessesListBox.FormattingEnabled = true;
            this.chosedProcessesListBox.ItemHeight = 15;
            this.chosedProcessesListBox.Location = new System.Drawing.Point(3, 18);
            this.chosedProcessesListBox.Name = "chosedProcessesListBox";
            this.chosedProcessesListBox.Size = new System.Drawing.Size(155, 139);
            this.chosedProcessesListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose processes to monitor";
            // 
            // addProcessButton
            // 
            this.addProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProcessButton.Location = new System.Drawing.Point(86, 176);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(75, 23);
            this.addProcessButton.TabIndex = 10;
            this.addProcessButton.Text = "Add";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            // 
            // deleteProcessButton
            // 
            this.deleteProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProcessButton.Location = new System.Drawing.Point(83, 176);
            this.deleteProcessButton.Name = "deleteProcessButton";
            this.deleteProcessButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProcessButton.TabIndex = 11;
            this.deleteProcessButton.Text = "Delete";
            this.deleteProcessButton.UseVisualStyleBackColor = true;
            this.deleteProcessButton.Click += new System.EventHandler(this.deletoProcessButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.processesRefreshButton);
            this.splitContainer1.Panel1.Controls.Add(this.addProcessButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelProcesses);
            this.splitContainer1.Panel1.Controls.Add(this.processesListBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deleteProcessButton);
            this.splitContainer1.Panel2.Controls.Add(this.chosedProcessesListBox);
            this.splitContainer1.Panel2.Controls.Add(this.labelChosedProcesses);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(329, 202);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wageTextBox);
            this.Controls.Add(this.currencyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox wageTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label perLabel;
        private System.Windows.Forms.ListBox processesListBox;
        private System.Windows.Forms.Label labelProcesses;
        private System.Windows.Forms.Button processesRefreshButton;
        private System.Windows.Forms.Label labelChosedProcesses;
        private System.Windows.Forms.ListBox chosedProcessesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.Button deleteProcessButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}