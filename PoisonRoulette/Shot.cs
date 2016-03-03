using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonRoulette
{
    public class Shot : Drink
    {
        //Class Properties/Fields
        public bool Poison { get; set; }

        //Class constructor chaining, takes Image and passes it to base class constructor
        public Shot(Image i) : base(i)
        {
            this.Poison = false;
            this.Picture.Size = new Size(65, 110);
        }

        public Shot()
        {
        }
    }
}
