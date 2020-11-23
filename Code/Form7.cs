using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace BaskBallDB
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected DataTable InitializeData(string sqlQuery, string sqlConStr)
        {
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                SqlCommand datumCommand = new SqlCommand(sqlQuery, sqlcon);
                datumCommand.CommandType = CommandType.StoredProcedure;
                DataTable datum = new DataTable();
                SqlDataAdapter datumAdapter = new SqlDataAdapter(datumCommand);
                datumAdapter.Fill(datum);

                return datum;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dgvDraftOrder.DataSource = InitializeData("", conStr);
            dgvLeagueComp.DataSource = InitializeData("", conStr);
            dgvLeagueUsers.DataSource = InitializeData("", conStr);
            dgvPointSystem.DataSource = InitializeData("",conStr);
        }
    }
}
