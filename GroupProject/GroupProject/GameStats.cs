﻿using System;
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
        private ConnectionManager conMan;
        private int gameID;

        public GameStats(int gid, ConnectionManager cm)
        {
            conMan = cm;
            gameID = gid;
            InitializeComponent();

            uxAllPurpYardGrid.DataSource = conMan.AllPurposeYards(gameID);
        }
    }
}
