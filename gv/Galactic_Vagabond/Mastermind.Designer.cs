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
            this.SuspendLayout();
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(357, 104);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(45, 23);
            this.ValidateButton.TabIndex = 0;
            this.ValidateButton.Text = "Ok";
            this.ValidateButton.UseVisualStyleBackColor = true;
            // 
            // SequenceLabel
            // 
            this.SequenceLabel.AutoSize = true;
            this.SequenceLabel.Location = new System.Drawing.Point(222, 61);
            this.SequenceLabel.Name = "SequenceLabel";
            this.SequenceLabel.Size = new System.Drawing.Size(33, 13);
            this.SequenceLabel.TabIndex = 1;
            this.SequenceLabel.Text = "Label";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(206, 94);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 2;
            // 
            // Mastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.SequenceLabel);
            this.Controls.Add(this.ValidateButton);
            this.Name = "Mastermind";
            this.Text = "Mastermind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Label SequenceLabel;
        private System.Windows.Forms.TextBox UserInput;
    }
}