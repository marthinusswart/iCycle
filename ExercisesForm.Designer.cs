namespace iCycle
{
    partial class ExercisesForm
    {


		#region Fields (16) 

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView excersizesGrid;
        private System.Windows.Forms.Panel mainPanel;

		#endregion Fields


		#region Methods (1) 


		// Protected Methods (1) 

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


		#endregion Methods


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.excersizesGrid = new System.Windows.Forms.DataGridView();
            this.ExDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelowZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboveZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatBurned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excersizesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.excersizesGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(647, 511);
            this.mainPanel.TabIndex = 0;
            // 
            // excersizesGrid
            // 
            this.excersizesGrid.AllowUserToAddRows = false;
            this.excersizesGrid.AllowUserToDeleteRows = false;
            this.excersizesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.excersizesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExDate,
            this.TimeZone,
            this.ExRoute,
            this.AvgSpeed,
            this.TopSpeed,
            this.Distance,
            this.Duration,
            this.Calories,
            this.AvgHR,
            this.MaxHR,
            this.InZone,
            this.BelowZone,
            this.AboveZone,
            this.FatBurned});
            this.excersizesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excersizesGrid.Location = new System.Drawing.Point(0, 0);
            this.excersizesGrid.Name = "excersizesGrid";
            this.excersizesGrid.ReadOnly = true;
            this.excersizesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.excersizesGrid.Size = new System.Drawing.Size(647, 511);
            this.excersizesGrid.TabIndex = 1;
            // 
            // ExDate
            // 
            this.ExDate.DataPropertyName = "ExerciseDate";
            this.ExDate.HeaderText = "Date";
            this.ExDate.MinimumWidth = 120;
            this.ExDate.Name = "ExDate";
            this.ExDate.ReadOnly = true;
            this.ExDate.Width = 150;
            // 
            // TimeZone
            // 
            this.TimeZone.DataPropertyName = "TimeZoneName";
            this.TimeZone.HeaderText = "TimeZone";
            this.TimeZone.Name = "TimeZone";
            this.TimeZone.ReadOnly = true;
            // 
            // ExRoute
            // 
            this.ExRoute.DataPropertyName = "RouteName";
            this.ExRoute.HeaderText = "Route";
            this.ExRoute.MinimumWidth = 120;
            this.ExRoute.Name = "ExRoute";
            this.ExRoute.ReadOnly = true;
            this.ExRoute.Width = 150;
            // 
            // AvgSpeed
            // 
            this.AvgSpeed.DataPropertyName = "AverageSpeed";
            this.AvgSpeed.HeaderText = "Average Speed (km/h)";
            this.AvgSpeed.MinimumWidth = 120;
            this.AvgSpeed.Name = "AvgSpeed";
            this.AvgSpeed.ReadOnly = true;
            this.AvgSpeed.Width = 150;
            // 
            // TopSpeed
            // 
            this.TopSpeed.DataPropertyName = "TopSpeed";
            this.TopSpeed.HeaderText = "Top Speed (km/h)";
            this.TopSpeed.MinimumWidth = 120;
            this.TopSpeed.Name = "TopSpeed";
            this.TopSpeed.ReadOnly = true;
            this.TopSpeed.Width = 150;
            // 
            // Distance
            // 
            this.Distance.DataPropertyName = "Distance";
            this.Distance.HeaderText = "Distance (km)";
            this.Distance.MinimumWidth = 120;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Width = 150;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration (h:m:s)";
            this.Duration.MinimumWidth = 120;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 150;
            // 
            // Calories
            // 
            this.Calories.DataPropertyName = "Calories";
            this.Calories.HeaderText = "Calories";
            this.Calories.MinimumWidth = 120;
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            this.Calories.Width = 150;
            // 
            // AvgHR
            // 
            this.AvgHR.DataPropertyName = "AverageHeartRate";
            this.AvgHR.HeaderText = "Average Heart Rate (%)";
            this.AvgHR.MinimumWidth = 120;
            this.AvgHR.Name = "AvgHR";
            this.AvgHR.ReadOnly = true;
            this.AvgHR.Width = 150;
            // 
            // MaxHR
            // 
            this.MaxHR.DataPropertyName = "MaximumHeartRate";
            this.MaxHR.HeaderText = "Maximum Heart Rate (%)";
            this.MaxHR.MinimumWidth = 120;
            this.MaxHR.Name = "MaxHR";
            this.MaxHR.ReadOnly = true;
            this.MaxHR.Width = 150;
            // 
            // InZone
            // 
            this.InZone.DataPropertyName = "DurationInZone";
            this.InZone.HeaderText = "Duration In Zone (h:m:s)";
            this.InZone.MinimumWidth = 120;
            this.InZone.Name = "InZone";
            this.InZone.ReadOnly = true;
            this.InZone.Width = 150;
            // 
            // BelowZone
            // 
            this.BelowZone.DataPropertyName = "ZoneLower";
            this.BelowZone.HeaderText = "Zone Lower Limit (%)";
            this.BelowZone.MinimumWidth = 120;
            this.BelowZone.Name = "BelowZone";
            this.BelowZone.ReadOnly = true;
            this.BelowZone.Width = 150;
            // 
            // AboveZone
            // 
            this.AboveZone.DataPropertyName = "ZoneUpper";
            this.AboveZone.HeaderText = "Zone Upper Limit (%)";
            this.AboveZone.MinimumWidth = 120;
            this.AboveZone.Name = "AboveZone";
            this.AboveZone.ReadOnly = true;
            this.AboveZone.Width = 150;
            // 
            // FatBurned
            // 
            this.FatBurned.DataPropertyName = "FatBurned";
            this.FatBurned.HeaderText = "Fat Burned (%)";
            this.FatBurned.MinimumWidth = 120;
            this.FatBurned.Name = "FatBurned";
            this.FatBurned.ReadOnly = true;
            this.FatBurned.Width = 150;
            // 
            // ExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 511);
            this.Controls.Add(this.mainPanel);
            this.Name = "ExercisesForm";
            this.Text = "ExcersizesForm";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.excersizesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn InZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelowZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn AboveZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatBurned;

    }
}