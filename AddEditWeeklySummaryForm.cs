using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iCycle.Database;

namespace iCycle
{
    public partial class AddEditWeeklySummaryForm : Form
    {


		#region Fields (2) 

        private WeeklyZoneSummary summary = null;
        private WeeklySummaryDataContext weeklySummaryDataContext = null;

		#endregion Fields


		#region Constructors (1) 

        public AddEditWeeklySummaryForm()
        {
            InitializeComponent();
        }

		#endregion Constructors


		#region Methods (6) 


		// Public Methods (1) 

        public bool AddNew()
        {
            bool success = true;
            summary = new WeeklyZoneSummary();
            weeklySummaryDataContext = new WeeklySummaryDataContext();
            AddBindings();
            summary.Id = GetNextId();
            summary.WeekStartDate = DateTime.Now;
            ShowDialog();
            return success;
        }



		// Private Methods (5) 

        private void AddBindings()
        {
            summaryDate.DataBindings.Add("Text",summary, "WeekStartDate", true);
            lightZone.DataBindings.Add("Text", summary, "DurationLightZone", true);
            moderateZone.DataBindings.Add("Text", summary, "DurationModerateZone", true);
            hardZone.DataBindings.Add("Text", summary, "DurationHardZone", true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GetNextId()
        {
            return weeklySummaryDataContext.GetNextWeeklySummaryId();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSummary();
        }

        private void SaveSummary()
        {
            weeklySummaryDataContext.AddWeeklySummary(summary);
            Close();
        }


		#endregion Methods
 
    }
}
