// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    // This class manage the player and emeny shots
    class Shot : Sprite
    {
        protected short width;
        protected short height;
        protected string sprite;
        protected short speed;

        public Shot(string sprite, short width, short height, short speed) :
            base(sprite, width, height)
        {
            this.width = width;
            this.height = height;
            this.sprite = sprite;
            this.speed = speed;
        }

        public void Move()
        {
            this.MoveTo((short)(GetX() + this.speed), GetY());
        }
        public void Draw(Hardware hardware)
        {
            hardware.DrawImage(this);
        }
    }
}
