using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace InterviewTask
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private static Model model = new Model();
        private static bool connected = false;
        private DataTable dt = new DataTable();
        private string localsQuery = "";
        private string startDateQuery = "";
        private string endDateQuery = "";

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.btnExecute.BackColor = Color.Blue;
            connected = model.ConnectToDatabase();
            if (connected)
            {
                dt = model.GetData();
                gridControl.DataSource = dt;
                cmbLocals.Properties.Items.Add("");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbLocals.Properties.Items.Add(dt.Rows[i]["Lokal"].ToString().Trim());
                }
            }
        }
        private new void Closing(object sender, FormClosingEventArgs e)
        {
            model.DisconnectDatabase();
            model.OnClose();
        }

        private void cmbLocals_SelectedIndexChanged(object sender, EventArgs e)
        {
            localsQuery = cmbLocals.SelectedItem.ToString();
        }

        private void cmbStartDate_EditValueChanged(object sender, EventArgs e)
        {
            startDateQuery = cmbStartDate.SelectedText;
        }

        private void cmbEndDate_EditValueChanged(object sender, EventArgs e)
        {
            endDateQuery = cmbEndDate.SelectedText;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string quote = "\'";
            string command = " WHERE ";

            if (startDateQuery != "" && endDateQuery != "" && localsQuery != "")
            {
                command += "Data BETWEEN " + quote + startDateQuery + quote + " AND " + quote + endDateQuery + quote + " AND Lokal = " + quote + localsQuery + quote;
            }
            else if (startDateQuery == "" && endDateQuery != "" && localsQuery != "")
            {
                command += "Data < " + quote + endDateQuery + quote + " AND Lokal = " + quote + localsQuery + quote;
            }
            else if (startDateQuery != "" && endDateQuery == "" && localsQuery != "")
            {
                command += "Data > " + quote + startDateQuery + quote + " AND Lokal = " + quote + localsQuery + quote;
            }
            else if (startDateQuery != "" && endDateQuery != "" && localsQuery == "")
            {
                command += "Data BETWEEN " + quote + startDateQuery + quote + " AND " + quote + endDateQuery + quote;
            }
            else if (startDateQuery == "" && endDateQuery == "" && localsQuery != "")
            {
                command += "Lokal = " + quote + localsQuery + quote;
            }
            else if (startDateQuery == "" && endDateQuery != "" && localsQuery == "")
            {
                command += "Data < " + quote + endDateQuery + quote;
            }
            else if (startDateQuery != "" && endDateQuery == "" && localsQuery == "")
            {
                command += "Data > " + quote + startDateQuery + quote;
            }
            else
            {
                command = "";
            }

            dt = model.GetData(command);
            gridControl.DataSource = dt;
        }
    }
}
