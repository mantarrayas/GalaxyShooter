// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    // This class manage all scenes
    class GameController
    {
        
        public void Start()
        {
            Hardware hardware = new Hardware(Hardware.DEFAULT_WIDTH,
                Hardware.DEFAULT_HEIGHT, 24, false);
            CampaignLevel game = new CampaignLevel(hardware);
            do
            {
                hardware.ClearScreen();
                game.Show();
                if (!game.GetExit())
                {
                    hardware.ClearScreen();
                    game.Show();
                }
            } while (!game.GetExit());
        }
    }
}
