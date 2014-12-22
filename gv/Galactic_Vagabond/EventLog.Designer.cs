namespace Galactic_Vagabond
{
    partial class EventLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLog));
            this.Logs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.Black;
            this.Logs.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.ForeColor = System.Drawing.Color.White;
            this.Logs.FormattingEnabled = true;
            this.Logs.ItemHeight = 19;
            this.Logs.Location = new System.Drawing.Point(4, 0);
            this.Logs.Name = "Logs";
            this.Logs.ScrollAlwaysVisible = true;
            this.Logs.Size = new System.Drawing.Size(992, 650);
            this.Logs.TabIndex = 0;
            // 
            // EventLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.Logs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventLog";
            this.Text = "EventLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Logs;
    }
}