using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_gui_b
{
    class Player
    {
        string name;
        double score;

        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
        public string NAME { get=>name; set=>name=value; }
        public double SCORE { get=>score; set=>score=value; }
    }
}
