using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonRoulette
{
    public class Player
    {
        //Class Properties/Fields
        public bool Invincible { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        //Default constructor to create a new instance of player.
        public Player()
        {
            this.Invincible = false;
            this.Wins = 0;
            this.Losses = 0;
        }

        public void Win()
        {
            this.Wins++;
        }

        public void Lose()
        {
            this.Losses++;
        }

        public void ToggleInvincible()
        {
            if (Invincible)
            {
                Invincible = false;
            }
            else Invincible = true;
        }
    }
}
