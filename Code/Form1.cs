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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //protected DataTable InitializeData(string sqlQuery, string sqlConStr)
            {
                using (SqlConnection sqlcon = new SqlConnection(conStr))
                {
                    sqlcon.Open();
                    SqlCommand datumCommand = new SqlCommand("checkCredentials", sqlcon);
                    datumCommand.CommandType = CommandType.StoredProcedure;
                    datumCommand.Parameters.Add(new SqlParameter("@Username", txtUser.Text));
                    datumCommand.Parameters.Add(new SqlParameter("@Password", txtPass.Text));
                    //DataTable datum = new DataTable();

                    SqlDataReader datumReader = datumCommand.ExecuteReader();

                    if (datumReader.HasRows == true)
                    {
                        MessageBox.Show(this, "Login Successfull", "Message!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(this, "Login unSuccessfull", "Message!", MessageBoxButtons.OK);

                    }
                    sqlcon.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }
    }
}
