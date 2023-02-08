using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    internal class mouseController:Icontroller
    {
        private Game1 game;
        public mouseController(Game1 mario) {
            game = mario;
        }

        public void Update()
        {
            MouseState userInput = Mouse.GetState();
            if (userInput.RightButton == ButtonState.Pressed)
            {
                game.Exit();
            }
            else if(userInput.LeftButton == ButtonState.Pressed && userInput.X <= 400 && userInput.Y <= 200) {
                game.sprite = new RSprite();
            }
            else if (userInput.LeftButton == ButtonState.Pressed && userInput.X > 400 && userInput.Y <= 200)
            {
                game.sprite = new AnimatedSprite();
            }
            else if (userInput.LeftButton == ButtonState.Pressed && userInput.X <= 400 && userInput.Y > 200)
            {
                game.sprite = new MotionSprite();
            }
            else if (userInput.LeftButton == ButtonState.Pressed && userInput.X > 400 && userInput.Y > 200)
            {
                game.sprite = new MotionAnimatedSprite();
            }
        }
    }
}
