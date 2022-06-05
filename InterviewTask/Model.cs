using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterviewTask
{
    public class Model
    {
        private static SqlConnection conn = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

        public bool ConnectToDatabase()
        {
            try
            {
                conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Dev\\InterviewTask\\InterviewTask\\EksportDB.mdf; Integrated Security = True");
                conn.Open();
                return true;
            }
            catch (SqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void DisconnectDatabase()
        {
            conn.Close();
        }

        public DataTable GetData(string range = "")
        {
            try
            {
                string command = "SELECT Nazwa, Data, Godzina, Użytkownik, Lokal FROM ExportHistory" + range;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }

        public void OnClose()
        {
            Application.Exit();
            Environment.Exit(0);
        }

    }
}
