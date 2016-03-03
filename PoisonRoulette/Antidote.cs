using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonRoulette
{
    public class Antidote : Drink
    {
        //Class constructor chaining, takes Image and passes it to base class constructor
        public Antidote(Image i) : base(i)
        {
            Picture.Image = i;
            Picture.Size = new Size(100, 100);
        }
        //Default contructor
        public Antidote()
        {
        }

        public void DrinkAntidote(Player p)
        {
            p.ToggleInvincible();
        }
    }
}
