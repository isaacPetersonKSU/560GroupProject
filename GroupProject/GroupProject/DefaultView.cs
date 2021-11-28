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

            uxDataGrid.DataSource = conMan.SearchTeamName(uxSearchBox.Text);
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
                if (rb.Text == "Games")
                {
                    uxStartDatePicker.Enabled = true;
                    uxEndDatePicker.Enabled = true;
                    
                    uxSearchBox.Enabled = false;
                    uxSearchButton.Enabled = false;
                }
                else
                {
                    uxStartDatePicker.Enabled = false;
                    uxEndDatePicker.Enabled = false;

                    uxSearchBox.Enabled = true;
                    uxSearchButton.Enabled = true;
                }
            }
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            fillTable();
        }
    }
}
