using System;
using System.Drawing;
using Shoter.Properties;

namespace Shoter
{
    class GroundCracks : CImageBase
    {
        private Rectangle cracks = new Rectangle();
        
        public GroundCracks() : base(Resources.crack3)
        {
            cracks.X = Left + 20;
            cracks.Y = Top - 1;
            cracks.Width = 30;
            cracks.Height = 40;
        }
    }
}
