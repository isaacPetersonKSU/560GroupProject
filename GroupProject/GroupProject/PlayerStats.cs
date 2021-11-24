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
    public partial class PlayerStats : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrimaryData;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
        SqlDataAdapter adpt= new SqlDataAdapter();
        DataTable dt;
        public PlayerStats()
        {
            InitializeComponent();
        }
        public void showdata(int PlayerID)
        {
            string sqltext = @"select * from Season.PlayerGame 
                                where PlayerID=@PlayerID";
            dt = new DataTable();
            using(SqlDataAdapter adpt = new SqlDataAdapter(sqltext, con))
            {
                adpt.SelectCommand.Parameters.Add("@PlayerID",
                    SqlDbType.Int).Value = PlayerID;
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
