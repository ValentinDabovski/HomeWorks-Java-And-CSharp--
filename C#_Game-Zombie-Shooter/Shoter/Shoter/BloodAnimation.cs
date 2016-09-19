using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoter.Properties;

namespace Shoter
{
    class BloodAnimation
    {
        private Bitmap[] images;

        private Rectangle bloodSpaltsRectangle = new Rectangle();

        private int place = 0;
        public BloodAnimation(Bitmap[] Frames)
        {
            images = Frames;
        }

        public Bitmap GiveNextImage()
        {
            Bitmap bmp;

            if (place < images.Length)
            {
                bmp = images[place++];

            
                
                bloodSpaltsRectangle.X =  + 20;
                bloodSpaltsRectangle.Y =  - 1;
                bloodSpaltsRectangle.Width = 5;
                bloodSpaltsRectangle.Height = 5;
            }

            else
            {
                place = 0;
                bmp = images[place++];
            }

            return bmp;
        }
    }
}
