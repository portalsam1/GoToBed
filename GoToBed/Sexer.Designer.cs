namespace GoToBed
{
    partial class Sexer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sexer));
            this.sexerPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.sexerPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // sexerPlayer
            // 
            this.sexerPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sexerPlayer.Enabled = true;
            this.sexerPlayer.Location = new System.Drawing.Point(0, 0);
            this.sexerPlayer.Name = "sexerPlayer";
            this.sexerPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sexerPlayer.OcxState")));
            this.sexerPlayer.Size = new System.Drawing.Size(800, 450);
            this.sexerPlayer.TabIndex = 0;
            this.sexerPlayer.Enter += new System.EventHandler(this.sexerPlayer_Enter);
            // 
            // Sexer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexerPlayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sexer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sexer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.sexerPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer sexerPlayer;
    }
}