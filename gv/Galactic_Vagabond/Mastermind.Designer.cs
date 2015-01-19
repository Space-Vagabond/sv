namespace Galactic_Vagabond
{
    partial class mastermind
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
            this.ValidateButton = new System.Windows.Forms.Button();
            this.SequenceLabel = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValidateButton
            // 
            this.ValidateButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ValidateButton.Location = new System.Drawing.Point(312, 94);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(45, 23);
            this.ValidateButton.TabIndex = 0;
            this.ValidateButton.Text = "Ok";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // SequenceLabel
            // 
            this.SequenceLabel.AutoSize = true;
            this.SequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.SequenceLabel.Location = new System.Drawing.Point(222, 61);
            this.SequenceLabel.Name = "SequenceLabel";
            this.SequenceLabel.Size = new System.Drawing.Size(107, 16);
            this.SequenceLabel.TabIndex = 1;
            this.SequenceLabel.Text = "PLACEHOLDER";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(206, 94);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 2;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Yellow;
            this.description.Location = new System.Drawing.Point(203, 22);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(147, 15);
            this.description.TabIndex = 3;
            this.description.Text = "Remember the sequence";
            // 
            // mastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.description);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.SequenceLabel);
            this.Controls.Add(this.ValidateButton);
            this.Name = "mastermind";
            this.Text = "Mastermind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Label SequenceLabel;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label description;
    }
}