using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoisonRoulette
{
    public class Drink
    {
        //Class Properties/Fields
        public PictureBox Picture { get; set; }

        //Class constructor, requires an Image object
        public Drink(Image i)
        {
            this.Picture = new PictureBox();
            this.Picture.Image = i;
            this.Picture.SizeMode= PictureBoxSizeMode.StretchImage;
        }

        //Parameterless constructor, creates an empty object
        public Drink()
        {

        }
    }
}
