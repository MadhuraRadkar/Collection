using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonPlayerArray
{
    internal class Player
    {
        int player_Id;
        string player_name;
        int runs;
        public Player(int player_Id, string player_name, int runs)
        {
            this.Player_Id = player_Id;
            this.Player_name = player_name;
            this.Runs = runs;
        }
        public override string ToString()
        {
            return player_Id+" " + player_name+" "+ runs;
        }
        public int Player_Id { get=>player_Id; set=>player_Id=value; }
        public string Player_name { get=>player_name; set=>player_name=value; }
        public int Runs { get=>runs; set=>runs=value; }
    }
}
