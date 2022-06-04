using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GoToBed
{
    public partial class GoToBed : Form
    {

        private RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public System.Timers.Timer mainTimer;

        public Form sexerForm = null;

        private TimeSpan selectedTime;
        public TimeSpan selectedTimeProperty
        {
            get { return selectedTime; }
            set
            {
                selectedTime = value;
                DateTime nowTime = DateTime.UtcNow.ChangeTime(selectedTime.Hours, selectedTime.Minutes, selectedTime.Seconds, selectedTime.Milliseconds);
                currentTimeSet.Text = $"Current Time Set: {selectedTime.Hours.ToString("00")}:{selectedTime.Minutes.ToString("00")}";
            }
        }

        private bool alarmEnabled = false;
        public bool alarmEnabledProperty
        {
            get { return alarmEnabled; }
            set
            {
                alarmEnabled = value;
                enabledLabel.Text = alarmEnabled ? "Enabled" : "Disabled";
            }
        }

        private bool sexerEnabled = false;
        public bool sexerEnabledProperty
        {
            get { return sexerEnabled; }
            set
            {
                sexerEnabled = value;
                sexerBox.Checked = sexerEnabled;
            }
        }

        private bool runOnStartup = false;
        public bool runOnStartupProperty
        {
            get {  return runOnStartup; }
            set 
            { 
                runOnStartup = value;
                startupBox.Checked = runOnStartup;
            }
        }

        public bool alarmActivated = false;

        public GoToBed()
        {

            InitializeComponent();

            FormClosing += GoToBed_FormClosing;
            Shown += GoToBed_Shown;

            notifyIcon.MouseClick += notifyIcon_MouseClick;
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Visible = false;

        }

        private void GoToBed_Shown(Object sender, EventArgs e)
        {

            GoToBedData appData = XmlSaver.LoadData();
            if (appData != null)
            {
                selectedTimeProperty = TimeSpan.Parse(appData.preferredTime);
                alarmEnabledProperty = appData.preferredEnabled;
                sexerEnabledProperty = appData.preferredSexer;
                runOnStartupProperty = appData.runOnStartup;
            }

            GoToBedRoutines.InitializeSound();
            GoToBedRoutines.InitializeBackgroundWindow();

            mainTimer = new System.Timers.Timer(1000);
            mainTimer.Elapsed += MainTimer_Elapsed;
            mainTimer.Start();

        }


        private void MainTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (!alarmEnabled || alarmActivated) return;

            DateTime currentTime = DateTime.Now;

            if (currentTime.TimeOfDay.Hours == selectedTime.Hours && currentTime.TimeOfDay.Minutes == selectedTime.Minutes)
            {
                alarmActivated = true;
                GoToBedRoutines.goToBedPlayer.PlayLooping();
            }

        }

        [STAThread]
        private void BypassThreadIssue()
        {
            GoToBedRoutines.CreateSexerWindow(ref sexerForm);
            sexerForm.Show();
        }

        private void GoToBed_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon.Visible = true;
                Hide();
                e.Cancel = true;
            } 
            else
            {
                XmlSaver.SaveData(selectedTime, alarmEnabled, sexerEnabled, runOnStartup);
                notifyIcon.Visible = false;
                notifyIcon.Icon = null;
                notifyIcon.Dispose();     
                
                if(sexerForm != null)
                    GoToBedRoutines.DisposeSexer(ref sexerForm);
            }
            
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            notifyIcon.Visible = false;
            Show();
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            selectedTime = dateTimePicker.Value.TimeOfDay;
            currentTimeSet.Text = $"Current Time Set: {selectedTime.Hours.ToString("00")}:{selectedTime.Minutes.ToString("00")}";
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            alarmEnabledProperty = true;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            if(alarmActivated)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to disable this alarm, or should you just go to bed?", "Really?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    alarmEnabledProperty = false;
                    alarmActivated = false;
                    GoToBedRoutines.goToBedPlayer.Stop();
                }
            } else
            {
                alarmEnabledProperty = false;
            }
        }

        private void sexerBox_CheckedChanged(object sender, EventArgs e)
        {
            sexerEnabledProperty = sexerBox.Checked;
            if(!sexerBox.Checked) 
            { 
                if(sexerForm != null)
                {
                    GoToBedRoutines.DisposeSexer(ref sexerForm);
                }
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startupBox_CheckedChanged(object sender, EventArgs e)
        {
            runOnStartupProperty = startupBox.Checked;
            if(startupBox.Checked)
            {
                startupKey.SetValue("GoToBedApp", Application.ExecutablePath);
            } else
            {
                startupKey.DeleteValue("GoToBedApp", false);
            }
        }

    }

}