using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_racing_game
{
    class Player
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public Player() { }
        public Player(string name, string score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
