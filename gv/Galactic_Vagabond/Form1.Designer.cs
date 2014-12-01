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
            this.CurrentPlanet = new System.Windows.Forms.ListBox();
            this.map = new Galactic_Vagabond.Map();
            this.SuspendLayout();
            // 
            // CurrentPlanet
            // 
            this.CurrentPlanet.BackColor = System.Drawing.Color.Black;
            this.CurrentPlanet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentPlanet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CurrentPlanet.Font = new System.Drawing.Font("Orator Std", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlanet.ForeColor = System.Drawing.Color.Yellow;
            this.CurrentPlanet.FormattingEnabled = true;
            this.CurrentPlanet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentPlanet.ItemHeight = 17;
            this.CurrentPlanet.Location = new System.Drawing.Point(671, 33);
            this.CurrentPlanet.Name = "CurrentPlanet";
            this.CurrentPlanet.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CurrentPlanet.Size = new System.Drawing.Size(516, 204);
            this.CurrentPlanet.TabIndex = 7;
            this.CurrentPlanet.TabStop = false;
            //this.CurrentPlanet.
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(604, 604);
            this.map.TabIndex = 0;
            this.map.Text = "map1";
            this.map.Universe = null;
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_GV_01";
            this.Text = "Galactic_Vagabond 0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentPlanet;
        private Map map;



    }
}

