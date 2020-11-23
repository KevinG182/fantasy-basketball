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
using Net.Code.ADONet;

namespace BaskBallDB
{
    
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        EntityState eState = EntityState.Unchanged;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (var db = DbFactory.FromConfig("con"))
            {
                playerBindingSource.DataSource = db.Sql("SELECT * FROM Player").AsEnumerable<Player>();
            }
            Player PlayerObject = playerBindingSource.Current as Player;
            panel1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                playerBindingSource.Add(new Player());
                playerBindingSource.MoveLast();
                txtPlayerID.Focus();
                dataGridView1.Refresh();
                panel1.Enabled = false;
                eState = EntityState.Added;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //db.StoredProcedure("InsertPlayer").WithParameters(new { PlayerID = newPlayer.PlayerID, PlayerName = newPlayer.PlayerName, Is_Injuried = newPlayer.Is_Injuried, Points = newPlayer.Points, Steals = newPlayer.Steals, Rebounds = newPlayer.Rebounds, Blocks = newPlayer.Blocks, Assists = newPlayer.Assists, TeamID = newPlayer.TeamID }).AsNonQuery();
            eState = EntityState.Changed;
            panel1.Enabled = true;
            txtPlayerID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want delete this player?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            { 
                try
                {
                    Player PlayerObject = playerBindingSource.Current as Player;
                    if (PlayerObject != null)
                        {
                        using (var db = DbFactory.FromConfig("con"))
                        { 
                            db.StoredProcedure("DeletePlayer").WithParameters(new { PlayerID = PlayerObject.PlayerID,}).AsNonQuery();
                            playerBindingSource.RemoveCurrent();
                            panel1.Enabled = false;
                            eState = EntityState.Unchanged;
                        }
                        }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(this, Ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Player PlayerObject = playerBindingSource.Current as Player;
            if(e.RowIndex >= 0)
            {
                txtPlayerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPlayerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                chkInjuried.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                txtPoints.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSteals.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBlocks.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRebounds.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAssists.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Player newPlayer = playerBindingSource.Current as Player;
            if(newPlayer != null)
                using (var db = DbFactory.FromConfig("con"))
                {
                    if (eState == EntityState.Added)
                    {
                        db.StoredProcedure("InsertPlayer").WithParameters(new { PlayerID = txtPlayerID.Text, PlayerName = txtPlayerName.Text, Is_Injuried = chkInjuried.Checked, Points = txtPoints.Text, Steals = txtSteals.Text, Rebounds = txtRebounds.Text, Blocks = txtBlocks.Text, Assists = txtAssists.Text, TeamID = txtTeamID.Text }).AsNonQuery();
                    }
                    if (eState == EntityState.Changed)
                    {
                        db.StoredProcedure("UpdatePlayer").WithParameters(new { PlayerID = txtPlayerID.Text, PlayerName = txtPlayerName.Text, Is_Injuried = chkInjuried.Checked, Points = txtPoints.Text, Steals = txtSteals.Text, Rebounds = txtRebounds.Text, Blocks = txtBlocks.Text, Assists = txtAssists.Text, TeamID = txtTeamID.Text }).AsNonQuery();
                    }
                }
            playerBindingSource.ResetBindings(false);
            dataGridView1.Refresh();
            panel1.Enabled = false;
            playerBindingSource.EndEdit();
        }
    }
}
