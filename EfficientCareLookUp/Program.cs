using EfficientCareLookUp.Config;
using EfficientCareLookUp.Database;
using EfficientCareLookUp.Forms;
using EfficientCareLookUp.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfficientCareLookUp
{
    static class Program
    {

        private static Postgres postgres;
        private static OracleDB oracle;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            postgres = new Postgres(LoadPostgresConfig());
            oracle = new OracleDB(LoadOracleConfig());

            TestDatabaseConnections();

            postgres.OpenConnection();
            oracle.OpenConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(postgres, oracle));
        }

        private static OracleConfig LoadOracleConfig()
        {
            return new OracleConfig(
                Properties.Settings.Default.ORACLE_HOST,
                Properties.Settings.Default.ORACLE_SID,
                Properties.Settings.Default.ORACLE_PORT,
                Properties.Settings.Default.ORACLE_USERNAME,
                Properties.Settings.Default.ORACLE_PASSWORD
                );
        }

        private static PostgresConfig LoadPostgresConfig()
        {
            return new PostgresConfig(
                Properties.Settings.Default.POSTGRES_HOST,
                Properties.Settings.Default.POSTGRES_DATABASE,
                Properties.Settings.Default.POSTGRES_PORT,
                Properties.Settings.Default.POSTGRES_USERNAME,
                Properties.Settings.Default.POSTGRES_PASSWORD
                );
        }

        /// <summary>
        /// Test for connection to the database
        /// </summary>
        private static void TestDatabaseConnections()
        {
            try
            {
                // Test postgres
                postgres.TestConnection();

                // Test Oracle
                oracle.TestConnection();
            }
            catch (Exception c)
            {
                // Could not connect, display message and close program
                MessageBox.Show("Unable to connect to database: " + c.Message + " Connecion String => " + oracle.ConnectionObj.ConnectionString, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Force the application to close
                Environment.Exit(0);
            }
        }

    }
}
