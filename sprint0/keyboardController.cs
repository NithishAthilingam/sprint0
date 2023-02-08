using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    internal class keyboardController : Icontroller
    {
        private Game1 game;
        public keyboardController(Game1 mario)
        {
            game = mario;
        }

        public void Update()
        {
            KeyboardState userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.D0))
            {
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.D1))
            {
                game.sprite = new RSprite();
            }
            else if (userInput.IsKeyDown(Keys.D2))
            {
                game.sprite = new AnimatedSprite();
            }
            else if (userInput.IsKeyDown(Keys.D3))
            {
                game.sprite = new MotionSprite();
            }
            else if (userInput.IsKeyDown(Keys.D4))
            {
                game.sprite = new MotionAnimatedSprite();
            }
        }
    }
}