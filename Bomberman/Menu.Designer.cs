
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
            this.naslov = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Ink Free", 65F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.naslov.ForeColor = System.Drawing.Color.Black;
            this.naslov.Location = new System.Drawing.Point(0, 0);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(764, 169);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Bomberman";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGameButton.AutoSize = true;
            this.newGameButton.Location = new System.Drawing.Point(50, 100);
            this.newGameButton.MaximumSize = new System.Drawing.Size(276, 81);
            this.newGameButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(276, 81);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlsButton.AutoSize = true;
            this.controlsButton.Location = new System.Drawing.Point(50, 200);
            this.controlsButton.MaximumSize = new System.Drawing.Size(276, 81);
            this.controlsButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(276, 81);
            this.controlsButton.TabIndex = 2;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(50, 400);
            this.exitButton.MaximumSize = new System.Drawing.Size(276, 81);
            this.exitButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 81);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreboardButton
            // 
            this.scoreboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreboardButton.AutoSize = true;
            this.scoreboardButton.Location = new System.Drawing.Point(50, 300);
            this.scoreboardButton.MaximumSize = new System.Drawing.Size(276, 81);
            this.scoreboardButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.scoreboardButton.Name = "scoreboardButton";
            this.scoreboardButton.Size = new System.Drawing.Size(276, 81);
            this.scoreboardButton.TabIndex = 4;
            this.scoreboardButton.Text = "Scoreboard";
            this.scoreboardButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.scoreboardButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.naslov);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button scoreboardButton;
    }
}