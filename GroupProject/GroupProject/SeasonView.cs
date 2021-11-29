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

    public partial class SeasonView : Form
    {
        private DVState state;
        private ConnectionManager conMan;

        public SeasonView(ConnectionManager cm)
        {
            conMan = cm;
            InitializeComponent();
            uxDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            fillTable();
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
                    uxDataGrid.DataSource = conMan.AllGames
                        (uxStartDatePicker.Value, uxEndDatePicker.Value);
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
                switch (rb.Text)
                {
                    case "Games":
                        uxSearchBox.Visible = false;
                        uxStartDatePicker.Visible = true;
                        uxEndDatePicker.Visible = true;
                        uxDateLabel2.Visible = true;
                        state = DVState.Games;
                        break;
                    case "Players":
                        uxSearchBox.Visible = true;
                        uxStartDatePicker.Visible = false;
                        uxEndDatePicker.Visible = false;
                        uxDateLabel2.Visible = false;
                        state = DVState.Players;
                        break;
                    case "Teams":
                        uxSearchBox.Visible = true;
                        uxStartDatePicker.Visible = false;
                        uxEndDatePicker.Visible = false;
                        uxDateLabel2.Visible = false;
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

        
        private void uxDataGrid_CellMouseClick(object sender, EventArgs e)
        {
            switch (state)
            {
                case DVState.Players:
                    int playerID = (int)uxDataGrid.CurrentRow.Cells[3].Value;
                    new PlayerStats(playerID, conMan).Show();
                    break;
                case DVState.Teams:
                    int teamID = (int)uxDataGrid.CurrentRow.Cells[2].Value;
                    new TeamStats(teamID, conMan).Show();
                    break;
                case DVState.Games:
                    int gameID = (int)uxDataGrid.CurrentRow.Cells[3].Value;
                    new GameStats(gameID, conMan).Show();
                    break;
            }
        }
    }
}
