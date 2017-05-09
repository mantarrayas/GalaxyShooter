// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Background : Sprite
    {
        protected string sprite;
        protected const int width = 1024;
        protected const int height = 512;

        public Background(string sprite) : base(sprite, width, height)
        {
            this.sprite = sprite;
        }
    }
}
