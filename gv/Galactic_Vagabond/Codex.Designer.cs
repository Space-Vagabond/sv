namespace Galactic_Vagabond
{
    partial class Codex
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
            this.HydrogenButton = new System.Windows.Forms.Button();
            this.SiliciumButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HydrogenButton
            // 
            this.HydrogenButton.BackColor = System.Drawing.Color.Transparent;
            this.HydrogenButton.FlatAppearance.BorderSize = 0;
            this.HydrogenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HydrogenButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.HydrogenButton.Location = new System.Drawing.Point(13, 13);
            this.HydrogenButton.Name = "HydrogenButton";
            this.HydrogenButton.Size = new System.Drawing.Size(115, 23);
            this.HydrogenButton.TabIndex = 0;
            this.HydrogenButton.Text = "Hydrogen";
            this.HydrogenButton.UseVisualStyleBackColor = false;
            this.HydrogenButton.Click += new System.EventHandler(this.HydrogenButton_Click);
            // 
            // SiliciumButton
            // 
            this.SiliciumButton.BackColor = System.Drawing.Color.Transparent;
            this.SiliciumButton.FlatAppearance.BorderSize = 0;
            this.SiliciumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiliciumButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.SiliciumButton.Location = new System.Drawing.Point(13, 42);
            this.SiliciumButton.Name = "SiliciumButton";
            this.SiliciumButton.Size = new System.Drawing.Size(115, 23);
            this.SiliciumButton.TabIndex = 1;
            this.SiliciumButton.Text = "Silicium";
            this.SiliciumButton.UseVisualStyleBackColor = false;
            this.SiliciumButton.Click += new System.EventHandler(this.SiliciumButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(151, -1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(864, 686);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gems";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(12, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Plutonium";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Codex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1016, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.SiliciumButton);
            this.Controls.Add(this.HydrogenButton);
            this.Name = "Codex";
            this.Text = "Codex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HydrogenButton;
        private System.Windows.Forms.Button SiliciumButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}