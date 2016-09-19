using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoter.Properties;

namespace Shoter
{
    class ScoreTable : CImageBase
    {
        private Rectangle scoreTable = new Rectangle();

        public ScoreTable() : base(Resources.ScoreSign)
        {
            scoreTable.X = Left;
            scoreTable.Y = Top;
            scoreTable.Width = 30;
            scoreTable.Height = 40;
        }
    }
}
