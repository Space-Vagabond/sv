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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GV_01));
            this.CurrentPlanet = new System.Windows.Forms.Label();
            this.EndTurn = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPlanet
            // 
            this.CurrentPlanet.BackColor = System.Drawing.Color.Black;
            this.CurrentPlanet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CurrentPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlanet.ForeColor = System.Drawing.Color.Gold;
            this.CurrentPlanet.Location = new System.Drawing.Point(697, 0);
            this.CurrentPlanet.Name = "CurrentPlanet";
            this.CurrentPlanet.Size = new System.Drawing.Size(310, 193);
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
            this.EndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTurn.ForeColor = System.Drawing.Color.Black;
            this.EndTurn.Location = new System.Drawing.Point(1134, 591);
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
            this.Build.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build.ForeColor = System.Drawing.Color.Chartreuse;
            this.Build.Location = new System.Drawing.Point(1016, 161);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(158, 32);
            this.Build.TabIndex = 3;
            this.Build.Text = "Build factory";
            this.Build.UseVisualStyleBackColor = false;
            this.Build.Visible = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // map
            // 
            this.map.AllowUserToAddRows = false;
            this.map.AllowUserToDeleteRows = false;
            this.map.AllowUserToResizeColumns = false;
            this.map.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.map.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.map.BackgroundColor = System.Drawing.Color.Black;
            this.map.CausesValidation = false;
            this.map.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.map.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.map.ColumnHeadersVisible = false;
            this.map.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21});
            this.map.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Outlook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.map.DefaultCellStyle = dataGridViewCellStyle2;
            this.map.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.map.EnableHeadersVisualStyles = false;
            this.map.GridColor = System.Drawing.Color.Turquoise;
            this.map.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.ReadOnly = true;
            this.map.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.map.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.map.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.map.ShowCellErrors = false;
            this.map.ShowCellToolTips = false;
            this.map.ShowEditingIcon = false;
            this.map.ShowRowErrors = false;
            this.map.Size = new System.Drawing.Size(700, 600);
            this.map.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Column21";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // SiliciumLabel
            // 
            this.SiliciumLabel.AutoSize = true;
            this.SiliciumLabel.BackColor = System.Drawing.Color.Transparent;
            this.SiliciumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiliciumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiliciumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.SiliciumLabel.Location = new System.Drawing.Point(1013, 89);
            this.SiliciumLabel.Name = "SiliciumLabel";
            this.SiliciumLabel.Size = new System.Drawing.Size(67, 18);
            this.SiliciumLabel.TabIndex = 5;
            this.SiliciumLabel.Text = "Silicium";
            // 
            // GemsLabel
            // 
            this.GemsLabel.AutoSize = true;
            this.GemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.GemsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.GemsLabel.Location = new System.Drawing.Point(1013, 9);
            this.GemsLabel.Name = "GemsLabel";
            this.GemsLabel.Size = new System.Drawing.Size(53, 18);
            this.GemsLabel.TabIndex = 6;
            this.GemsLabel.Text = "Gems";
            // 
            // PlutoniumLabel
            // 
            this.PlutoniumLabel.AutoSize = true;
            this.PlutoniumLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlutoniumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlutoniumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlutoniumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.PlutoniumLabel.Location = new System.Drawing.Point(1013, 73);
            this.PlutoniumLabel.Name = "PlutoniumLabel";
            this.PlutoniumLabel.Size = new System.Drawing.Size(83, 18);
            this.PlutoniumLabel.TabIndex = 7;
            this.PlutoniumLabel.Text = "Plutonium";
            // 
            // MetalLabel
            // 
            this.MetalLabel.AutoSize = true;
            this.MetalLabel.BackColor = System.Drawing.Color.Transparent;
            this.MetalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalLabel.ForeColor = System.Drawing.Color.Yellow;
            this.MetalLabel.Location = new System.Drawing.Point(1013, 57);
            this.MetalLabel.Name = "MetalLabel";
            this.MetalLabel.Size = new System.Drawing.Size(49, 18);
            this.MetalLabel.TabIndex = 8;
            this.MetalLabel.Text = "Metal";
            // 
            // HydrogenLabel
            // 
            this.HydrogenLabel.AutoSize = true;
            this.HydrogenLabel.BackColor = System.Drawing.Color.Transparent;
            this.HydrogenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HydrogenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HydrogenLabel.ForeColor = System.Drawing.Color.Yellow;
            this.HydrogenLabel.Location = new System.Drawing.Point(1013, 41);
            this.HydrogenLabel.Name = "HydrogenLabel";
            this.HydrogenLabel.Size = new System.Drawing.Size(89, 18);
            this.HydrogenLabel.TabIndex = 9;
            this.HydrogenLabel.Text = "Hydrogene";
            // 
            // HeliumLabel
            // 
            this.HeliumLabel.AutoSize = true;
            this.HeliumLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeliumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeliumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeliumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.HeliumLabel.Location = new System.Drawing.Point(1013, 25);
            this.HeliumLabel.Name = "HeliumLabel";
            this.HeliumLabel.Size = new System.Drawing.Size(60, 18);
            this.HeliumLabel.TabIndex = 10;
            this.HeliumLabel.Text = "Helium";
            // 
            // TurnEvents
            // 
            this.TurnEvents.BackColor = System.Drawing.Color.Black;
            this.TurnEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TurnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnEvents.ForeColor = System.Drawing.Color.GhostWhite;
            this.TurnEvents.FormattingEnabled = true;
            this.TurnEvents.ItemHeight = 18;
            this.TurnEvents.Location = new System.Drawing.Point(701, 242);
            this.TurnEvents.Name = "TurnEvents";
            this.TurnEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnEvents.ScrollAlwaysVisible = true;
            this.TurnEvents.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TurnEvents.Size = new System.Drawing.Size(557, 200);
            this.TurnEvents.TabIndex = 11;
            // 
            // OverviewButton
            // 
            this.OverviewButton.BackColor = System.Drawing.Color.Black;
            this.OverviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.OverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.OverviewButton.Location = new System.Drawing.Point(9, 603);
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
            this.TechButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.TechButton.Location = new System.Drawing.Point(109, 603);
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
            this.EventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.EventsButton.Location = new System.Drawing.Point(209, 603);
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
            this.CodexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodexButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CodexButton.Location = new System.Drawing.Point(309, 603);
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
            this.StatisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.StatisticsButton.Location = new System.Drawing.Point(409, 603);
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
            this.LastTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTurnLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LastTurnLabel.Location = new System.Drawing.Point(706, 204);
            this.LastTurnLabel.Name = "LastTurnLabel";
            this.LastTurnLabel.Size = new System.Drawing.Size(138, 18);
            this.LastTurnLabel.TabIndex = 17;
            this.LastTurnLabel.Text = "Last turn events :";
            // 
            // Form_GV_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1253, 646);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
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
        private System.Windows.Forms.DataGridView map;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Column11;
        private System.Windows.Forms.DataGridViewImageColumn Column12;
        private System.Windows.Forms.DataGridViewImageColumn Column13;
        private System.Windows.Forms.DataGridViewImageColumn Column14;
        private System.Windows.Forms.DataGridViewImageColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Column16;
        private System.Windows.Forms.DataGridViewImageColumn Column17;
        private System.Windows.Forms.DataGridViewImageColumn Column18;
        private System.Windows.Forms.DataGridViewImageColumn Column19;
        private System.Windows.Forms.DataGridViewImageColumn Column20;
        private System.Windows.Forms.DataGridViewImageColumn Column21;



    }
}

