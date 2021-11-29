using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Player
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int TeamID { get; private set; }
        public string TeamName { get; private set; }
        public string Position { get; private set; }

        public Player(int id, string n, int tid, string tn, string pos)
        {
            ID = id;
            Name = n;
            TeamID = tid;
            TeamName = tn;
            Position = pos;
        }

        public override string ToString()
        {
            return Name + " : " + TeamName + " " + Position;
        }
    }
}
