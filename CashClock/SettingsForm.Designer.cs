
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
            this.label2 = new System.Windows.Forms.Label();
            this.addByNameButton = new System.Windows.Forms.Button();
            this.addByNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(12, 31);
            this.currencyTextBox.MaxLength = 3;
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(46, 23);
            this.currencyTextBox.TabIndex = 0;
            this.currencyTextBox.TextChanged += new System.EventHandler(this.currencyTextBox_TextChanged);
            // 
            // wageTextBox
            // 
            this.wageTextBox.Location = new System.Drawing.Point(65, 31);
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
            this.comboBox1.Location = new System.Drawing.Point(254, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.perLabel.Location = new System.Drawing.Point(223, 34);
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
            this.processesListBox.Size = new System.Drawing.Size(206, 199);
            this.processesListBox.TabIndex = 4;
            this.processesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processesListBox_MouseDoubleClick);
            // 
            // labelProcesses
            // 
            this.labelProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelProcesses.Location = new System.Drawing.Point(3, 0);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(94, 15);
            this.labelProcesses.TabIndex = 5;
            this.labelProcesses.Text = "Active processes";
            // 
            // processesRefreshButton
            // 
            this.processesRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processesRefreshButton.Location = new System.Drawing.Point(3, 239);
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
            this.labelChosedProcesses.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.chosedProcessesListBox.Size = new System.Drawing.Size(214, 244);
            this.chosedProcessesListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose processes to monitor";
            // 
            // addProcessButton
            // 
            this.addProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProcessButton.Location = new System.Drawing.Point(134, 239);
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
            this.deleteProcessButton.Location = new System.Drawing.Point(142, 291);
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
            this.splitContainer1.Location = new System.Drawing.Point(12, 92);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.addByNameButton);
            this.splitContainer1.Panel1.Controls.Add(this.addByNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.processesRefreshButton);
            this.splitContainer1.Panel1.Controls.Add(this.addProcessButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelProcesses);
            this.splitContainer1.Panel1.Controls.Add(this.processesListBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 161;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deleteProcessButton);
            this.splitContainer1.Panel2.Controls.Add(this.chosedProcessesListBox);
            this.splitContainer1.Panel2.Controls.Add(this.labelChosedProcesses);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2MinSize = 161;
            this.splitContainer1.Size = new System.Drawing.Size(436, 317);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add by name";
            // 
            // addByNameButton
            // 
            this.addByNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addByNameButton.Location = new System.Drawing.Point(134, 291);
            this.addByNameButton.Name = "addByNameButton";
            this.addByNameButton.Size = new System.Drawing.Size(75, 23);
            this.addByNameButton.TabIndex = 12;
            this.addByNameButton.Text = "Add";
            this.addByNameButton.UseVisualStyleBackColor = true;
            this.addByNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addByNameTextBox
            // 
            this.addByNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addByNameTextBox.Location = new System.Drawing.Point(3, 291);
            this.addByNameTextBox.Name = "addByNameTextBox";
            this.addByNameTextBox.Size = new System.Drawing.Size(125, 23);
            this.addByNameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set your wage";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(456, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wageTextBox);
            this.Controls.Add(this.currencyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(363, 317);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addByNameButton;
        private System.Windows.Forms.TextBox addByNameTextBox;
    }
}