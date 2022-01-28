
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
            this.igrac1Kontrola = new System.Windows.Forms.Panel();
            this.B1 = new System.Windows.Forms.TextBox();
            this.R1 = new System.Windows.Forms.TextBox();
            this.D1 = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.TextBox();
            this.U1 = new System.Windows.Forms.TextBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.igrac2Kontrola = new System.Windows.Forms.Panel();
            this.B2 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.D2 = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.TextBox();
            this.U2 = new System.Windows.Forms.TextBox();
            this.igrac1Kontrola.SuspendLayout();
            this.igrac2Kontrola.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoundOnOff
            // 
            this.SoundOnOff.BackgroundImage = global::Bomberman.Properties.Resources.soundOff;
            this.SoundOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundOnOff.Location = new System.Drawing.Point(751, 152);
            this.SoundOnOff.Margin = new System.Windows.Forms.Padding(2);
            this.SoundOnOff.Name = "SoundOnOff";
            this.SoundOnOff.Size = new System.Drawing.Size(55, 51);
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
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(1056, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 110);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // igrac1Kontrola
            // 
            this.igrac1Kontrola.BackColor = System.Drawing.Color.Bisque;
            this.igrac1Kontrola.Controls.Add(this.B1);
            this.igrac1Kontrola.Controls.Add(this.R1);
            this.igrac1Kontrola.Controls.Add(this.D1);
            this.igrac1Kontrola.Controls.Add(this.L1);
            this.igrac1Kontrola.Controls.Add(this.U1);
            this.igrac1Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac1Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac1Kontrola.Location = new System.Drawing.Point(334, 332);
            this.igrac1Kontrola.Margin = new System.Windows.Forms.Padding(2);
            this.igrac1Kontrola.Name = "igrac1Kontrola";
            this.igrac1Kontrola.Size = new System.Drawing.Size(230, 228);
            this.igrac1Kontrola.TabIndex = 2;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(104, 166);
            this.B1.Margin = new System.Windows.Forms.Padding(2);
            this.B1.MaxLength = 1;
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(19, 23);
            this.B1.TabIndex = 4;
            this.B1.Text = "c";
            this.B1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(163, 109);
            this.R1.Margin = new System.Windows.Forms.Padding(2);
            this.R1.MaxLength = 1;
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(19, 23);
            this.R1.TabIndex = 3;
            this.R1.Text = "d";
            this.R1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(104, 109);
            this.D1.Margin = new System.Windows.Forms.Padding(2);
            this.D1.MaxLength = 1;
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(19, 23);
            this.D1.TabIndex = 2;
            this.D1.Text = "s";
            this.D1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // L1
            // 
            this.L1.Location = new System.Drawing.Point(38, 109);
            this.L1.Margin = new System.Windows.Forms.Padding(2);
            this.L1.MaxLength = 1;
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(19, 23);
            this.L1.TabIndex = 1;
            this.L1.Text = "a";
            this.L1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // U1
            // 
            this.U1.Location = new System.Drawing.Point(104, 50);
            this.U1.Margin = new System.Windows.Forms.Padding(2);
            this.U1.MaxLength = 1;
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(19, 23);
            this.U1.TabIndex = 0;
            this.U1.Text = "w";
            this.U1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.BackColor = System.Drawing.Color.Bisque;
            this.soundLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.ForeColor = System.Drawing.Color.Black;
            this.soundLabel.Location = new System.Drawing.Point(443, 142);
            this.soundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(300, 61);
            this.soundLabel.TabIndex = 3;
            this.soundLabel.Text = "Music on/off:";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.BackColor = System.Drawing.Color.Bisque;
            this.controlsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.Black;
            this.controlsLabel.Location = new System.Drawing.Point(559, 223);
            this.controlsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(208, 61);
            this.controlsLabel.TabIndex = 4;
            this.controlsLabel.Text = "Controls:";
            // 
            // igrac2Kontrola
            // 
            this.igrac2Kontrola.BackColor = System.Drawing.Color.Bisque;
            this.igrac2Kontrola.Controls.Add(this.B2);
            this.igrac2Kontrola.Controls.Add(this.R2);
            this.igrac2Kontrola.Controls.Add(this.D2);
            this.igrac2Kontrola.Controls.Add(this.L2);
            this.igrac2Kontrola.Controls.Add(this.U2);
            this.igrac2Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac2Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac2Kontrola.Location = new System.Drawing.Point(725, 332);
            this.igrac2Kontrola.Margin = new System.Windows.Forms.Padding(2);
            this.igrac2Kontrola.Name = "igrac2Kontrola";
            this.igrac2Kontrola.Size = new System.Drawing.Size(230, 228);
            this.igrac2Kontrola.TabIndex = 5;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(104, 166);
            this.B2.Margin = new System.Windows.Forms.Padding(2);
            this.B2.MaxLength = 1;
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(19, 23);
            this.B2.TabIndex = 4;
            this.B2.Text = "n";
            this.B2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(163, 109);
            this.R2.Margin = new System.Windows.Forms.Padding(2);
            this.R2.MaxLength = 1;
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(19, 23);
            this.R2.TabIndex = 3;
            this.R2.Text = "l";
            this.R2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(104, 109);
            this.D2.Margin = new System.Windows.Forms.Padding(2);
            this.D2.MaxLength = 1;
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(19, 23);
            this.D2.TabIndex = 2;
            this.D2.Text = "k";
            this.D2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // L2
            // 
            this.L2.Location = new System.Drawing.Point(38, 109);
            this.L2.Margin = new System.Windows.Forms.Padding(2);
            this.L2.MaxLength = 1;
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(19, 23);
            this.L2.TabIndex = 1;
            this.L2.Text = "j";
            this.L2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // U2
            // 
            this.U2.Location = new System.Drawing.Point(104, 50);
            this.U2.Margin = new System.Windows.Forms.Padding(2);
            this.U2.MaxLength = 1;
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(19, 23);
            this.U2.TabIndex = 0;
            this.U2.Text = "i";
            this.U2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bomberman.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.igrac2Kontrola);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.soundLabel);
            this.Controls.Add(this.igrac1Kontrola);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SoundOnOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.Text = "Bomberman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.igrac1Kontrola.ResumeLayout(false);
            this.igrac1Kontrola.PerformLayout();
            this.igrac2Kontrola.ResumeLayout(false);
            this.igrac2Kontrola.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SoundOnOff;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel igrac1Kontrola;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.TextBox L1;
        private System.Windows.Forms.TextBox U1;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Panel igrac2Kontrola;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.TextBox D2;
        private System.Windows.Forms.TextBox L2;
        private System.Windows.Forms.TextBox U2;
    }
}