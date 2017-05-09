// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    // This is the main class

    class GalaxyShooter
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.Start();
        }
    }
}
