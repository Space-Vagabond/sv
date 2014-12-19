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
            this.Back = new System.Windows.Forms.Button();
            this.LoadSelected = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.ListBox();
            this.Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(201, 33);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LoadSelected
            // 
            this.LoadSelected.Enabled = false;
            this.LoadSelected.Location = new System.Drawing.Point(201, 129);
            this.LoadSelected.Name = "LoadSelected";
            this.LoadSelected.Size = new System.Drawing.Size(75, 23);
            this.LoadSelected.TabIndex = 1;
            this.LoadSelected.Text = "Load";
            this.LoadSelected.UseVisualStyleBackColor = true;
            this.LoadSelected.Click += new System.EventHandler(this.LoadSelected_Click);
            // 
            // Games
            // 
            this.Games.FormattingEnabled = true;
            this.Games.Location = new System.Drawing.Point(12, 20);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(139, 225);
            this.Games.TabIndex = 2;
            this.Games.SelectedValueChanged += new System.EventHandler(this.Games_SelectedValueChanged);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg.ForeColor = System.Drawing.Color.Red;
            this.Msg.Location = new System.Drawing.Point(147, 113);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(145, 13);
            this.Msg.TabIndex = 3;
            this.Msg.Text = "Choose a game to load !";
            // 
            // GameLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.LoadSelected);
            this.Controls.Add(this.Back);
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