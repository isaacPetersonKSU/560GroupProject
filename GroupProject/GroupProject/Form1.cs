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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrimaryData;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
        SqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        public void showdata()
        {
            SqlCommand mycmd = new SqlCommand("PlayerList", con);
            mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(mycmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
