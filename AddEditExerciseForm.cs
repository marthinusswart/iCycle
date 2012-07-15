using System;
using System.Collections;
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
    public partial class AddEditExerciseForm : Form
    {


		#region Fields(3)

        private Exercise exercise = null;
        private ExercisesDataContext exerciseDataContext = null;
        bool isNew = true;
        bool cancelEnter = false;

		#endregion Fields


		#region Constructors(1)

        public AddEditExerciseForm()
        {
            InitializeComponent();
        }

        private void PopulateTimeZone()
        {
            var timeZones = exerciseDataContext.GetTimeZones();
            foreach (var tz in timeZones)
            {
                timeZone.Items.Add(tz);
            }
        }

		#endregion Constructors


		#region Methods(12)


		//PublicMethods(2)

        public bool AddNew()
        {
            bool success = true;
            exercise = new Exercise();
            exerciseDataContext = new ExercisesDataContext();
            AddBindings();
            PopulateTimeZone();
            exercise.Id = GetNextId();
            exercise.ExerciseDate = DateTime.Now.Date;
            ShowDialog();
            return success;
        }

        public bool Edit(Exercise exercise)
        {
            bool success = true;
            this.exercise = exercise;
            AddBindings();
            isNew = false;
            return success;
        }



		//PrivateMethods(10)

        private void AddBindings()
        {
            exDate.DataBindings.Add("Text", exercise, "ExerciseDate", true);
            topSpeed.DataBindings.Add("Text", exercise, "TopSpeed", true);
            avgSpeed.DataBindings.Add("Text", exercise, "AverageSpeed", true);
            duration.DataBindings.Add("Text", exercise, "Duration", true);
            distance.DataBindings.Add("Text", exercise, "Distance", true);
            calories.DataBindings.Add("Text", exercise, "Calories", true);
            fatBurned.DataBindings.Add("Text", exercise, "FatBurned", true);
            maxHR.DataBindings.Add("Text", exercise, "MaximumHeartRate", true);
            avgHR.DataBindings.Add("Text", exercise, "AverageHeartRate", true);
            lowerZone.DataBindings.Add("Text", exercise, "ZoneLower", true);
            inZone.DataBindings.Add("Text", exercise, "DurationInZone", true);
            upperZone.DataBindings.Add("Text", exercise, "ZoneUpper", true);
        }

        private void AssignRoute()
        {
            routesListbox.Items.Clear();
            IEnumerable routes = exerciseDataContext.GetRoutes();

            foreach (var route in routes)
            {
                routesListbox.Items.Add(route);
            }

            routesListbox.SelectedIndex = 0;

            // Make the panel visible
            routesPanel.Location = new Point(255, 40);
            routesPanel.Visible = true;

            routesPanel.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DoCancel();
        }

        private void DoCancel()
        {
            Close();
        }

        private int GetNextId()
        {
            return exerciseDataContext.GetNextExerciseId(); 
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!cancelEnter)
            {
                SaveExercise();
            }
            else
            {
                cancelEnter = false;
            }
        }

        private void routeSelectButton_Click(object sender, EventArgs e)
        {
            AssignRoute();
        }

        private void routesListbox_DoubleClick(object sender, EventArgs e)
        {
            SetSelectedRoute();
        }

        private void SaveExercise()
        {
            if (isNew)
            {
                exerciseDataContext.AddExercise(exercise);
            }
            else
            {
                exerciseDataContext.EditExercise(exercise);
            }

            Close();
        }

        private void SetSelectedRoute()
        {
            if (routesListbox.SelectedItem != null)
            {
                ExerciseRoute route = (ExerciseRoute) routesListbox.SelectedItem;
                exercise.ExerciseRoute = route;
                exRoute.Text = route.Name;
            }

            routesPanel.Visible = false;
            timeZone.Focus();
        }


		#endregion Methods

        private void routesListbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
            {
                SetSelectedRoute();
                cancelEnter = true;
            }
        }

        private void timeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedTimeZone();
        }

        private void SetSelectedTimeZone()
        {
            if (timeZone.SelectedItem != null)
            {
                iCycle.Database.TimeZone tz = (iCycle.Database.TimeZone)timeZone.SelectedItem;
                exercise.TimeZone = tz;
            }
        }


    }
}
