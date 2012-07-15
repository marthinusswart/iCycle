namespace iCycle.Database.Upgrade
{
    partial class UpgradeDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.createDBCommand = new System.Data.SqlClient.SqlCommand();
            this.databaseExistsCommand = new System.Data.SqlClient.SqlCommand();
            this.generalCommand = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=(local);Initial Catalog=iCycle;Integrated Security=True";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // createDBCommand
            // 
            this.createDBCommand.CommandText = "CREATE DATABASE iCycle;";
            this.createDBCommand.Connection = this.dbConnection;
            // 
            // databaseExistsCommand
            // 
            this.databaseExistsCommand.CommandText = "select * from sys.databases where name = \'iCycle\';";
            this.databaseExistsCommand.Connection = this.dbConnection;
            // 
            // generalCommand
            // 
            this.generalCommand.Connection = this.dbConnection;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Data.SqlClient.SqlCommand createDBCommand;
        private System.Data.SqlClient.SqlCommand databaseExistsCommand;
        private System.Data.SqlClient.SqlCommand generalCommand;
    }
}
