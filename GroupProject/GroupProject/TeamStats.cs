using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class TeamStats : Form
    {
        private ConnectionManager conMan;
        private int teamID;

        public TeamStats(int tid, ConnectionManager cm)
        {
            teamID = tid;
            conMan = cm;
            InitializeComponent();


            uxTeamTotalsLabel.Text = conMan.TeamName(teamID) + " Team totals";
            uxTeamTotalGrid.DataSource = conMan.TeamTotals(teamID);
            uxPlayerList.DataSource = conMan.TeamPlayers(teamID);
        }
    }
}
