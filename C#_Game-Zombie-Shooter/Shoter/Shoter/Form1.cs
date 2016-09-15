#define My_Debug



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoter
{
    public partial class Shooter : Form
    {
        private int cursX = 0;
        private int cursY = 0;

        CZombie zombie;
        GroundCracks craks;

        public Shooter()
        {
            InitializeComponent();
            zombie = new CZombie() { Left = 280, Top = 400 };
            craks = new GroundCracks() { Left = 180, Top = 200 };
            
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font font = new System.Drawing.Font("Stemcil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "x=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(), font, new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif
            zombie.DrawImage(dc);

            base.OnPaint(e);
        }

        private void Shooter_MouseMove(object sender, MouseEventArgs e)
        {
            cursX = e.X;
            cursY = e.Y;

            this.Refresh();
        }
    }
}
