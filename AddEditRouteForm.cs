using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iCycle.Database;

namespace iCycle
{
    public partial class AddEditRouteForm : Form
    {


		#region Fields (3) 

        bool isNew = true;
        Route route = null;
        RoutesDataContext routesDataContext = null;

		#endregion Fields


		#region Constructors (1) 

        public AddEditRouteForm()
        {
            InitializeComponent();
        }

		#endregion Constructors


		#region Methods (10) 


		// Public Methods (2) 

        public bool AddNew()
        {
            bool success = true;
            ShowDialog();
            return success;
        }

        public bool Edit(Route route)
        {
            bool success = true;
            AddBindings(route);
            return success;
        }



		// Private Methods (8) 

        private void AddBindings(Route route)
        {
            this.route = route;
            name.DataBindings.Add("Text", route, "Name", true);
            distance.DataBindings.Add("Text", route, "Distance", true);
            map.Image = Utils.LoadImage(route.Map.ToArray());
        }

        private void DoLoadImage()
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                map.Load(openFileDialog.FileName);
                map.Size = map.Image.Size;
            }
        }

        private byte[] GetImageBytes()
        {
            FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            fs.Close();
            return buffer;
        }

        private int GetNextId()
        {
            RoutesDataContext routesDataContext = new RoutesDataContext();
            return routesDataContext.GetNextRouteId();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DoLoadImage();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                SaveRoute();
            }
            else
            {
                UpdateRoute();
            }
        }

        private void SaveRoute()
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Route must have a name");
            }
            else
            {
                routesDataContext = new RoutesDataContext();
                Route route = new Route();
                route.Name = name.Text;
                route.Id = GetNextId();
                route.Map = GetImageBytes();
                route.Distance = Convert.ToDecimal(distance.Text);
                routesDataContext.AddRoute(route);
                Close();
            }
        }

        private void UpdateRoute()
        {
            routesDataContext = new RoutesDataContext();
            routesDataContext.Edit(route);
        }


		#endregion Methods
 
    }
}
