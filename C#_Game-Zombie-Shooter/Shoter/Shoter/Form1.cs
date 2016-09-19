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
using Shoter.Properties;
using System.Media;

namespace Shoter
{
    public partial class Shooter : Form
    {
        private int cursX = 0;
        private int cursY = 0;

        CZombie zombie;
        GroundCracks craks;
        InGameMenu zombieHoldingMenu;
        ScoreTable scoreTable;

        public Shooter()
        {
            InitializeComponent();

            // Bitmap bmp = new Bitmap(Resources.gunSight_red);
            //  this.Cursor = CustomCursor.CreateCursor(bmp, bmp.Height, bmp.Width);


            zombie = new CZombie() { Left = 300, Top = 400 };
            craks = new GroundCracks() { Left = 280, Top = 400 };
            zombieHoldingMenu = new InGameMenu() { Left = 1120, Top = 470 };
            scoreTable = new ScoreTable() { Left = 1078, Top = 105 };
            
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

            craks.DrawImage(dc);

            zombieHoldingMenu.DrawImage(dc);

            scoreTable.DrawImage(dc);

            base.OnPaint(e);
        }

        private void Shooter_MouseMove(object sender, MouseEventArgs e)
        {
            cursX = e.X;
            cursY = e.Y;

            this.Refresh();
        }

        private void Shooter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 1150 && e.X < 1220 && e.Y > 560 && e.Y < 575)
            {
                timerGameLoop.Start();
            }

            else if (e.X > 1165 && e.X < 1210 && e.Y > 605 && e.Y < 616)
            {
                timerGameLoop.Stop();
            }

            else if (e.X > 1168 && e.X < 1205 && e.Y > 645 && e.Y < 652)
            {
                timerGameLoop.Stop();
            }

            GunFire();
        }

        private void GunFire()
        {
            SoundPlayer sound = new SoundPlayer(Resources.shotgun_spas_12_RA_The_Sun_God_503834910);
            sound.Play();
        }
    }
}
