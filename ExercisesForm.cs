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
    public partial class ExercisesForm : Form
    {


		#region Properties(1)

        public Panel MainPanel
        {
            get
            {
                return mainPanel;
            }
        }

		#endregion Properties


		#region Methods(2)


        private void LoadData()
        {
            ExercisesDataContext exercisesDataContext = new ExercisesDataContext();
            IEnumerable excersizes = exercisesDataContext.GetExercises();
            excersizesGrid.AutoGenerateColumns = false;
            excersizesGrid.DataSource = excersizes;
        }



        internal void Reload()
        {
            LoadData();
        }


		#endregion Methods


		#region Constructors(1)

        public ExercisesForm()
        {
            InitializeComponent();
            LoadData();
        }

		#endregion Constructors

    }
}
