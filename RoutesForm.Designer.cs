namespace iCycle
{
    partial class RoutesForm
    {

		#region Fields (14) 

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer mainSplitter;
        private System.Windows.Forms.GroupBox mapGroupBox;
        private System.Windows.Forms.PictureBox mapPicture;
        private System.Windows.Forms.GroupBox routeDetailGroupBox;
        private System.Windows.Forms.TextBox routeName;
        private System.Windows.Forms.GroupBox routesGroupBox;
        private System.Windows.Forms.ListBox routesListBox;

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
            this.mainSplitter = new System.Windows.Forms.SplitContainer();
            this.routesGroupBox = new System.Windows.Forms.GroupBox();
            this.routesListBox = new System.Windows.Forms.ListBox();
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.mapPicture = new System.Windows.Forms.PictureBox();
            this.routeDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.routeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.mainSplitter.Panel1.SuspendLayout();
            this.mainSplitter.Panel2.SuspendLayout();
            this.mainSplitter.SuspendLayout();
            this.routesGroupBox.SuspendLayout();
            this.mapGroupBox.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).BeginInit();
            this.routeDetailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainSplitter);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(813, 457);
            this.mainPanel.TabIndex = 0;
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitter.Location = new System.Drawing.Point(0, 0);
            this.mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            this.mainSplitter.Panel1.Controls.Add(this.routesGroupBox);
            // 
            // mainSplitter.Panel2
            // 
            this.mainSplitter.Panel2.Controls.Add(this.mapGroupBox);
            this.mainSplitter.Panel2.Controls.Add(this.routeDetailGroupBox);
            this.mainSplitter.Size = new System.Drawing.Size(813, 457);
            this.mainSplitter.SplitterDistance = 165;
            this.mainSplitter.TabIndex = 4;
            // 
            // routesGroupBox
            // 
            this.routesGroupBox.Controls.Add(this.routesListBox);
            this.routesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.routesGroupBox.Name = "routesGroupBox";
            this.routesGroupBox.Size = new System.Drawing.Size(165, 457);
            this.routesGroupBox.TabIndex = 0;
            this.routesGroupBox.TabStop = false;
            this.routesGroupBox.Text = "Routes";
            // 
            // routesListBox
            // 
            this.routesListBox.DisplayMember = "Name";
            this.routesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routesListBox.FormattingEnabled = true;
            this.routesListBox.Location = new System.Drawing.Point(3, 16);
            this.routesListBox.Name = "routesListBox";
            this.routesListBox.Size = new System.Drawing.Size(159, 433);
            this.routesListBox.TabIndex = 0;
            this.routesListBox.SelectedIndexChanged += new System.EventHandler(this.routesListBox_SelectedIndexChanged);
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.imagePanel);
            this.mapGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapGroupBox.Location = new System.Drawing.Point(0, 68);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(644, 389);
            this.mapGroupBox.TabIndex = 4;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Map";
            // 
            // imagePanel
            // 
            this.imagePanel.AutoScroll = true;
            this.imagePanel.Controls.Add(this.mapPicture);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(3, 16);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(638, 370);
            this.imagePanel.TabIndex = 1;
            // 
            // mapPicture
            // 
            this.mapPicture.Location = new System.Drawing.Point(0, 0);
            this.mapPicture.Name = "mapPicture";
            this.mapPicture.Size = new System.Drawing.Size(132, 98);
            this.mapPicture.TabIndex = 1;
            this.mapPicture.TabStop = false;
            // 
            // routeDetailGroupBox
            // 
            this.routeDetailGroupBox.Controls.Add(this.label3);
            this.routeDetailGroupBox.Controls.Add(this.distance);
            this.routeDetailGroupBox.Controls.Add(this.label2);
            this.routeDetailGroupBox.Controls.Add(this.routeName);
            this.routeDetailGroupBox.Controls.Add(this.label1);
            this.routeDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.routeDetailGroupBox.Location = new System.Drawing.Point(0, 0);
            this.routeDetailGroupBox.Name = "routeDetailGroupBox";
            this.routeDetailGroupBox.Size = new System.Drawing.Size(644, 68);
            this.routeDetailGroupBox.TabIndex = 0;
            this.routeDetailGroupBox.TabStop = false;
            this.routeDetailGroupBox.Text = "Details";
            // 
            // routeName
            // 
            this.routeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.routeName.Location = new System.Drawing.Point(10, 37);
            this.routeName.Name = "routeName";
            this.routeName.ReadOnly = true;
            this.routeName.Size = new System.Drawing.Size(526, 20);
            this.routeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance:";
            // 
            // distance
            // 
            this.distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distance.Location = new System.Drawing.Point(542, 37);
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            this.distance.Size = new System.Drawing.Size(67, 20);
            this.distance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "km";
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 457);
            this.Controls.Add(this.mainPanel);
            this.Name = "RoutesForm";
            this.Text = "RoutesForm";
            this.mainPanel.ResumeLayout(false);
            this.mainSplitter.Panel1.ResumeLayout(false);
            this.mainSplitter.Panel2.ResumeLayout(false);
            this.mainSplitter.ResumeLayout(false);
            this.routesGroupBox.ResumeLayout(false);
            this.mapGroupBox.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).EndInit();
            this.routeDetailGroupBox.ResumeLayout(false);
            this.routeDetailGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}