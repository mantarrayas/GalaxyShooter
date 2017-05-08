using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyShooter
{
    class GameController
    {
        public void Start()
        {
            Hardware hardware = new Hardware(Hardware.DEFAULT_WIDTH,
                Hardware.DEFAULT_HEIGHT, 24, false);

            MenuScreen menu = new MenuScreen(hardware);
            CampaignScreen game = new GameScreen(hardware);

            do
            {
                hardware.ClearScreen();
                welcome.Show();
                if (!welcome.GetExit())
                {
                    hardware.ClearScreen();
                    game.Show();
                    hardware.ClearScreen();
                    credits.Show();
                }
            } while (!welcome.GetExit());
        }
    }
}
