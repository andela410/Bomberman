
namespace Bomberman
{
    partial class ScoreboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreboardForm));
            this.backButton = new System.Windows.Forms.Button();
            this.gameTypeBox = new System.Windows.Forms.ComboBox();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Bomberman.Properties.Resources.Back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(1407, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 135);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gameTypeBox
            // 
            this.gameTypeBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.gameTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameTypeBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTypeBox.FormattingEnabled = true;
            this.gameTypeBox.Items.AddRange(new object[] {
            "Campaign",
            "Singleplayer",
            "Multiplayer"});
            this.gameTypeBox.Location = new System.Drawing.Point(178, 164);
            this.gameTypeBox.MaxDropDownItems = 3;
            this.gameTypeBox.Name = "gameTypeBox";
            this.gameTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameTypeBox.Size = new System.Drawing.Size(164, 37);
            this.gameTypeBox.TabIndex = 3;
            this.gameTypeBox.SelectedIndexChanged += new System.EventHandler(this.updateGameTypeForTable);
            // 
            // levelBox
            // 
            this.levelBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.levelBox.Location = new System.Drawing.Point(393, 164);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(121, 37);
            this.levelBox.TabIndex = 4;
            this.levelBox.SelectedIndexChanged += new System.EventHandler(this.changeTable);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.GridColor = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(540, 239);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 1000);
            this.grid.TabIndex = 5;
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bomberman.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1604, 761);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.gameTypeBox);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreboardForm";
            this.Text = "Bomberman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox gameTypeBox;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox levelBox;
    }
}