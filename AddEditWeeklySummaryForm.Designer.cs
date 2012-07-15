namespace iCycle
{
    partial class AddEditWeeklySummaryForm
    {

		#region Fields (16) 

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox hardZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lightZone;
        private System.Windows.Forms.TextBox moderateZone;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DateTimePicker summaryDate;
        private System.Windows.Forms.GroupBox weeklyBox;

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
            this.weeklyBox = new System.Windows.Forms.GroupBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.summaryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lightZone = new System.Windows.Forms.TextBox();
            this.hardZone = new System.Windows.Forms.TextBox();
            this.moderateZone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weeklyBox.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weeklyBox
            // 
            this.weeklyBox.Controls.Add(this.label7);
            this.weeklyBox.Controls.Add(this.label6);
            this.weeklyBox.Controls.Add(this.label5);
            this.weeklyBox.Controls.Add(this.moderateZone);
            this.weeklyBox.Controls.Add(this.hardZone);
            this.weeklyBox.Controls.Add(this.lightZone);
            this.weeklyBox.Controls.Add(this.label4);
            this.weeklyBox.Controls.Add(this.label3);
            this.weeklyBox.Controls.Add(this.label2);
            this.weeklyBox.Controls.Add(this.summaryDate);
            this.weeklyBox.Controls.Add(this.label1);
            this.weeklyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyBox.Location = new System.Drawing.Point(0, 0);
            this.weeklyBox.Name = "weeklyBox";
            this.weeklyBox.Size = new System.Drawing.Size(357, 166);
            this.weeklyBox.TabIndex = 0;
            this.weeklyBox.TabStop = false;
            this.weeklyBox.Text = "Weekly Summary";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 132);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(357, 34);
            this.buttonPanel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(108, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(186, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week start:";
            // 
            // summaryDate
            // 
            this.summaryDate.Location = new System.Drawing.Point(159, 21);
            this.summaryDate.Name = "summaryDate";
            this.summaryDate.Size = new System.Drawing.Size(151, 20);
            this.summaryDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration in light zone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration in moderate zone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duration in hard zone:";
            // 
            // lightZone
            // 
            this.lightZone.Location = new System.Drawing.Point(159, 47);
            this.lightZone.Name = "lightZone";
            this.lightZone.Size = new System.Drawing.Size(151, 20);
            this.lightZone.TabIndex = 1;
            // 
            // hardZone
            // 
            this.hardZone.Location = new System.Drawing.Point(159, 99);
            this.hardZone.Name = "hardZone";
            this.hardZone.Size = new System.Drawing.Size(151, 20);
            this.hardZone.TabIndex = 3;
            // 
            // moderateZone
            // 
            this.moderateZone.Location = new System.Drawing.Point(159, 73);
            this.moderateZone.Name = "moderateZone";
            this.moderateZone.Size = new System.Drawing.Size(151, 20);
            this.moderateZone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "h:m:s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "h:m:s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "h:m:s";
            // 
            // AddEditWeeklySummaryForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(357, 166);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.weeklyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEditWeeklySummaryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new weekly summary";
            this.weeklyBox.ResumeLayout(false);
            this.weeklyBox.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}