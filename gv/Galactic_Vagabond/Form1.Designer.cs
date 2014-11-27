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
            this.button1 = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.Panel();
            this.CurrentPlanet = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(24, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Map";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map.Location = new System.Drawing.Point(24, 33);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(609, 606);
            this.map.TabIndex = 1;
            // 
            // CurrentPlanet
            // 
            this.CurrentPlanet.BackColor = System.Drawing.Color.Black;
            this.CurrentPlanet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentPlanet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CurrentPlanet.Font = new System.Drawing.Font("Orator Std", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlanet.ForeColor = System.Drawing.Color.Yellow;
            this.CurrentPlanet.FormattingEnabled = true;
            this.CurrentPlanet.ItemHeight = 17;
            this.CurrentPlanet.Location = new System.Drawing.Point(671, 33);
            this.CurrentPlanet.Name = "CurrentPlanet";
            this.CurrentPlanet.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CurrentPlanet.Size = new System.Drawing.Size(516, 204);
            this.CurrentPlanet.TabIndex = 7;
            this.CurrentPlanet.Click += new System.EventHandler(this.ShowCurrentPlanet);
            // 
            // Form_GV_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.CurrentPlanet);
            this.Controls.Add(this.map);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_GV_01";
            this.Text = "Galactic_Vagabond 0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.ListBox CurrentPlanet;



    }
}

