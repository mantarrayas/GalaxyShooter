using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyShooter
{
    class Player : Sprite
    {
        protected const string playerSprite = "imgs/player.png";
        protected const int playerWidth = 32;
        protected const int playerHeight = 32;

        public Player() : base(playerSprite, playerWidth, playerHeight)
        {
            // TO DO
        }
    }
}
