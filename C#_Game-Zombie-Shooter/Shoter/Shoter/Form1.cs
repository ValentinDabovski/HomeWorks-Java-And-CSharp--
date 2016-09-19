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
        bool splat = false;

        int gameFrame = 0;
        int splatTime = 0;

        private int cursX = 0;
        private int cursY = 0;

        CZombie zombie;
        GroundCracks craks;
        InGameMenu zombieHoldingMenu;
        ScoreTable scoreTable;
         BloodSplat bloodSplat;

        BloodAnimation bloodAnimation;
        
        Random random = new Random();

        public Shooter()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(Resources.gunSight_red);
            this.Cursor = CustomCursor.CreateCursor(bmp, bmp.Height / 2, bmp.Width / 2);


            zombie = new CZombie() { Left = 300, Top = 400 };
            craks = new GroundCracks() { Left = 280, Top = 400 };
            zombieHoldingMenu = new InGameMenu() { Left = 1120, Top = 470 };
            scoreTable = new ScoreTable() { Left = 1078, Top = 105 };
            bloodSplat = new BloodSplat();
            bloodAnimation = new BloodAnimation(new Bitmap[] {Resources.blood_drop_splat_0001,
              Resources.blood_drop_splat_0002,
              Resources.blood_drop_splat_0003,
              Resources.blood_drop_splat_0004,
              Resources.blood_drop_splat_0005,
              Resources.blood_drop_splat_0006,
              Resources.blood_drop_splat_0007,
              Resources.blood_drop_splat_0008});

        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            if (gameFrame >= 15)
            {
                UpdateZombie();
                gameFrame = 0;
            }

            gameFrame++;

            this.Refresh();

            if (splat)
            {
                if (splatTime >= 2)
                {
                    splat = false;
                    splatTime = 0;
                    UpdateZombie();
                }
                splatTime++;
            }
        }

        private void UpdateZombie()
        {
            zombie.Update(random.Next(Resources.zombie3.Width, this.Width - Resources.zombie3.Width),
            random.Next(this.Height / 2, this.Height - Resources.zombie3.Height * 2));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            if (splat == true)
            {
                // bloodSplat.DrawImage(dc);
                dc.DrawImage(bloodAnimation.GiveNextImage(), zombie.Left / 4, zombie.Top / 4 );

            }
            else
            {
                zombie.DrawImage(dc);
            }



#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font font = new System.Drawing.Font("Stemcil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "x=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(), font, new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif

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
            if (e.X > 1150 && e.X < 1220 && e.Y > 560 && e.Y < 575) // START GAME 
            {
                timerGameLoop.Start();
            }

            else if (e.X > 1165 && e.X < 1210 && e.Y > 605 && e.Y < 616) // STOP GAME 
            {
                timerGameLoop.Stop();
            }

            else if (e.X > 1168 && e.X < 1205 && e.Y > 645 && e.Y < 652) // QUIT GAME 
            {
                timerGameLoop.Stop();
            }

            else
            {
                if (zombie.Hit(e.X, e.Y))
                {
                    splat = true;
                     // bloodSplat.Left = zombie.Left - Resources.blood_drop_splat_0002.Width;
                    // bloodSplat.Top = zombie.Top - Resources.blood_drop_splat_0002.Height;

                    zombie.Top = bloodAnimation.GiveNextImage().Height;
                    zombie.Left = bloodAnimation.GiveNextImage().Width;

                };
            }

            GunFire();
        }

        private void GunFire()
        {
            //SoundPlayer sound = new SoundPlayer(Resources.shotgun_spas_12_RA_The_Sun_God_503834910);
            //sound.Play();
        }
    }
}
