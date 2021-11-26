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
        public void showdata(int PlayerID, int TeamID)
        {
            string sqltext = @"SELECT p.GameID, p.PlayerID, TA.[Name] as OPPTeam, p.PassingYards, p.PassingTouchdowns, p. InterceptionsThrown, p.RushAttempts, p.RushingYards, p.RushingTouchdowns, p.Receptions, p.ReceivingYards, p.ReceivingTouchdowns, p.Fumbles, T.Score
            FROM [PrimaryData].[Season].[PlayerGame] p
            inner join season.TeamGame T ON T.GameID = P.GameID
            inner join season.Team TA On TA.TeamID = T.TeamID
            where p.PlayerID = @PlayerID
            and T.TeamID != @TeamID;";
            dt = new DataTable();
            using(SqlDataAdapter adpt = new SqlDataAdapter(sqltext, con))
            {
                adpt.SelectCommand.Parameters.Add("@PlayerID",
                    SqlDbType.Int).Value = PlayerID;
                adpt.SelectCommand.Parameters.Add("@TeamID",
                    SqlDbType.Int).Value = TeamID;
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
