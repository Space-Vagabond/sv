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
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(24, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Map";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map.Location = new System.Drawing.Point(24, 33);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(609, 606);
            this.map.TabIndex = 1;
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Black;
            this.up.FlatAppearance.BorderSize = 2;
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.ForeColor = System.Drawing.Color.Orange;
            this.up.Location = new System.Drawing.Point(259, 645);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 27);
            this.up.TabIndex = 2;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = false;
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Black;
            this.down.FlatAppearance.BorderSize = 2;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.ForeColor = System.Drawing.Color.Orange;
            this.down.Location = new System.Drawing.Point(259, 682);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 27);
            this.down.TabIndex = 3;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = false;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Black;
            this.left.FlatAppearance.BorderSize = 2;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.Color.Orange;
            this.left.Location = new System.Drawing.Point(178, 664);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 27);
            this.left.TabIndex = 4;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = false;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Black;
            this.right.FlatAppearance.BorderSize = 2;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.ForeColor = System.Drawing.Color.Orange;
            this.right.Location = new System.Drawing.Point(340, 664);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 27);
            this.right.TabIndex = 5;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = false;
            // 
            // Form_GV_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.map);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GV_01";
            this.Text = "Galactic_Vagabond 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;



    }
}

