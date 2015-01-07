namespace Galactic_Vagabond
{
    partial class Mastermind
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
            this.Rules = new System.Windows.Forms.Label();
            this.SequenceLabel = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.Location = new System.Drawing.Point(79, 21);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(505, 25);
            this.Rules.TabIndex = 0;
            this.Rules.Text = "Remember the sequence of letters and type it back.";
            // 
            // SequenceLabel
            // 
            this.SequenceLabel.AutoSize = true;
            this.SequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceLabel.Location = new System.Drawing.Point(268, 76);
            this.SequenceLabel.Name = "SequenceLabel";
            this.SequenceLabel.Size = new System.Drawing.Size(97, 18);
            this.SequenceLabel.TabIndex = 1;
            this.SequenceLabel.Text = "Placeholder";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(256, 106);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(109, 20);
            this.UserInput.TabIndex = 2;
            this.UserInput.Text = "Type here.";
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(371, 106);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(31, 20);
            this.ValidateButton.TabIndex = 3;
            this.ValidateButton.Text = "OK";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // Mastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 202);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.SequenceLabel);
            this.Controls.Add(this.Rules);
            this.Name = "Mastermind";
            this.Text = "Mastermind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Label SequenceLabel;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button ValidateButton;
    }
}