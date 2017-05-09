// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    // This class is the main gamemode. Here the
    // player starts to play the campaign

    class CampaignScreen : Screen
    {
        protected bool exit;
        public CampaignScreen(Hardware hardware): base(hardware)
        {
            exit = false;
        }

        public bool GetExit()
        {
            return exit;
        }

        public override void Show()
        {
            Player player = new Player();
            Background bg = new Background("imgs/background.png");
            Obstacle obs1 = new Obstacle("imgs/asteroid.png", 32, 32, 5);
            Obstacle obs2 = new Obstacle("imgs/asteroid2.png", 32, 32, 3);
            int key = -1;
            bool gameOver = false;

            // Start Position of elements
            player.MoveTo(64, 256 - 32);
            obs1.MoveTo(512, 256);
            obs2.MoveTo(1024, 256);

            // Main Game Loop
            while (key != Hardware.KEY_ESC && !gameOver)
            {
                // 1. Draw everything
                hardware.ClearScreen();
                hardware.DrawImage(bg);
                hardware.DrawImage(player, 32, 0, 32, 128);
                hardware.DrawImage(obs1);
                hardware.DrawImage(obs2);
                hardware.UpdateScreen();

                // 2. Move player from keyboard input
                key = hardware.KeyPressed();
                if (hardware.IsKeyPressed(Hardware.KEY_DOWN))
                {
                    player.MoveTo(player.GetX(), (short)(player.GetY() + 1));
                }
                if (hardware.IsKeyPressed(Hardware.KEY_UP))
                {
                    player.MoveTo(player.GetX(), (short)(player.GetY() - 1));
                }

                // 3. Move other elements (automatically)
                obs1.MoveTo((short)(obs1.GetX() - 1), (short)(obs1.GetY()));
                obs2.MoveTo((short)(obs2.GetX() - 2), (short)(obs2.GetY()));

                // 4. Collision detection and game state

                // 5. Pause game
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
