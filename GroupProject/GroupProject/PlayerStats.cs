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
        ConnectionManager conMan;
        public PlayerStats(ConnectionManager cm, int playerid)
        {
            conMan = cm;
            InitializeComponent();
            ShowData(playerid);
        }
        private void ShowData(int playerid)
        {
            uxDataGrid.DataSource = conMan.PlayerStats(playerid);
            uxDataGrid.Refresh();
        }
    }
}
