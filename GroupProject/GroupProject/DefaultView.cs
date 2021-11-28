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
    public partial class DefaultView : Form
    {
        private ConnectionManager conMan;

        private TouchdownLeaders tdl;


        public DefaultView(ConnectionManager cm)
        {
            conMan = cm;
            tdl = new TouchdownLeaders(conMan);

            InitializeComponent();
            showPlayers();
        }

        private void showPlayers()
        {
            uxDataGrid.DataSource = conMan.SearchPlayerName(uxSearchBox.Text);
            uxDataGrid.Refresh();
        }

        private void showTeams()
        {
            uxDataGrid.DataSource = conMan.SearchTeamName(uxSearchBox.Text);
            uxDataGrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTeams();
        }

        private void uxTDLButton_Click(object sender, EventArgs e)
        {
            tdl.Show();
        }
    }
}
