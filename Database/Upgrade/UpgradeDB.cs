using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCycle.Database.Upgrade
{
    public partial class UpgradeDB : Control
    {

        #region Constructors (1)

        public UpgradeDB()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods (2)


        // Internal Methods (2) 

        internal bool Initialize()
        {
            bool success = false;

            if (DatabaseExists())
            {
                dbConnection.ChangeDatabase("iCycle");
                success = true;
            }
            else
            {
                success = CreateDatabase();
            }
            
            return success;
        }

        private bool CreateDatabase()
        {
            bool success = false;

            if (createDBCommand.ExecuteNonQuery() == 0)
            {
                dbConnection.ChangeDatabase("iCycle");
                success = true;
            }

            return success;
        }

        private bool DatabaseExists()
        {
            bool exists = false;

            dbConnection.ConnectionString = dbConnection.ConnectionString.Replace("iCycle", "master");
            dbConnection.Open();
            SqlDataReader reader = databaseExistsCommand.ExecuteReader();
            exists = reader.HasRows;
            reader.Close();

            return exists;
        }

        private int GetDatabaseRelease()
        {
            generalCommand.CommandText = "SELECT DatabaseRelease FROM iCycleInfo";
            SqlDataReader reader = generalCommand.ExecuteReader();
            if (!reader.HasRows)
            {
                return 0;
            }
            else
            {
                reader.Read();
                return reader.GetInt32(0);
            }
        }
        internal void Upgrade()
        {
            int dbRelease = GetDatabaseRelease();
        }


        #endregion Methods

    }
}
