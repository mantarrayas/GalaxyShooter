// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Player : Sprite
    {
        protected const string playerSprite = "imgs/player.png";
        protected const int playerWidth = 128;
        protected const int playerHeight = 32;

        public Player() : base(playerSprite, playerWidth, playerHeight)
        {
        }
    }
}
