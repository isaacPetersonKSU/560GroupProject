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
    public partial class TouchdownLeaders : Form
    {
        ConnectionManager conMan;
        string selectedButton = "All Touchdowns";

        public TouchdownLeaders(ConnectionManager cm)
        {
            conMan = cm;

            InitializeComponent();
            uxTotalTDRadButt.Checked = true;
            showdata();
        }

        public void showdata()
        {

            dataGridView1.DataSource = conMan.Players(selectedButton);
            dataGridView1.Refresh();
        }



        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            PlayerStats ps = new PlayerStats();
            int PlayerID = 44;
            int TeamID = (int)dataGridView1.CurrentRow.Cells[4].Value;
            ps.showdata(PlayerID, TeamID);
            ps.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Stats";
            ps.ShowDialog();
        }

        private void uxRadButtSelectionChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedButton = rb.Text;
                showdata();
            }
        }

        private void uxSearchPlayerButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conMan.SearchPlayerName(uxSearchBox.Text);
            dataGridView1.Update();
        }

        private void uxSearchTeamButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conMan.SearchTeamName(uxSearchBox.Text);
            dataGridView1.Update();
        }
    }
}
