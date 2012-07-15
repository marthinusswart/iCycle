using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCycle
{
    public partial class MainForm : Form
    {


        #region Fields (3) 

        private ExercisesForm exercisesForm = null;
        private RoutesForm routesForm = null;
        private WeeklySummaryForm weeklySummaryForm = null;

		#endregion Fields


		#region Constructors (1) 

        public MainForm()
        {
            InitializeComponent();
        }

		#endregion Constructors


		#region Methods (21) 


		// Private Methods (21) 

        private void AddExercisesTab()
        {
            if (exercisesForm == null)
            {
                exercisesForm = new ExercisesForm();
                Panel mainPanel = exercisesForm.MainPanel;
                TabPage page = new TabPage("Exercises");
                page.Name = "Exercises";
                page.Controls.Add(mainPanel);
                mainTabControl.TabPages.Add(page);
            }
            else
            {
                exercisesForm.Reload();
            }

            mainTabControl.SelectedTab = GetTab("Exercises");

        }

        private void AddNewExcersize()
        {
            AddEditExerciseForm addEditExcersizeForm = new AddEditExerciseForm();
            addEditExcersizeForm.AddNew();
        }

        private void addNewExcersizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewExcersize();
        }

        private void AddNewRoute()
        {
            AddEditRouteForm newRouteForm = new AddEditRouteForm();
            newRouteForm.AddNew();
        }

        private void addNewRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewRoute();
            
        }

        private void AddRouteTab()
        {
            if (routesForm == null)
            {
                routesForm = new RoutesForm();
                Panel mainPanel = routesForm.MainPanel;
                TabPage page = new TabPage("Routes");
                page.Name = "Routes";
                page.Controls.Add(mainPanel);
                mainTabControl.TabPages.Add(page);
            }
            else
            {
                routesForm.Reload();
            }

            mainTabControl.SelectedTab = GetTab("Routes");
        }

        private void AddWeeklySummariesTab()
        {
            if (weeklySummaryForm == null)
            {
                weeklySummaryForm = new WeeklySummaryForm();
                Panel mainPanel = weeklySummaryForm.MainPanel;
                TabPage page = new TabPage("Weekly Summary");
                page.Name = "Weekly Summary";
                page.Controls.Add(mainPanel);
                mainTabControl.TabPages.Add(page);
            }
            else
            {
                weeklySummaryForm.Reload();
            }

            mainTabControl.SelectedTab = GetTab("Weekly Summary");
        }

        private void AddWeeklySummary()
        {
            AddEditWeeklySummaryForm newSummaryForm = new AddEditWeeklySummaryForm();
            newSummaryForm.AddNew();
        }

        private void EditExcersize()
        {
            AddEditExerciseForm addEditExcersizeForm = new AddEditExerciseForm();
        }

        private void editExcersizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditExcersize();
        }

        private void EditRoute()
        {
            AddEditRouteForm newRouteForm = new AddEditRouteForm();
        }

        private void editRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRoute();
        }

        private void exercisesButton_Click(object sender, EventArgs e)
        {
            AddExercisesTab();
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExercisesTab();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private TabPage GetTab(string name)
        {
            return mainTabControl.TabPages[name];
        }

        private void routesButton_Click(object sender, EventArgs e)
        {
            AddRouteTab();
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRouteTab();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddWeeklySummary();
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            AddWeeklySummariesTab();
        }

        private void weeklySummariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWeeklySummariesTab();
        }


		#endregion Methods

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iCycle version 0.1");
        }
 
    }
}
