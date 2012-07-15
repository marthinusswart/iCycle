using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using iCycle.Database;

namespace iCycle
{
    public partial class RoutesForm : Form
    {

		#region Constructors (1) 

        public RoutesForm()
        {
            InitializeComponent();
            LoadRoutes();
        }

		#endregion Constructors 

		#region Properties (1) 

        public Panel MainPanel
        {
            get
            {
                return mainPanel;
            }
        }

		#endregion Properties 

		#region Methods (4) 


		// Private Methods (3) 

        private void LoadRoutes()
        {
            RoutesDataContext routesDataContext = new RoutesDataContext();
            IEnumerable routes = routesDataContext.GetRoutes();

            foreach (var route in routes)
            {
                routesListBox.Items.Add(route);
            }

            routesListBox.SelectedIndex = 0;
            UpdateDetails();
        }

        private void routesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            if (routesListBox.SelectedItem != null)
            {
                Route route = (Route) routesListBox.SelectedItem;
                routeName.Text = route.Name;
                distance.Text = Convert.ToString(route.Distance);
                mapPicture.Image = Utils.LoadImage(route.Map.ToArray());
                mapPicture.Size = mapPicture.Image.Size;
            }
        }



		// Internal Methods (1) 

        internal void Reload()
        {
            routesListBox.Items.Clear();
            LoadRoutes();
        }


		#endregion Methods 

    }
}
