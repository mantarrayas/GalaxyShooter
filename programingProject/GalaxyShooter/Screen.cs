﻿// Roberto Garcia Marcos

using System;
using Tao.Sdl;

namespace GalaxyShooter
{
    class Screen
    {
        protected Hardware hardware;

        public Screen(Hardware hardware)
        {
            this.hardware = hardware;
        }
        public virtual void Show()
        {

        }
    }
}
