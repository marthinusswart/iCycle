namespace iCycle
{
    partial class WeeklySummaryForm
    {

		#region Fields (7) 

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationLightZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn HardZone;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModerateZone;
        private System.Windows.Forms.DataGridView weeklySummaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekStartDate;

		#endregion Fields 

		#region Methods (1) 


		// Protected Methods (1) 

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


		#endregion Methods 


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.weeklySummaryGrid = new System.Windows.Forms.DataGridView();
            this.WeekStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationLightZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModerateZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySummaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.weeklySummaryGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(683, 454);
            this.mainPanel.TabIndex = 0;
            // 
            // weeklySummaryGrid
            // 
            this.weeklySummaryGrid.AllowUserToAddRows = false;
            this.weeklySummaryGrid.AllowUserToDeleteRows = false;
            this.weeklySummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.weeklySummaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeekStartDate,
            this.DurationLightZone,
            this.ModerateZone,
            this.HardZone});
            this.weeklySummaryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklySummaryGrid.Location = new System.Drawing.Point(0, 0);
            this.weeklySummaryGrid.Name = "weeklySummaryGrid";
            this.weeklySummaryGrid.ReadOnly = true;
            this.weeklySummaryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.weeklySummaryGrid.Size = new System.Drawing.Size(683, 454);
            this.weeklySummaryGrid.TabIndex = 0;
            // 
            // WeekStartDate
            // 
            this.WeekStartDate.DataPropertyName = "WeekStartDate";
            this.WeekStartDate.HeaderText = "Week start date";
            this.WeekStartDate.MinimumWidth = 100;
            this.WeekStartDate.Name = "WeekStartDate";
            this.WeekStartDate.ReadOnly = true;
            this.WeekStartDate.Width = 120;
            // 
            // DurationLightZone
            // 
            this.DurationLightZone.DataPropertyName = "DurationLightZone";
            this.DurationLightZone.HeaderText = "Duration in light zone (h:m:s)";
            this.DurationLightZone.MinimumWidth = 150;
            this.DurationLightZone.Name = "DurationLightZone";
            this.DurationLightZone.ReadOnly = true;
            this.DurationLightZone.Width = 150;
            // 
            // ModerateZone
            // 
            this.ModerateZone.DataPropertyName = "DurationModerateZone";
            this.ModerateZone.HeaderText = "Duration in moderate zone (h:m:s)";
            this.ModerateZone.MinimumWidth = 180;
            this.ModerateZone.Name = "ModerateZone";
            this.ModerateZone.ReadOnly = true;
            this.ModerateZone.Width = 180;
            // 
            // HardZone
            // 
            this.HardZone.DataPropertyName = "DurationHardZone";
            this.HardZone.HeaderText = "Duration in hard zone (h:m:s)";
            this.HardZone.MinimumWidth = 150;
            this.HardZone.Name = "HardZone";
            this.HardZone.ReadOnly = true;
            this.HardZone.Width = 150;
            // 
            // WeeklySummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 454);
            this.Controls.Add(this.mainPanel);
            this.Name = "WeeklySummaryForm";
            this.Text = "WeeklySummaryForm";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklySummaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}