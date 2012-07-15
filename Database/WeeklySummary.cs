using System.Collections;
using System.Linq;

namespace iCycle.Database
{
    partial class WeeklySummaryDataContext
    {

		#region Methods (3) 


		// Public Methods (1) 

        public IEnumerable GetSummaries()
        {
            var summaries = from sums in WeeklyZoneSummaries select sums;
            return summaries;
        }



		// Internal Methods (2) 

        internal void AddWeeklySummary(WeeklyZoneSummary summary)
        {
            WeeklyZoneSummaries.InsertOnSubmit(summary);
            SubmitChanges();
        }

        internal int GetNextWeeklySummaryId()
        {
            var wks = from wk in WeeklyZoneSummaries select wk.Id;
            int id = 0;

            foreach (var wid in wks)
            {
                if (wid > id)
                {
                    id = wid;
                }
            }

            return id + 1;
        }


		#endregion Methods 

    }
}
