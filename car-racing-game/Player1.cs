using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_racing_game
{
    class Player1
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public string Time { get; set; }
        public Player1() { }
        public Player1(string name, string score, string time)
        {
            this.Name = name;
            this.Score = score;
            this.Time = time;
        }
    }
}
