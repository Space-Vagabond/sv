namespace Galactic_Vagabond
{
    partial class caesar
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.MessageLabel.Location = new System.Drawing.Point(227, 74);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(96, 15);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "PLACEHOLDER";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(212, 124);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 1;
            // 
            // ValidateButton
            // 
            this.ValidateButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ValidateButton.Location = new System.Drawing.Point(319, 124);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(47, 23);
            this.ValidateButton.TabIndex = 2;
            this.ValidateButton.Text = "Ok";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Yellow;
            this.description.Location = new System.Drawing.Point(66, 20);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(397, 16);
            this.description.TabIndex = 3;
            this.description.Text = "An alien talks to you but you don\'t understand, guess what he said.";
            // 
            // caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(587, 314);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.MessageLabel);
            this.Name = "caesar";
            this.Text = "caesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Label description;
    }
}