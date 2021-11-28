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
    public partial class Players : Form
    {
        ConnectionManager conMan;
        string[] sortOptions;

        public Players(ConnectionManager cm)
        {
            conMan = cm;
            sortOptions = new string[4];
            sortOptions[0] = "Passing Touchdowns";
            sortOptions[1] = "Receiving Touchdowns";
            sortOptions[2] = "Rushing Touchdowns";
            sortOptions[3] = "Total Touchdowns";


            InitializeComponent();
            uxSortByComboBox.Items.AddRange(sortOptions);
            uxSortByComboBox.SelectedIndex = 0;
            showdata();
        }

        public void showdata()
        {
            dataGridView1.DataSource = conMan.Players(uxSortByComboBox.SelectedItem.ToString(), "desc");
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

        private void uxSortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showdata();
        }
    }
}

        /*
private void touchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
{
   sortform sf = new sortform();
   sf.Text = "Total Touchdown Leaders";
   sf.totaltouchdownleaders();
   sf.ShowDialog();
}

private void passingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
{
   sortform sf = new sortform();
   sf.Text = "Passing Touchdown Leaders";
   sf.passingtouchdownleaders();
   sf.ShowDialog();
}

private void receivingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
{
   sortform sf = new sortform();
   sf.Text = "Receiving Touchdown Leaders";
   sf.receivingtouchdownleaders();
   sf.ShowDialog();
}

private void rushingTouchdownLeadersToolStripMenuItem_Click(object sender, EventArgs e)
{
   sortform sf = new sortform();
   sf.Text = "Rushing Touchdown Leaders";
   sf.rushingtouchdownleaders();
   sf.ShowDialog();
}
*/

