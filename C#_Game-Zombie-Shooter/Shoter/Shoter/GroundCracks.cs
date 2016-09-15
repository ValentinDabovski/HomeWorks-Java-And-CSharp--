using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoter.Properties;

namespace Shoter
{
    class GroundCracks : CImageBase
    {
        private Rectangle zombieHotSpot = new Rectangle();

       

        public GroundCracks() : base(Resources.crack3)
        {
            zombieHotSpot.X = Left + 20;
            zombieHotSpot.Y = Top - 1;
            zombieHotSpot.Width = 30;
            zombieHotSpot.Height = 40;
        }


      
    }
}
