namespace Galactic_Vagabond
{
    partial class launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcher));
            this.NewGame = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.NewGame.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.LawnGreen;
            this.NewGame.Location = new System.Drawing.Point(73, 140);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(63, 59);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // LoadGame
            // 
            this.LoadGame.BackColor = System.Drawing.Color.Transparent;
            this.LoadGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.LoadGame.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.LoadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGame.ForeColor = System.Drawing.Color.Chartreuse;
            this.LoadGame.Location = new System.Drawing.Point(207, 140);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(65, 59);
            this.LoadGame.TabIndex = 0;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = false;
            this.LoadGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(11, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(215, 18);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Welcome to galactic vagabond.";
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.Color.Black;
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(57, 205);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 3;
            this.playerName.Visible = false;
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.LawnGreen;
            this.StartGame.Location = new System.Drawing.Point(163, 205);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(76, 29);
            this.StartGame.TabIndex = 4;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Visible = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.NewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "launcher";
            this.Text = "GV launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button StartGame;
    }
}