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
    public partial class GameStats : Form
    {
        ConnectionManager conMan;
        public GameStats(ConnectionManager cm, int gameid)
        {
            conMan = cm;
            InitializeComponent();
            //ShowData(gameid);
        }
        public string HomeLabelText
        {
            get
            {
                return this.uxHomeLabel.Text;
            }
            set
            {
                this.uxHomeLabel.Text = value;
            }
        }
        public string AwayLabelText
        {
            get
            {
                return this.uxAwayLabel.Text;
            }
            set
            {
                this.uxAwayLabel.Text = value;
            }
        }
    }
}
