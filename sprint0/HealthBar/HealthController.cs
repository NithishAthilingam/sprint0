﻿using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace sprint0
{
    internal class HealthController : Icontroller
    {
        private Game1 game;
        public int pressed;
        public HealthController(Game1 link, int press)
        {
            game = link;
            pressed = press;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            game.healthbar = new FullHealthbar(pressed);
            
        

        }
    }
}