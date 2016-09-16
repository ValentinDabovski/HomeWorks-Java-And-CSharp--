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
        private Rectangle bloodSplats = new Rectangle();

       private static List<Bitmap> bloodSplat = new List<Bitmap>
        {
            Resources.blood_drop_splat_0001,
            Resources.blood_drop_splat_0002,
            Resources.blood_drop_splat_0003,
            Resources.blood_drop_splat_0004,
            Resources.blood_drop_splat_0005,
            Resources.blood_drop_splat_0006,
            Resources.blood_drop_splat_0007,
            Resources.blood_drop_splat_0008
        };

        public BloodSplat() : base (bloodSplat)
        {
           
        }
    }
}
