
namespace Bomberman
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.SoundOnOff = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoundOnOff
            // 
            this.SoundOnOff.BackgroundImage = global::Bomberman.Properties.Resources.soundOff;
            this.SoundOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundOnOff.Location = new System.Drawing.Point(561, 145);
            this.SoundOnOff.Name = "SoundOnOff";
            this.SoundOnOff.Size = new System.Drawing.Size(73, 63);
            this.SoundOnOff.TabIndex = 0;
            this.SoundOnOff.Tag = "on";
            this.SoundOnOff.UseMnemonic = false;
            this.SoundOnOff.UseVisualStyleBackColor = true;
            this.SoundOnOff.Click += new System.EventHandler(this.SoundOnOff_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Bomberman.Properties.Resources.Back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Location = new System.Drawing.Point(1404, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 136);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bomberman.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1600, 757);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SoundOnOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Bomberman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoundOnOff;
        private System.Windows.Forms.Button backButton;
    }
}