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

        private void showdata()
        {

            dataGridView1.DataSource = conMan.TouchDownLeaders(selectedButton);
            dataGridView1.Refresh();
        }

        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
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
    }
}
