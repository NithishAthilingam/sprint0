using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace sprint0
{
    internal class mouseController:Icontroller
    {
        private Game1 game;
        private Vector2 pos;
        private bool facingDown;
        private bool facingUp;
        private bool facingRight;
        private bool facingLeft;
        public mouseController(Game1 mario) {
            game = mario;
        }

        public void Update(GameTime gameTime)
        {
            MouseState userInput = Mouse.GetState();
            if (userInput.RightButton == ButtonState.Pressed)
            {
                game.Exit();
            }
            else if(userInput.LeftButton == ButtonState.Pressed && userInput.X <= 400 && userInput.Y <= 200) {
                game.sprite = new RSprite(pos, facingDown, facingUp, facingRight, facingLeft);
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
