// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Obstacle : Sprite
    {
        protected short width;
        protected short height;
        protected string sprite;
        protected int health;
        public Obstacle(string fileName, short width, short height, int health) :
            base(fileName, width, height)
        {
            this.sprite = fileName;
            this.width = width;
            this.height = height;
            this.health = health;
        }
    }
}
