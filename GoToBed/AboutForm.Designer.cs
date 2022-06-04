namespace GoToBed
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutText = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(13, 13);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(68, 25);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "About";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 8);
            this.panel1.TabIndex = 1;
            // 
            // aboutText
            // 
            this.aboutText.AutoSize = true;
            this.aboutText.Location = new System.Drawing.Point(12, 53);
            this.aboutText.MaximumSize = new System.Drawing.Size(280, 126);
            this.aboutText.MinimumSize = new System.Drawing.Size(280, 126);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(280, 126);
            this.aboutText.TabIndex = 2;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            this.aboutText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.credit.Location = new System.Drawing.Point(222, 179);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(70, 13);
            this.credit.TabIndex = 3;
            this.credit.Text = "By portalsam.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.Label credit;
    }
}