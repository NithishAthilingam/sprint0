using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Diagnostics;

using System.Threading;

using Microsoft.Xna.Framework.Graphics;


namespace sprint0
{
    internal class keyboardController : Icontroller
    {
        private Game1 game;
        private Vector2 pos;
        private float speed;
        private char direc;
        //private int press;

        //private float timer;
        //private float delayTime;

        private Texture2D i;
        Rectangle blueArrow;
        //Rectangle greenArrow;
        //Rectangle des;
        Vector2 p;
        //private float s;
        private Projectiles projectiles;
        private Vector2 enemyStartPos;
        // public Vector2 dragonEnemyLocation;




        public keyboardController(Game1 link)
        {
            game = link;
            pos = new Vector2(220, 100);
            enemyStartPos = new Vector2(450, 250);
            speed = 200f;
            // dragonEnemyLocation = new Vector2(350, 250);

            //delayTime = 500f;
            //timer = 0f;
            //press = 0;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            //timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            game.sprite = new RSprite(pos, direc);
            //game.healthbar = new FullHealthbar(press);


            if(userInput.IsKeyDown(Keys.E))
            {
                game.sprite = new DamagedSprite(pos);
            }

            if (userInput.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.Up) || userInput.IsKeyDown(Keys.W))
            {
                direc = 'w';
                game.sprite = new UpSprite(pos);
                if (pos.Y > 0)
                {
                    pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    pos.Y = 0;
                }
                //game.sprite = new RSprite();
                
            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.A))
            {
                direc = 'a';
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
                direc = 's';
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
            else if (userInput.IsKeyDown(Keys.P) || userInput.IsKeyDown(Keys.O))
            {

                game.enemy = new SkeletonSprite1(enemyStartPos);
                //game.enemy = new DragonSprite1(enemyStartPos);
                //game.enemy0 = new SkeletonSprite1(enemyStartPos);


            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.D))
            {
                direc = 'd';
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
                if (direc == 's')
                {
                    game.sprite = new SwordSpriteDown(pos);
                }
                else if (direc == 'a')
                {
                    
                    game.sprite = new SwordSpriteLeft(new Vector2(pos.X - 40, pos.Y - 30));
                }
                else if (direc == 'w')
                {
                    game.sprite = new SwordSpriteUp(new Vector2(pos.X, pos.Y - 40));
                }
                else if (direc == 'd')
                {
                    game.sprite = new SwordSpriteRight(new Vector2(pos.X - 5, pos.Y - 25));
                }
            }

            else if (userInput.IsKeyDown(Keys.NumPad1) || userInput.IsKeyDown(Keys.D1))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                }
                else if (direc == 'a')
                {

                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X -20, pos.Y ));
                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                }
                else if (direc == 'd')
                {
                    p.Y = pos.Y;
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    p.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }

            //if (timer <= 0f)
            //{
            //    if (userInput.IsKeyDown(Keys.E))
            //    {
            //        press++;
            //    }
            //    timer = delayTime;
            //}
                
            if(userInput.IsKeyDown(Keys.R))
            {
                pos.X = 0;
                pos.Y = 0;
                //press = 0;
                game.sprite = new RSprite(pos, direc);
                //game.healthbar = new FullHealthbar(press);
            }

   
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(i, p, blueArrow, Color.White);

        }

    }
}