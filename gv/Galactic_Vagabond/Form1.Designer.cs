﻿namespace Galactic_Vagabond
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
            this.Build = new System.Windows.Forms.Button();
            this.SiliciumLabel = new System.Windows.Forms.Label();
            this.GemsLabel = new System.Windows.Forms.Label();
            this.PlutoniumLabel = new System.Windows.Forms.Label();
            this.MetalLabel = new System.Windows.Forms.Label();
            this.HydrogenLabel = new System.Windows.Forms.Label();
            this.HeliumLabel = new System.Windows.Forms.Label();
            this.TurnEvents = new System.Windows.Forms.ListBox();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.TechButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.CodexButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.LastTurnLabel = new System.Windows.Forms.Label();
            this.map = new Galactic_Vagabond.Map();
            this.SuspendLayout();
            // 
            // CurrentPlanet
            // 
            this.CurrentPlanet.BackColor = System.Drawing.Color.Black;
            this.CurrentPlanet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CurrentPlanet.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlanet.ForeColor = System.Drawing.Color.Gold;
            this.CurrentPlanet.Location = new System.Drawing.Point(771, 9);
            this.CurrentPlanet.Name = "CurrentPlanet";
            this.CurrentPlanet.Size = new System.Drawing.Size(492, 210);
            this.CurrentPlanet.TabIndex = 2;
            // 
            // EndTurn
            // 
            this.EndTurn.BackColor = System.Drawing.Color.Firebrick;
            this.EndTurn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.EndTurn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.EndTurn.FlatAppearance.BorderSize = 2;
            this.EndTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EndTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.EndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndTurn.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTurn.ForeColor = System.Drawing.Color.Black;
            this.EndTurn.Location = new System.Drawing.Point(1134, 658);
            this.EndTurn.Name = "EndTurn";
            this.EndTurn.Size = new System.Drawing.Size(109, 51);
            this.EndTurn.TabIndex = 1;
            this.EndTurn.Text = "End Turn";
            this.EndTurn.UseVisualStyleBackColor = false;
            this.EndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // Build
            // 
            this.Build.BackColor = System.Drawing.Color.Transparent;
            this.Build.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.Build.FlatAppearance.BorderSize = 2;
            this.Build.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.Build.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Build.Font = new System.Drawing.Font("Orator Std", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build.ForeColor = System.Drawing.Color.Chartreuse;
            this.Build.Location = new System.Drawing.Point(645, 184);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(120, 32);
            this.Build.TabIndex = 3;
            this.Build.Text = "Build factory";
            this.Build.UseVisualStyleBackColor = false;
            this.Build.Visible = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // SiliciumLabel
            // 
            this.SiliciumLabel.AutoSize = true;
            this.SiliciumLabel.BackColor = System.Drawing.Color.Transparent;
            this.SiliciumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiliciumLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiliciumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.SiliciumLabel.Location = new System.Drawing.Point(623, 13);
            this.SiliciumLabel.Name = "SiliciumLabel";
            this.SiliciumLabel.Size = new System.Drawing.Size(72, 17);
            this.SiliciumLabel.TabIndex = 5;
            this.SiliciumLabel.Text = "Silicium";
            // 
            // GemsLabel
            // 
            this.GemsLabel.AutoSize = true;
            this.GemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.GemsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemsLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.GemsLabel.Location = new System.Drawing.Point(623, 30);
            this.GemsLabel.Name = "GemsLabel";
            this.GemsLabel.Size = new System.Drawing.Size(40, 17);
            this.GemsLabel.TabIndex = 6;
            this.GemsLabel.Text = "Gems";
            // 
            // PlutoniumLabel
            // 
            this.PlutoniumLabel.AutoSize = true;
            this.PlutoniumLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlutoniumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlutoniumLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlutoniumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.PlutoniumLabel.Location = new System.Drawing.Point(622, 47);
            this.PlutoniumLabel.Name = "PlutoniumLabel";
            this.PlutoniumLabel.Size = new System.Drawing.Size(80, 17);
            this.PlutoniumLabel.TabIndex = 7;
            this.PlutoniumLabel.Text = "Plutonium";
            // 
            // MetalLabel
            // 
            this.MetalLabel.AutoSize = true;
            this.MetalLabel.BackColor = System.Drawing.Color.Transparent;
            this.MetalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetalLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalLabel.ForeColor = System.Drawing.Color.Yellow;
            this.MetalLabel.Location = new System.Drawing.Point(622, 64);
            this.MetalLabel.Name = "MetalLabel";
            this.MetalLabel.Size = new System.Drawing.Size(48, 17);
            this.MetalLabel.TabIndex = 8;
            this.MetalLabel.Text = "Metal";
            // 
            // HydrogenLabel
            // 
            this.HydrogenLabel.AutoSize = true;
            this.HydrogenLabel.BackColor = System.Drawing.Color.Transparent;
            this.HydrogenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HydrogenLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HydrogenLabel.ForeColor = System.Drawing.Color.Yellow;
            this.HydrogenLabel.Location = new System.Drawing.Point(622, 81);
            this.HydrogenLabel.Name = "HydrogenLabel";
            this.HydrogenLabel.Size = new System.Drawing.Size(80, 17);
            this.HydrogenLabel.TabIndex = 9;
            this.HydrogenLabel.Text = "Hydrogene";
            // 
            // HeliumLabel
            // 
            this.HeliumLabel.AutoSize = true;
            this.HeliumLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeliumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeliumLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeliumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.HeliumLabel.Location = new System.Drawing.Point(623, 98);
            this.HeliumLabel.Name = "HeliumLabel";
            this.HeliumLabel.Size = new System.Drawing.Size(56, 17);
            this.HeliumLabel.TabIndex = 10;
            this.HeliumLabel.Text = "Helium";
            // 
            // TurnEvents
            // 
            this.TurnEvents.BackColor = System.Drawing.Color.Black;
            this.TurnEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TurnEvents.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnEvents.ForeColor = System.Drawing.Color.GhostWhite;
            this.TurnEvents.FormattingEnabled = true;
            this.TurnEvents.ItemHeight = 20;
            this.TurnEvents.Location = new System.Drawing.Point(622, 260);
            this.TurnEvents.Name = "TurnEvents";
            this.TurnEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnEvents.ScrollAlwaysVisible = true;
            this.TurnEvents.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TurnEvents.Size = new System.Drawing.Size(641, 222);
            this.TurnEvents.TabIndex = 11;
            // 
            // OverviewButton
            // 
            this.OverviewButton.BackColor = System.Drawing.Color.Black;
            this.OverviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.OverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewButton.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.OverviewButton.Location = new System.Drawing.Point(116, 670);
            this.OverviewButton.Margin = new System.Windows.Forms.Padding(0);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(100, 39);
            this.OverviewButton.TabIndex = 12;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = false;
            // 
            // TechButton
            // 
            this.TechButton.BackColor = System.Drawing.Color.Black;
            this.TechButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.TechButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechButton.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.TechButton.Location = new System.Drawing.Point(216, 670);
            this.TechButton.Margin = new System.Windows.Forms.Padding(0);
            this.TechButton.Name = "TechButton";
            this.TechButton.Size = new System.Drawing.Size(100, 39);
            this.TechButton.TabIndex = 13;
            this.TechButton.Text = "Techs";
            this.TechButton.UseVisualStyleBackColor = false;
            // 
            // EventsButton
            // 
            this.EventsButton.BackColor = System.Drawing.Color.Black;
            this.EventsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.EventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsButton.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.EventsButton.Location = new System.Drawing.Point(316, 670);
            this.EventsButton.Margin = new System.Windows.Forms.Padding(0);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(100, 39);
            this.EventsButton.TabIndex = 14;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = false;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // CodexButton
            // 
            this.CodexButton.BackColor = System.Drawing.Color.Black;
            this.CodexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.CodexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodexButton.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodexButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CodexButton.Location = new System.Drawing.Point(416, 670);
            this.CodexButton.Margin = new System.Windows.Forms.Padding(0);
            this.CodexButton.Name = "CodexButton";
            this.CodexButton.Size = new System.Drawing.Size(100, 39);
            this.CodexButton.TabIndex = 15;
            this.CodexButton.Text = "Codex";
            this.CodexButton.UseVisualStyleBackColor = false;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.BackColor = System.Drawing.Color.Black;
            this.StatisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.StatisticsButton.Location = new System.Drawing.Point(516, 670);
            this.StatisticsButton.Margin = new System.Windows.Forms.Padding(0);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(100, 39);
            this.StatisticsButton.TabIndex = 16;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = false;
            // 
            // LastTurnLabel
            // 
            this.LastTurnLabel.AutoSize = true;
            this.LastTurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastTurnLabel.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTurnLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LastTurnLabel.Location = new System.Drawing.Point(642, 240);
            this.LastTurnLabel.Name = "LastTurnLabel";
            this.LastTurnLabel.Size = new System.Drawing.Size(152, 17);
            this.LastTurnLabel.TabIndex = 17;
            this.LastTurnLabel.Text = "Last turn events :";
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
            // Form_GV_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.LastTurnLabel);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.CodexButton);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.TechButton);
            this.Controls.Add(this.OverviewButton);
            this.Controls.Add(this.TurnEvents);
            this.Controls.Add(this.HeliumLabel);
            this.Controls.Add(this.HydrogenLabel);
            this.Controls.Add(this.MetalLabel);
            this.Controls.Add(this.PlutoniumLabel);
            this.Controls.Add(this.GemsLabel);
            this.Controls.Add(this.SiliciumLabel);
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
            this.PerformLayout();

        }

        #endregion

        private Map map;
        private System.Windows.Forms.Label CurrentPlanet;
        private System.Windows.Forms.Button EndTurn;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Label SiliciumLabel;
        private System.Windows.Forms.Label GemsLabel;
        private System.Windows.Forms.Label PlutoniumLabel;
        private System.Windows.Forms.Label MetalLabel;
        private System.Windows.Forms.Label HydrogenLabel;
        private System.Windows.Forms.Label HeliumLabel;
        private System.Windows.Forms.ListBox TurnEvents;
        private System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.Button TechButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button CodexButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Label LastTurnLabel;



    }
}

