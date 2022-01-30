
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
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.igrac1Kontrola.SuspendLayout();
            this.igrac2Kontrola.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoundOnOff
            // 
            this.SoundOnOff.BackgroundImage = global::Bomberman.Properties.Resources.soundOff;
            this.SoundOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SoundOnOff.Location = new System.Drawing.Point(1001, 187);
            this.SoundOnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 135);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // igrac1Kontrola
            // 
            this.igrac1Kontrola.BackColor = System.Drawing.Color.Tomato;
            this.igrac1Kontrola.Controls.Add(this.label6);
            this.igrac1Kontrola.Controls.Add(this.label5);
            this.igrac1Kontrola.Controls.Add(this.label4);
            this.igrac1Kontrola.Controls.Add(this.label3);
            this.igrac1Kontrola.Controls.Add(this.label1);
            this.igrac1Kontrola.Controls.Add(this.player1Label);
            this.igrac1Kontrola.Controls.Add(this.B1);
            this.igrac1Kontrola.Controls.Add(this.R1);
            this.igrac1Kontrola.Controls.Add(this.D1);
            this.igrac1Kontrola.Controls.Add(this.L1);
            this.igrac1Kontrola.Controls.Add(this.U1);
            this.igrac1Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac1Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac1Kontrola.Location = new System.Drawing.Point(445, 409);
            this.igrac1Kontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.igrac1Kontrola.Name = "igrac1Kontrola";
            this.igrac1Kontrola.Size = new System.Drawing.Size(307, 281);
            this.igrac1Kontrola.TabIndex = 2;
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.B1.Location = new System.Drawing.Point(139, 221);
            this.B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B1.MaxLength = 1;
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(34, 34);
            this.B1.TabIndex = 4;
            this.B1.Text = "c";
            this.B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.B1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // R1
            // 
            this.R1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.R1.Location = new System.Drawing.Point(227, 148);
            this.R1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R1.MaxLength = 1;
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(34, 34);
            this.R1.TabIndex = 3;
            this.R1.Text = "d";
            this.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // D1
            // 
            this.D1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.D1.Location = new System.Drawing.Point(139, 148);
            this.D1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D1.MaxLength = 1;
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(34, 34);
            this.D1.TabIndex = 2;
            this.D1.Text = "s";
            this.D1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.D1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // L1
            // 
            this.L1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(48, 148);
            this.L1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.L1.MaxLength = 1;
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(34, 34);
            this.L1.TabIndex = 1;
            this.L1.Text = "a";
            this.L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.L1.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // U1
            // 
            this.U1.BackColor = System.Drawing.Color.White;
            this.U1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1.ForeColor = System.Drawing.Color.Black;
            this.U1.Location = new System.Drawing.Point(139, 77);
            this.U1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.U1.MaxLength = 1;
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(34, 34);
            this.U1.TabIndex = 0;
            this.U1.Text = "w";
            this.U1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.U1.TextChanged += new System.EventHandler(this.promjenaKontrole);
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
            this.controlsLabel.Location = new System.Drawing.Point(745, 274);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(258, 75);
            this.controlsLabel.TabIndex = 4;
            this.controlsLabel.Text = "Controls:";
            // 
            // igrac2Kontrola
            // 
            this.igrac2Kontrola.BackColor = System.Drawing.Color.Aqua;
            this.igrac2Kontrola.Controls.Add(this.label10);
            this.igrac2Kontrola.Controls.Add(this.label9);
            this.igrac2Kontrola.Controls.Add(this.label8);
            this.igrac2Kontrola.Controls.Add(this.label7);
            this.igrac2Kontrola.Controls.Add(this.label2);
            this.igrac2Kontrola.Controls.Add(this.player2Label);
            this.igrac2Kontrola.Controls.Add(this.B2);
            this.igrac2Kontrola.Controls.Add(this.R2);
            this.igrac2Kontrola.Controls.Add(this.D2);
            this.igrac2Kontrola.Controls.Add(this.L2);
            this.igrac2Kontrola.Controls.Add(this.U2);
            this.igrac2Kontrola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrac2Kontrola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.igrac2Kontrola.Location = new System.Drawing.Point(967, 409);
            this.igrac2Kontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.igrac2Kontrola.Name = "igrac2Kontrola";
            this.igrac2Kontrola.Size = new System.Drawing.Size(307, 281);
            this.igrac2Kontrola.TabIndex = 5;
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.B2.Location = new System.Drawing.Point(139, 221);
            this.B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B2.MaxLength = 1;
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(34, 34);
            this.B2.TabIndex = 4;
            this.B2.Text = "n";
            this.B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.B2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // R2
            // 
            this.R2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.R2.Location = new System.Drawing.Point(226, 148);
            this.R2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R2.MaxLength = 1;
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(34, 34);
            this.R2.TabIndex = 3;
            this.R2.Text = "l";
            this.R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // D2
            // 
            this.D2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.D2.Location = new System.Drawing.Point(139, 148);
            this.D2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D2.MaxLength = 1;
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(34, 34);
            this.D2.TabIndex = 2;
            this.D2.Text = "k";
            this.D2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.D2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // L2
            // 
            this.L2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.L2.Location = new System.Drawing.Point(51, 148);
            this.L2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.L2.MaxLength = 1;
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(34, 34);
            this.L2.TabIndex = 1;
            this.L2.Text = "j";
            this.L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.L2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // U2
            // 
            this.U2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F);
            this.U2.Location = new System.Drawing.Point(139, 77);
            this.U2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.U2.MaxLength = 1;
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(34, 34);
            this.U2.TabIndex = 0;
            this.U2.Text = "i";
            this.U2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.U2.TextChanged += new System.EventHandler(this.promjenaKontrole);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.Color.Black;
            this.player1Label.Location = new System.Drawing.Point(83, 10);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(162, 39);
            this.player1Label.TabIndex = 5;
            this.player1Label.Text = "PLAYER 1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.Color.Black;
            this.player2Label.Location = new System.Drawing.Point(82, 10);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(162, 39);
            this.player2Label.TabIndex = 6;
            this.player2Label.Text = "PLAYER 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(143, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "UP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "LEFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(126, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "DOWN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(223, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "RIGHT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(129, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "BOMB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(41, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "LEFT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(126, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "DOWN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(213, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "RIGHT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(126, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "BOMB";
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}