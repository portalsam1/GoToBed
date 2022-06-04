namespace GoToBed
{
    partial class GoToBed
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToBed));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleText = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.sexerBox = new System.Windows.Forms.CheckBox();
            this.currentTimeSet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enabledLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startupBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // subtitleText
            // 
            resources.ApplyResources(this.subtitleText, "subtitleText");
            this.subtitleText.Name = "subtitleText";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // setTimeButton
            // 
            resources.ApplyResources(this.setTimeButton, "setTimeButton");
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // enableButton
            // 
            resources.ApplyResources(this.enableButton, "enableButton");
            this.enableButton.Name = "enableButton";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            resources.ApplyResources(this.disableButton, "disableButton");
            this.disableButton.Name = "disableButton";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // sexerBox
            // 
            resources.ApplyResources(this.sexerBox, "sexerBox");
            this.sexerBox.Name = "sexerBox";
            this.sexerBox.UseVisualStyleBackColor = true;
            this.sexerBox.CheckedChanged += new System.EventHandler(this.sexerBox_CheckedChanged);
            // 
            // currentTimeSet
            // 
            resources.ApplyResources(this.currentTimeSet, "currentTimeSet");
            this.currentTimeSet.Name = "currentTimeSet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // enabledLabel
            // 
            resources.ApplyResources(this.enabledLabel, "enabledLabel");
            this.enabledLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enabledLabel.Name = "enabledLabel";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // startupBox
            // 
            resources.ApplyResources(this.startupBox, "startupBox");
            this.startupBox.Name = "startupBox";
            this.startupBox.UseVisualStyleBackColor = true;
            this.startupBox.CheckedChanged += new System.EventHandler(this.startupBox_CheckedChanged);
            // 
            // GoToBed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startupBox);
            this.Controls.Add(this.enabledLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentTimeSet);
            this.Controls.Add(this.sexerBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.setTimeButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.subtitleText);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GoToBed";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button setTimeButton;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox sexerBox;
        private System.Windows.Forms.Label currentTimeSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enabledLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.CheckBox startupBox;
    }
}

