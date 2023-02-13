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
    internal class keyboardController : Icontroller
    {
        private Game1 game;
        private Vector2 pos;
        private float speed;
        public keyboardController(Game1 mario)
        {
            game = mario;
            pos = new Vector2(220, 100);
            speed = 100f;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            game.sprite = new RSprite(pos);
            if (userInput.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.Up) || userInput.IsKeyDown(Keys.W))
            {
                //game.sprite = new RSprite();z
                pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.A))
            {
                //game.sprite = new RSprite();
                pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (userInput.IsKeyDown(Keys.Down) || userInput.IsKeyDown(Keys.S))
            {
                //game.sprite = new RSprite();
                pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.D))
            {
                //game.sprite = new RSprite();
                pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
    }
}