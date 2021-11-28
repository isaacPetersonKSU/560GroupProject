using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroupProject
{
    public partial class Players : Form
    {
        ConnectionManager conMan;
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrimaryData;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
        //SqlDataAdapter adpt;
        //DataTable dt;
        public Players(ConnectionManager cm)
        {
            conMan = cm;
            InitializeComponent();
            showdata();
        }

        public void showdata()
        {
            dataGridView1.DataSource = conMan.Players("TotalTDs", "desc");
            /*
            string sqltext = @"Select p.PlayerID, p.[Name] as Player, p.Position, T.[Name] as TeamName, p.TeamID From Season.Player P inner join Season.Team T ON T.TeamID = P.TeamID;";
            //SqlCommand mycmd = new SqlCommand("PlayerList", con);
            //mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(sqltext, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            */
        }

        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PlayerStats ps = new PlayerStats();
            int PlayerID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int TeamID = (int)dataGridView1.CurrentRow.Cells[4].Value;
            ps.showdata(PlayerID, TeamID);
            ps.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Stats";
            ps.ShowDialog();
        }


        private void touchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortform sf = new sortform();
            sf.Text = "Total Touchdown Leaders";
            sf.totaltouchdownleaders();
            sf.ShowDialog();
        }

        private void passingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortform sf = new sortform();
            sf.Text = "Passing Touchdown Leaders";
            sf.passingtouchdownleaders();
            sf.ShowDialog();
        }

        private void receivingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortform sf = new sortform();
            sf.Text = "Receiving Touchdown Leaders";
            sf.receivingtouchdownleaders();
            sf.ShowDialog();
        }

        private void rushingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortform sf = new sortform();
            sf.Text = "Rushing Touchdown Leaders";
            sf.rushingtouchdownleaders();
            sf.ShowDialog();
        }
    }
}
