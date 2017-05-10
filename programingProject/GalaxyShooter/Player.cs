// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Player : Sprite
    {
        protected string sprite;
        protected short playerWidth;
        protected short playerHeight;
        Shot shot = new Shot("imgs/playerShot.png", 8, 8, 15);

        public Player(string fileName, short width, short height) :
            base(fileName, width, height)
        {
            this.sprite = fileName;
            this.playerWidth = width;
            this.playerHeight = height;
        }

        public void Fire()
        {
            shot.MoveTo(this.GetX(), this.GetY());
            shot.Move();
        }
        public Shot GetShot()
        {
            return shot;
        }
        
        public void SetShotSpeed()
        {
            // TO DO
        }
    }
}
