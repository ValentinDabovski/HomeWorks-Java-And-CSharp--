// #define My_Debug

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

        int hits = 0;
        int misses = 0;
        int totalshots = 0;
        double averageShots = 0;

     
        CZombie zombie;

        GroundCracks craks;

        InGameMenu zombieHoldingMenu;

        ScoreTable scoreTable;

        BloodSplat bloodSplat;

        Random random = new Random();

        public Shooter()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(Resources.GunSught);

            this.Cursor = CustomCursor.CreateCursor(bmp, bmp.Height / 2, bmp.Width / 2);

            zombie = new CZombie() { Left = 300, Top = 400 };

            craks = new GroundCracks() { Left = 280, Top = 400 };

            zombieHoldingMenu = new InGameMenu() { Left = 1120, Top = 470 };

            scoreTable = new ScoreTable() { Left = 1078, Top = 105 };

            bloodSplat = new BloodSplat();

            
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            if (gameFrame >= 7)
            {
                UpdateZombie();
                gameFrame = 0;
            }

            gameFrame++;

            this.Refresh();

            if (splat)
            {
                if (splatTime >= 1)
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
                bloodSplat.DrawImage(dc);

                bloodSplat.DrawImage(dc);
            }

            else
            {
                zombie.DrawImage(dc);
            }


            zombieHoldingMenu.DrawImage(dc);

            scoreTable.DrawImage(dc);
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font font = new System.Drawing.Font("Stemcil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "x=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(), font, new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif

            // Points On Screen 
            TextFormatFlags points = TextFormatFlags.Left;
            Font font2 = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(e.Graphics, "Shots: " + totalshots.ToString(), font2, new Rectangle(1120, 140, 120, 20), SystemColors.ControlText, points);
            TextRenderer.DrawText(e.Graphics, "Hits: " + hits.ToString(), font2, new Rectangle(1120, 160, 120, 20), SystemColors.ControlText, points);
            TextRenderer.DrawText(e.Graphics, "Misses: " + misses.ToString(), font2, new Rectangle(1120, 180, 120, 20), SystemColors.ControlText, points);
            TextRenderer.DrawText(e.Graphics, "Average: " + averageShots.ToString("F0") + "%", font2, new Rectangle(1120, 200, 120, 20), SystemColors.ControlText, points);

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
                Application.Exit();
            }

            else
            {
                if (zombie.Hit(e.X, e.Y))
                {
                    splat = true;

                    bloodSplat.Left = zombie.Left - Resources.blood_drop_splat_0002.Width / 4;
                    bloodSplat.Top = zombie.Top - Resources.blood_drop_splat_0002.Height / 2;

                    hits++;

                }

                else
                {
                    misses++;
                }

                totalshots = hits + misses;
                averageShots = (double)hits / (double)totalshots * 100.0;
            }

            GunFire();
        }

        private void GunFire()
        {
            SoundPlayer sound = new SoundPlayer(Resources._380_gunshot_single_mike_koenig);
            sound.Play();
        }
    }
}
