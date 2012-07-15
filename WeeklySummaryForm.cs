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
    public partial class WeeklySummaryForm : Form
    {


		#region Constructors (1) 

        public WeeklySummaryForm()
        {
            InitializeComponent();
            LoadData();
        }

		#endregion Constructors


		#region Properties (1) 

        public Panel MainPanel
        {
            get
            {
                return mainPanel;
            }
        }

		#endregion Properties


		#region Methods (2) 


		// Private Methods (1) 

        private void LoadData()
        {
            WeeklySummaryDataContext weeklySummaryDataContext = new WeeklySummaryDataContext();
            IEnumerable weeklySummaries = weeklySummaryDataContext.GetSummaries();
            weeklySummaryGrid.AutoGenerateColumns = false;
            weeklySummaryGrid.DataSource = weeklySummaries;
        }



		// Internal Methods (1) 

        internal void Reload()
        {
            LoadData();
        }


		#endregion Methods
 
    }
}
