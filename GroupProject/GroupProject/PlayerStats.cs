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
        private ConnectionManager conMan;
        private Player player;

        public PlayerStats(int id, ConnectionManager cm)
        {
            conMan = cm;
            player = conMan.PlayerFromID(id);
            InitializeComponent();

            uxPlayerLabel.Text = player.ToString();

            uxDataTable.DataSource = conMan.PlayerStats(player.ID, player.TeamID);
            uxDataTable.Refresh();
        }
    }
}
