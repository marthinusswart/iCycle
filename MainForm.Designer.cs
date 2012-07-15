namespace iCycle
{
    partial class MainForm
    {


		#region Fields (21) 

        private System.Windows.Forms.ToolStripMenuItem addNewExcersizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRouteToolStripMenuItem;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExcersizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excersizesToolStripMenuItem;
        private System.Windows.Forms.Button exercisesButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox leftBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Button routesButton;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.ToolStripMenuItem weeklySummariesToolStripMenuItem;

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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excersizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklySummariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewExcersizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExcersizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftBox = new System.Windows.Forms.GroupBox();
            this.routesButton = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.exercisesButton = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(680, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routesToolStripMenuItem,
            this.excersizesToolStripMenuItem,
            this.weeklySummariesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.routesToolStripMenuItem.Text = "&Routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // excersizesToolStripMenuItem
            // 
            this.excersizesToolStripMenuItem.Name = "excersizesToolStripMenuItem";
            this.excersizesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.excersizesToolStripMenuItem.Text = "&Exercises";
            this.excersizesToolStripMenuItem.Click += new System.EventHandler(this.exercisesToolStripMenuItem_Click);
            // 
            // weeklySummariesToolStripMenuItem
            // 
            this.weeklySummariesToolStripMenuItem.Name = "weeklySummariesToolStripMenuItem";
            this.weeklySummariesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.weeklySummariesToolStripMenuItem.Text = "&Weekly Summaries";
            this.weeklySummariesToolStripMenuItem.Click += new System.EventHandler(this.weeklySummariesToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRouteToolStripMenuItem,
            this.addNewExcersizeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.editRouteToolStripMenuItem,
            this.editExcersizeToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // addNewRouteToolStripMenuItem
            // 
            this.addNewRouteToolStripMenuItem.Name = "addNewRouteToolStripMenuItem";
            this.addNewRouteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addNewRouteToolStripMenuItem.Text = "Add &Route";
            this.addNewRouteToolStripMenuItem.Click += new System.EventHandler(this.addNewRouteToolStripMenuItem_Click);
            // 
            // addNewExcersizeToolStripMenuItem
            // 
            this.addNewExcersizeToolStripMenuItem.Name = "addNewExcersizeToolStripMenuItem";
            this.addNewExcersizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.addNewExcersizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addNewExcersizeToolStripMenuItem.Text = "Add &Exercise";
            this.addNewExcersizeToolStripMenuItem.Click += new System.EventHandler(this.addNewExcersizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "Add &Weekly Summary";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
            // 
            // editRouteToolStripMenuItem
            // 
            this.editRouteToolStripMenuItem.Enabled = false;
            this.editRouteToolStripMenuItem.Name = "editRouteToolStripMenuItem";
            this.editRouteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editRouteToolStripMenuItem.Text = "Edit Route";
            this.editRouteToolStripMenuItem.Click += new System.EventHandler(this.editRouteToolStripMenuItem_Click);
            // 
            // editExcersizeToolStripMenuItem
            // 
            this.editExcersizeToolStripMenuItem.Enabled = false;
            this.editExcersizeToolStripMenuItem.Name = "editExcersizeToolStripMenuItem";
            this.editExcersizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editExcersizeToolStripMenuItem.Text = "Edit Exercise";
            this.editExcersizeToolStripMenuItem.Click += new System.EventHandler(this.editExcersizeToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(87, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(593, 496);
            this.mainTabControl.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(87, 496);
            this.leftPanel.TabIndex = 2;
            // 
            // leftBox
            // 
            this.leftBox.Controls.Add(this.routesButton);
            this.leftBox.Controls.Add(this.weeklyButton);
            this.leftBox.Controls.Add(this.exercisesButton);
            this.leftBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBox.Location = new System.Drawing.Point(0, 0);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(87, 496);
            this.leftBox.TabIndex = 0;
            this.leftBox.TabStop = false;
            this.leftBox.Text = "Navigation";
            // 
            // routesButton
            // 
            this.routesButton.Location = new System.Drawing.Point(6, 181);
            this.routesButton.Name = "routesButton";
            this.routesButton.Size = new System.Drawing.Size(75, 75);
            this.routesButton.TabIndex = 2;
            this.routesButton.Text = "Routes";
            this.routesButton.UseVisualStyleBackColor = true;
            this.routesButton.Click += new System.EventHandler(this.routesButton_Click);
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(6, 100);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(75, 75);
            this.weeklyButton.TabIndex = 1;
            this.weeklyButton.Text = "Weekly Summaries";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            // 
            // exercisesButton
            // 
            this.exercisesButton.Location = new System.Drawing.Point(6, 19);
            this.exercisesButton.Name = "exercisesButton";
            this.exercisesButton.Size = new System.Drawing.Size(75, 75);
            this.exercisesButton.TabIndex = 0;
            this.exercisesButton.Text = "Exercises";
            this.exercisesButton.UseVisualStyleBackColor = true;
            this.exercisesButton.Click += new System.EventHandler(this.exercisesButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 520);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCycle";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

