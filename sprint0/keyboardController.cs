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
        private bool facingDown;
        private bool facingUp;
        private bool facingRight;
        private bool facingLeft;

        public keyboardController(Game1 link)
        {
            game = link;
            pos = new Vector2(220, 100);
            speed = 200f;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            game.sprite = new RSprite(pos, facingDown, facingUp, facingRight, facingLeft);

            if (userInput.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.Up) || userInput.IsKeyDown(Keys.W))
            {
                facingDown = false;
                facingUp = true;
                facingRight = false;
                facingLeft = false;
                game.sprite = new UpSprite(pos);
                if (!(pos.Y <= 0))
                {
                    pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                //game.sprite = new RSprite();z
                
            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.A))
            {
                facingDown = false;
                facingUp = false;
                facingRight = false;
                facingLeft = true;
                game.sprite = new LeftSprite(pos);
                if (!(pos.X <= 0))
                {
                    pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                //game.sprite = new RSprite();
                
            }
            else if (userInput.IsKeyDown(Keys.Down) || userInput.IsKeyDown(Keys.S))
            {
                facingDown = true;
                facingUp = false;
                facingRight = false;
                facingLeft = false;
                game.sprite = new DownSprite(pos);
                if (!(pos.Y >= 435))
                {
                    pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                //game.sprite = new RSprite();
                
            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.D))
            {
                facingDown = false;
                facingUp = false;
                facingRight = true;
                facingLeft = false;
                game.sprite = new RightSprite(pos);
                if (!(pos.X >= 750))
                {
                    pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                //game.sprite = new RSprite();
                
            }
            else if (userInput.IsKeyDown(Keys.Z) || userInput.IsKeyDown(Keys.N))
            {
                if (facingDown == true)
                {
                    game.sprite = new SwordSpriteDown(pos);
                }
                else if (facingLeft == true)
                {
                    
                    game.sprite = new SwordSpriteLeft(new Vector2(pos.X - 40, pos.Y - 30));
                }
                else if (facingUp == true)
                {
                    game.sprite = new SwordSpriteUp(new Vector2(pos.X, pos.Y - 35));
                }

            }
        }
    }
}