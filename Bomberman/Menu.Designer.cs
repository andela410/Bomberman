
namespace Bomberman
{
    partial class Menu
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.scoreboardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGameButton.AutoSize = true;
            this.newGameButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newGameButton.FlatAppearance.BorderSize = 2;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(12, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(383, 132);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlsButton.AutoSize = true;
            this.controlsButton.BackColor = System.Drawing.Color.Cyan;
            this.controlsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.controlsButton.FlatAppearance.BorderSize = 2;
            this.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsButton.Location = new System.Drawing.Point(12, 150);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(383, 132);
            this.controlsButton.TabIndex = 2;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = false;
            // 
            // scoreboardButton
            // 
            this.scoreboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreboardButton.AutoSize = true;
            this.scoreboardButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.scoreboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scoreboardButton.FlatAppearance.BorderSize = 2;
            this.scoreboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreboardButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F);
            this.scoreboardButton.Location = new System.Drawing.Point(12, 288);
            this.scoreboardButton.Name = "scoreboardButton";
            this.scoreboardButton.Size = new System.Drawing.Size(383, 132);
            this.scoreboardButton.TabIndex = 4;
            this.scoreboardButton.Text = "Scoreboard";
            this.scoreboardButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.MediumBlue;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F);
            this.exitButton.Location = new System.Drawing.Point(12, 426);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(383, 132);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // naslov
            // 
            this.naslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naslov.AutoSize = true;
            this.naslov.BackColor = System.Drawing.Color.Silver;
            this.naslov.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.naslov.FlatAppearance.BorderSize = 5;
            this.naslov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(401, 13);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(724, 133);
            this.naslov.TabIndex = 5;
            this.naslov.Text = "BOMBERMAN";
            this.naslov.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::Bomberman.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1090, 747);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.scoreboardButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "Menu";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button scoreboardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button naslov;
    }
}