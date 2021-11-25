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
    public partial class sortform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrimaryData;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
        SqlDataAdapter adpt;
        DataTable dt;
        public sortform()
        {
            InitializeComponent();
        }

        public void totaltouchdownleaders()
        {
            SqlCommand mycmd = new SqlCommand("Season.usp_PlayersByTouchdowns", con);
            mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(mycmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void passingtouchdownleaders()
        {
            SqlCommand mycmd = new SqlCommand("Season.usp_PlayersByPassingTouchdowns", con);
            mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(mycmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void receivingtouchdownleaders()
        {
            SqlCommand mycmd = new SqlCommand("Season.usp_PlayersByReceivingTouchdowns", con);
            mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(mycmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void rushingtouchdownleaders()
        {
            SqlCommand mycmd = new SqlCommand("Season.usp_PlayersByRushingTouchdowns", con);
            mycmd.CommandType = CommandType.StoredProcedure;
            adpt = new SqlDataAdapter(mycmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
