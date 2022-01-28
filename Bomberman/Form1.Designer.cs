namespace Bomberman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeGame
            // 
            this.closeGame.BackColor = System.Drawing.Color.Transparent;
            this.closeGame.BackgroundImage = global::Bomberman.Properties.Resources.FireExit1;
            this.closeGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeGame.Location = new System.Drawing.Point(987, 1);
            this.closeGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(109, 58);
            this.closeGame.TabIndex = 1;
            this.closeGame.UseVisualStyleBackColor = false;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1197, 612);
            this.Controls.Add(this.closeGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bomberman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeGame;
    }
}

