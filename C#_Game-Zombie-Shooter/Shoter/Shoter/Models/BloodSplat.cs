using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoter.Properties;
using System.Drawing;

namespace Shoter
{
    class BloodSplat : CImageBase
    {
        private Rectangle bloodSplat = new Rectangle();
        public BloodSplat() : base(Resources.blood_drop_splat_0002)
        {
            bloodSplat.X = Left + 20;
            bloodSplat.Y = Top - 1;
            bloodSplat.Width = 30;
            bloodSplat.Height = 40;
        }
    }
}
