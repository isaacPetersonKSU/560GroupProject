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
        ConnectionManager conMan;
        public TeamStats(ConnectionManager cm, string teamid)
        {
            conMan = cm;
            InitializeComponent();
            ShowData(teamid);
        }

        private void ShowData(string teamid)
        {
            uxDataGrid.DataSource = conMan.TeamStats(teamid);
            uxDataGrid.Refresh();
        }
    }
}
