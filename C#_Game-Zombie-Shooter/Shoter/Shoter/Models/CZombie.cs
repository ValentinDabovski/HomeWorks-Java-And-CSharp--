using System;
using System.Drawing;
using Shoter.Properties;

namespace Shoter
{
    class CZombie : CImageBase
    {
        private Rectangle zombieHotSpot = new Rectangle();

        public CZombie() : base(Resources.zombie3)
        {
            zombieHotSpot.X = Left + 20;    
            zombieHotSpot.Y = Top - 1;
            zombieHotSpot.Width = 30;
            zombieHotSpot.Height = 40;
        }
        
        public void Update(int X, int Y)
        {
            Left = X;
            Top = Y;
            zombieHotSpot.X = Left + 40;  // zombie hot spot shots 
            zombieHotSpot.Y = Top - 1;
        }

        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1);

            if (zombieHotSpot.Contains(c))
            {
                return true;
            }

            return false;
        }
    }
}
