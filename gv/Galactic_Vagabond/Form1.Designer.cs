namespace Galactic_Vagabond
{
    partial class Form_GV_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GV_01));
            this.CurrentPlanet = new System.Windows.Forms.Label();
            this.EndTurn = new System.Windows.Forms.Button();
            this.map = new Galactic_Vagabond.Map();
            this.Build = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentPlanet
            // 
            this.CurrentPlanet.BackColor = System.Drawing.Color.Black;
            this.CurrentPlanet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CurrentPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlanet.ForeColor = System.Drawing.Color.Gold;
            this.CurrentPlanet.Location = new System.Drawing.Point(709, 12);
            this.CurrentPlanet.Name = "CurrentPlanet";
            this.CurrentPlanet.Size = new System.Drawing.Size(543, 210);
            this.CurrentPlanet.TabIndex = 2;
            // 
            // EndTurn
            // 
            this.EndTurn.BackColor = System.Drawing.Color.Purple;
            this.EndTurn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.EndTurn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.EndTurn.FlatAppearance.BorderSize = 2;
            this.EndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndTurn.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTurn.ForeColor = System.Drawing.Color.Lime;
            this.EndTurn.Location = new System.Drawing.Point(1134, 658);
            this.EndTurn.Name = "EndTurn";
            this.EndTurn.Size = new System.Drawing.Size(109, 51);
            this.EndTurn.TabIndex = 1;
            this.EndTurn.Text = "End Turn";
            this.EndTurn.UseVisualStyleBackColor = false;
            this.EndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(604, 604);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.Text = "map1";
            this.map.Universe = null;
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(1134, 332);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(75, 23);
            this.Build.TabIndex = 3;
            this.Build.Text = "Build";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Visible = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // Form_GV_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.EndTurn);
            this.Controls.Add(this.CurrentPlanet);
            this.Controls.Add(this.map);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_GV_01";
            this.Text = "Galactic_Vagabond 0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private Map map;
        private System.Windows.Forms.Label CurrentPlanet;
        private System.Windows.Forms.Button EndTurn;
        private System.Windows.Forms.Button Build;



    }
}

