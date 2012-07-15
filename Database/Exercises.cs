using System;
using System.Collections;
using System.Linq;
using System.Drawing;

namespace iCycle.Database
{
    partial class ExercisesDataContext
    {

		#region Methods (5) 


		// Public Methods (1) 

        public IEnumerable GetRoutes()
        {
            var routes = from rt in ExerciseRoutes select rt;
            return routes;
        }

        public IEnumerable GetTimeZones()
        {
            var timeZones = from tz in TimeZones select tz;
            return timeZones;
        }

		// Internal Methods (4) 

        internal void AddExercise(Exercise exercise)
        {
            Exercises.InsertOnSubmit(exercise);
            SubmitChanges();
        }

        internal void EditExercise(Exercise exercise)
        {
            UpdateExercise(exercise);
        }

        internal IEnumerable GetExercises()
        {
            var exercises = from exs in Exercises select exs;
            return exercises;
        }

        internal int GetNextExerciseId()
        {
            var exs = from ex in Exercises select ex.Id;
            int id = 0;

            foreach (var eid in exs)
            {
                if (eid > id)
                {
                    id = eid;
                }
            }

            return id + 1;
        }


		#endregion Methods 

    }

    public partial class Exercise
    {

		#region Properties (1) 

        public string RouteName
        {
            get
            {
                if (ExerciseRoute != null)
                {
                    return ExerciseRoute.Name;
                }
                else
                {
                    return "None specified";
                }
            }
        }

        public string TimeZoneName
        {
            get
            {
                if (TimeZone != null)
                {
                    return TimeZone.Name;
                }
                else
                {
                    return "None specified";
                }
            }
        }
		#endregion Properties 

    }
}
