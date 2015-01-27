namespace Galactic_Vagabond
{
    partial class GameLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLoader));
            this.Back = new System.Windows.Forms.Button();
            this.LoadSelected = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.ListBox();
            this.Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Chartreuse;
            this.Back.Location = new System.Drawing.Point(234, 33);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(87, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LoadSelected
            // 
            this.LoadSelected.BackColor = System.Drawing.Color.Black;
            this.LoadSelected.Enabled = false;
            this.LoadSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSelected.ForeColor = System.Drawing.Color.Chartreuse;
            this.LoadSelected.Location = new System.Drawing.Point(234, 129);
            this.LoadSelected.Name = "LoadSelected";
            this.LoadSelected.Size = new System.Drawing.Size(87, 23);
            this.LoadSelected.TabIndex = 1;
            this.LoadSelected.Text = "Load";
            this.LoadSelected.UseVisualStyleBackColor = false;
            this.LoadSelected.Click += new System.EventHandler(this.LoadSelected_Click);
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.Color.Black;
            this.Games.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Games.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games.ForeColor = System.Drawing.Color.White;
            this.Games.FormattingEnabled = true;
            this.Games.ItemHeight = 15;
            this.Games.Location = new System.Drawing.Point(14, 20);
            this.Games.Name = "Games";
            this.Games.ScrollAlwaysVisible = true;
            this.Games.Size = new System.Drawing.Size(161, 225);
            this.Games.TabIndex = 2;
            this.Games.SelectedValueChanged += new System.EventHandler(this.Games_SelectedValueChanged);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.BackColor = System.Drawing.Color.Transparent;
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg.ForeColor = System.Drawing.Color.Orange;
            this.Msg.Location = new System.Drawing.Point(201, 89);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(121, 20);
            this.Msg.TabIndex = 3;
            this.Msg.Text = "Choose a game";
            // 
            // GameLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.LoadSelected);
            this.Controls.Add(this.Back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLoader";
            this.Text = "GameLoader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button LoadSelected;
        private System.Windows.Forms.ListBox Games;
        private System.Windows.Forms.Label Msg;
    }
}