using System;
using System.Drawing;
using Shoter.Properties;

namespace Shoter
{
    class InGameMenu : CImageBase
    {
        private Rectangle zombieHoldingMenu = new Rectangle();

        public InGameMenu() : base(Resources.zombie_holding_sign_1)
        {
            zombieHoldingMenu.X = Top;
            zombieHoldingMenu.Y = Left;
            zombieHoldingMenu.Height = 20;
            zombieHoldingMenu.Width = 30;

        }
    }
}
