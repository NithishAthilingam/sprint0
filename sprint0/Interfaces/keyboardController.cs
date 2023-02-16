using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Diagnostics;

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
        private int press;

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
            game.healthbar = new FullHealthbar(press);

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
                if (pos.Y > 0)
                {
                    pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    pos.Y = 0;
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
                if (pos.X > 0)
                {
                    pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    pos.X = 0;
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
                if (pos.Y < (432))
                {
                    pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    pos.Y = 432;
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
                if (pos.X < 800-45)
                {
                    pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    pos.X = 800 - 45;
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
                    game.sprite = new SwordSpriteUp(new Vector2(pos.X, pos.Y - 40));
                }
                else if (facingRight == true)
                {
                    game.sprite = new SwordSpriteRight(new Vector2(pos.X - 5, pos.Y - 25));
                }
            }
            else if(userInput.IsKeyDown(Keys.E))
                {
                    press++;
                }
            else if(userInput.IsKeyDown(Keys.R))
            {
                pos.X = 0;
                pos.Y = 0;
                press = 0;
                game.sprite = new RSprite(pos, facingDown, facingUp, facingRight, facingLeft);
                game.healthbar = new FullHealthbar(press);
            }
        }
    }
}