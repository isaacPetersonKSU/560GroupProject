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
    public partial class PlayerView : Form
    {
        private ConnectionManager conMan;

        private int ID;
        private string name;
        private int teamID;
        private string team;
        private string position;


        public PlayerView(ConnectionManager cm, int playerID)
        {
            conMan = cm;
            InitializeComponent();

        }

        public override string ToString()
        {
            return name + ": " + team + " " + position;
        }
    }
}
