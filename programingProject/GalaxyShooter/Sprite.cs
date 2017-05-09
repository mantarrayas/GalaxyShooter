// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Sprite
    {
        short x, y;
        short imageWidth, imageHeight;
        IntPtr sprite;

        public Sprite(string fileName, short width, short height)
        {
            sprite = SdlImage.IMG_Load(fileName);
            if (sprite == IntPtr.Zero)
            {
                Console.WriteLine("Image not found");
                Environment.Exit(1);
            }

            imageWidth = width;
            imageHeight = height;
        }

        public void MoveTo(short x, short y)
        {
            this.x = x;
            this.y = y;
        }

        public short GetX()
        {
            return x;
        }

        public short GetY()
        {
            return y;
        }

        public short GetImageWidth()
        {
            return imageWidth;
        }

        public short GetImageHeight()
        {
            return imageHeight;
        }

        public IntPtr GetImage()
        {
            return sprite;
        }

        public bool CollidesWith(Sprite spr, short w1, short h1, short w2, short h2)
        {
            return (x + w1 >= spr.x && x <= spr.x + w2 &&
                    y + h1 >= spr.y && y <= spr.y + h2);
        }
    }
}
