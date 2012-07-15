using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iCycle.Database.Upgrade;

namespace iCycle
{
    static class Program
    {


		#region Methods (1) 


		// Private Methods (1) 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UpgradeDB upgradeDB = new UpgradeDB();
            if (upgradeDB.Initialize())
            {
                upgradeDB.Upgrade();
            }

            Application.Run(new MainForm());
        }


		#endregion Methods
 
    }
}
