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
            if (userInput.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.Up) || userInput.IsKeyDown(Keys.W))
            {
                game.sprite = new RSprite();
            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.A))
            {
                game.sprite = new AnimatedSprite();
            }
            else if (userInput.IsKeyDown(Keys.Down) || userInput.IsKeyDown(Keys.S))
            {
                game.sprite = new MotionSprite();
            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.D))
            {
                game.sprite = new MotionAnimatedSprite();
            }
        }
    }
}