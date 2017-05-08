// Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class CampaignScreen : Screen
    {
        public CampaignScreen(Hardware hardware): base(hardware)
        {
        }

        public override void Show()
        {
            Player player = new Player();
            int key = -1;
            bool gameOver = false;


            while (key != Hardware.KEY_ESC && !gameOver)
            {
                // 1. Draw everything
                hardware.ClearScreen();
                hardware.DrawImage(player);
                hardware.UpdateScreen();

                // 2. Move player from keyboard input
                key = hardware.KeyPressed();
                if (hardware.IsKeyPressed(Hardware.KEY_LEFT))
                {
                    player.MoveTo((short)(player.GetX() - 1), player.GetY());
                }
                if (hardware.IsKeyPressed(Hardware.KEY_RIGHT))
                {
                    player.MoveTo((short)(player.GetX() + 1), player.GetY());
                }
                if (hardware.IsKeyPressed(Hardware.KEY_DOWN))
                {
                    player.MoveTo(player.GetX(), (short)(player.GetY() + 1));
                }
                if (hardware.IsKeyPressed(Hardware.KEY_UP))
                {
                    player.MoveTo(player.GetX(), (short)(player.GetY() - 1));
                }

                // 3. Move other elements (automatically)

                // 4. Collision detection and game state

                // Collision with shots


                // 5. Pause game
            }
        }
    }
}
