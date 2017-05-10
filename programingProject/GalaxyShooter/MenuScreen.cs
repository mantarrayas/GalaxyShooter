// Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    /* The class for the main menu. This screen is used to select 
     * an option (play the game, high score...)
     * NOTE: THIS CLASS IS NOT DEFINED IN THE CLASS DIAGRAM (TO DO)
    */

    class MenuScreen : Screen
    {
        const string WELCOME_IMAGE = "imgs/title.png";
        const int WELCOME_IMAGE_WIDTH = 600;
        const int WELCOME_IMAGE_HEIGHT = 162;

        bool exit;

        public MenuScreen(Hardware hardware): base(hardware)
        {
            exit = false;
        }
        public override void Show()
        {
            // TO DO
        }
    }
}
