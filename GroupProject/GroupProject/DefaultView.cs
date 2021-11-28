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
    public enum DVState
    {
        Players,
        Teams,
        Games
    }

    public partial class DefaultView : Form
    {
        private DVState state;
        private ConnectionManager conMan;

        public DefaultView(ConnectionManager cm)
        {
            conMan = cm;
            InitializeComponent();
            showPlayers();
        }

        private void showPlayers()
        {
            uxDataGrid.DataSource = conMan.SearchPlayerName(uxSearchBox.Text);
            uxDataGrid.Refresh();
        }

        private void fillTable()
        {
            switch (state)
            {
                case DVState.Players:
                    uxDataGrid.DataSource = conMan.SearchPlayerName(uxSearchBox.Text);
                    break;
                case DVState.Teams:
                    uxDataGrid.DataSource = conMan.SearchTeamName(uxSearchBox.Text);
                    break;
                case DVState.Games:
                    uxDataGrid.DataSource = conMan.AllGames();
                    break;
            }
            
            uxDataGrid.Refresh();
        }

        private void uxTDLButton_Click(object sender, EventArgs e)
        {
            new TouchdownLeaders(conMan).Show();
        }

        private void uxRadButts_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                uxSearchBox.Clear();
                uxSearchBox.Enabled = true;
                uxSearchButton.Enabled = true;
                switch (rb.Text)
                {
                    case "Games":
                        uxSearchBox.Enabled = false;
                        uxSearchButton.Enabled = false;
                        state = DVState.Games;
                        break;
                    case "Players":
                        state = DVState.Players;
                        break;
                    case "Teams":
                        state = DVState.Teams;
                        break;
                }
                fillTable();
            }
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void uxDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
