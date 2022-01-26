
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
            this.Igrac1Gore = new System.Windows.Forms.TextBox();
            this.Igrac1Lijevo = new System.Windows.Forms.TextBox();
            this.Igrac1Dolje = new System.Windows.Forms.TextBox();
            this.Igrac1Desno = new System.Windows.Forms.TextBox();
            this.Igrac1Bomba = new System.Windows.Forms.TextBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.igrac2Kontrola = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.igrac1Kontrola.SuspendLayout();
            this.igrac2Kontrola.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoundOnOff
            // 
            this.SoundOnOff.BackgroundImage = global::Bomberman.Properties.Resources.soundOff;
            this.SoundOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundOnOff.Location = new System.Drawing.Point(1001, 187);
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
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(1408, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 136);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // igrac1Kontrola
            // 
            this.igrac1Kontrola.BackColor = System.Drawing.Color.Bisque;
            this.igrac1Kontrola.Controls.Add(this.Igrac1Bomba);
            this.igrac1Kontrola.Controls.Add(this.Igrac1Desno);
            this.igrac1Kontrola.Controls.Add(this.Igrac1Dolje);
            this.igrac1Kontrola.Controls.Add(this.Igrac1Lijevo);
            this.igrac1Kontrola.Controls.Add(this.Igrac1Gore);
            this.igrac1Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac1Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac1Kontrola.Location = new System.Drawing.Point(446, 408);
            this.igrac1Kontrola.Name = "igrac1Kontrola";
            this.igrac1Kontrola.Size = new System.Drawing.Size(307, 281);
            this.igrac1Kontrola.TabIndex = 2;
            // 
            // Igrac1Gore
            // 
            this.Igrac1Gore.Location = new System.Drawing.Point(138, 61);
            this.Igrac1Gore.MaxLength = 1;
            this.Igrac1Gore.Name = "Igrac1Gore";
            this.Igrac1Gore.Size = new System.Drawing.Size(24, 27);
            this.Igrac1Gore.TabIndex = 0;
            this.Igrac1Gore.Text = "w";
            this.Igrac1Gore.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // Igrac1Lijevo
            // 
            this.Igrac1Lijevo.Location = new System.Drawing.Point(51, 134);
            this.Igrac1Lijevo.MaxLength = 1;
            this.Igrac1Lijevo.Name = "Igrac1Lijevo";
            this.Igrac1Lijevo.Size = new System.Drawing.Size(24, 27);
            this.Igrac1Lijevo.TabIndex = 1;
            this.Igrac1Lijevo.Text = "a";
            this.Igrac1Lijevo.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // Igrac1Dolje
            // 
            this.Igrac1Dolje.Location = new System.Drawing.Point(138, 134);
            this.Igrac1Dolje.MaxLength = 1;
            this.Igrac1Dolje.Name = "Igrac1Dolje";
            this.Igrac1Dolje.Size = new System.Drawing.Size(24, 27);
            this.Igrac1Dolje.TabIndex = 2;
            this.Igrac1Dolje.Text = "s";
            this.Igrac1Dolje.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // Igrac1Desno
            // 
            this.Igrac1Desno.Location = new System.Drawing.Point(217, 134);
            this.Igrac1Desno.MaxLength = 1;
            this.Igrac1Desno.Name = "Igrac1Desno";
            this.Igrac1Desno.Size = new System.Drawing.Size(24, 27);
            this.Igrac1Desno.TabIndex = 3;
            this.Igrac1Desno.Text = "d";
            this.Igrac1Desno.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // Igrac1Bomba
            // 
            this.Igrac1Bomba.Location = new System.Drawing.Point(138, 204);
            this.Igrac1Bomba.MaxLength = 1;
            this.Igrac1Bomba.Name = "Igrac1Bomba";
            this.Igrac1Bomba.Size = new System.Drawing.Size(24, 27);
            this.Igrac1Bomba.TabIndex = 4;
            this.Igrac1Bomba.Text = "b";
            this.Igrac1Bomba.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.BackColor = System.Drawing.Color.Bisque;
            this.soundLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.ForeColor = System.Drawing.Color.Black;
            this.soundLabel.Location = new System.Drawing.Point(591, 175);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(374, 75);
            this.soundLabel.TabIndex = 3;
            this.soundLabel.Text = "Music on/off:";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.BackColor = System.Drawing.Color.Bisque;
            this.controlsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.Black;
            this.controlsLabel.Location = new System.Drawing.Point(745, 275);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(258, 75);
            this.controlsLabel.TabIndex = 4;
            this.controlsLabel.Text = "Controls:";
            // 
            // igrac2Kontrola
            // 
            this.igrac2Kontrola.BackColor = System.Drawing.Color.Bisque;
            this.igrac2Kontrola.Controls.Add(this.textBox1);
            this.igrac2Kontrola.Controls.Add(this.textBox2);
            this.igrac2Kontrola.Controls.Add(this.textBox3);
            this.igrac2Kontrola.Controls.Add(this.textBox4);
            this.igrac2Kontrola.Controls.Add(this.textBox5);
            this.igrac2Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac2Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac2Kontrola.Location = new System.Drawing.Point(967, 408);
            this.igrac2Kontrola.Name = "igrac2Kontrola";
            this.igrac2Kontrola.Size = new System.Drawing.Size(307, 281);
            this.igrac2Kontrola.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 204);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "m";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 134);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "j";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 134);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 27);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "h";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 134);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 27);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "g";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 61);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 27);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "z";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bomberman.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1600, 757);
            this.Controls.Add(this.igrac2Kontrola);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.soundLabel);
            this.Controls.Add(this.igrac1Kontrola);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SoundOnOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox Igrac1Bomba;
        private System.Windows.Forms.TextBox Igrac1Desno;
        private System.Windows.Forms.TextBox Igrac1Dolje;
        private System.Windows.Forms.TextBox Igrac1Lijevo;
        private System.Windows.Forms.TextBox Igrac1Gore;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Panel igrac2Kontrola;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}