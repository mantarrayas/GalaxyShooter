// Galaxy Shooter Project
// Made by Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    // This class is the main gamemode. Here the
    // player starts to play the campaign

    class CampaignLevel : Screen
    {
        protected bool exit;
        public CampaignLevel(Hardware hardware): base(hardware)
        {
            exit = false;
        }

        public bool GetExit()
        {
            return exit;
        }

        public override void Show()
        {
            // Create elements
            Player player = new Player("imgs/player.png", 128, 32);
            Background bg = new Background("imgs/background.png");
            Obstacle obs1 = new Obstacle("imgs/asteroid.png", 32, 32, 5);
            Obstacle obs2 = new Obstacle("imgs/asteroid2.png", 32, 32, 3);
            int key = -1;
            short playerSprite = 0;
            int currentSprite = 0;
            int playerSpeed = 4;
            bool gameOver = false;
            int mapTopLimit = 64;
            int mapBottomLimit = 512 - 96;

            // Start Position of elements
            player.MoveTo(64, 256 - 32);
            obs1.MoveTo(512, 256);
            obs2.MoveTo(1024, 128);

            // Main Game Loop
            while (key != Hardware.KEY_ESC && !gameOver)
            {
                // Animated Sprites
                if (playerSprite >= 3)
                {
                    currentSprite = (currentSprite + 1) % 4;
                    playerSprite = 0;
                }
                else
                {
                    playerSprite++;
                }
                // 1. Draw everything
                hardware.ClearScreen();
                hardware.DrawImage(bg);
                hardware.DrawImage(player, (short)(32 * currentSprite), 0, 32, 32);
                player.GetShot().Draw(hardware);
                hardware.DrawImage(obs1);
                hardware.DrawImage(obs2);
                hardware.UpdateScreen();
                

                // 2. Move player from keyboard input
                key = hardware.KeyPressed();
                if (player.GetY() <= mapBottomLimit)
                {
                    if (hardware.IsKeyPressed(Hardware.KEY_DOWN))
                    {
                        player.MoveTo(player.GetX(), (short)(player.GetY() +
                            playerSpeed));
                    }
                }
                if(player.GetY() >= mapTopLimit)
                {
                    if (hardware.IsKeyPressed(Hardware.KEY_UP))
                    {
                        player.MoveTo(player.GetX(), (short)(player.GetY() -
                            playerSpeed));
                    }
                }

                // Shoot
                if (hardware.IsKeyPressed(Hardware.KEY_SPACE))
                {
                    player.Fire();
                }
                

                // 3. Move other elements (automatically)
                obs1.MoveTo((short)(obs1.GetX() - 1), (short)(obs1.GetY()));
                obs2.MoveTo((short)(obs2.GetX() - 2), (short)(obs2.GetY()));

                // 4. Collision detection and game state

                // 5. Pause game
                // System.Threading.Thread.Sleep(10);
            }
        }
    }
}
