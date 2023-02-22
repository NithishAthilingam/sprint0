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
using sprint0.EnemySprites;
using sprint0.Items;

namespace sprint0
{
    internal class keyboardController : Icontroller
    {
        private Game1 game;
        private Vector2 pos;
        private float speed;
        private char direc;
        private int enemyIndex;
        private int framesForRight = 0;
        private int framesForLeft = 0;
        private int framesForDown = 0;
        private int framesForUp = 0;
        //private int press;

        private float timer;
        private float delayTime;

        private Texture2D i;
        private Texture2D o;
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
            enemyIndex = 0;
            // dragonEnemyLocation = new Vector2(350, 250);


            delayTime = 500f;
            timer = 0f;

            //press = 0;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            //timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            game.sprite = new RSprite(pos, direc);

            //game.enemy = new EnemyCycle(game,enemyIndex);
            //game.healthbar = new FullHealthbar(press);
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;



            if (userInput.IsKeyDown(Keys.E))
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
                    framesForUp++;
                    if (framesForUp <= 9)
                    {
                        game.sprite = new UpSprite2(pos);
                        pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForUp <= 18)
                    {
                        game.sprite = new UpSprite(pos);
                        pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForUp == 19)
                    {
                        framesForUp = 0;
                    }
                }
                else
                {
                    pos.Y = 0;
                }

            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.A))
            {
                direc = 'a';
                game.sprite = new LeftSprite(pos);
                game.sprite.Update(gameTime);
                if (pos.X > 0)
                {
                    framesForLeft++;
                    if (framesForLeft <= 9)
                    {
                        game.sprite = new LeftSprite2(pos);
                        pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForLeft <= 18)
                    {
                        game.sprite = new LeftSprite(pos);
                        pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForLeft == 19)
                    {
                        framesForLeft = 0;
                    }
                }
                else
                {
                    pos.X = 0;
                }


            }
            else if (userInput.IsKeyDown(Keys.Down) || userInput.IsKeyDown(Keys.S))
            {
                direc = 's';
                game.sprite = new DownSprite(pos);
                game.sprite.Update(gameTime);
                if (pos.Y < (432))
                {
                    framesForDown++;
                    if (framesForDown <= 9)
                    {
                        game.sprite = new DownSprite2(pos);
                        pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForDown <= 18)
                    {
                        game.sprite = new DownSprite(pos);
                        pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForDown == 19)
                    {
                        framesForDown = 0;
                    }
                }
                else
                {
                    pos.Y = 432;
                }

            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.D))
            {
                direc = 'd';
                game.sprite = new RightSprite(pos);
                if (pos.X < 800 - 45)
                {
                    framesForRight++;
                    if (framesForRight <= 9)
                    {
                        game.sprite = new RightSprite2(pos);
                        pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForRight <= 18)
                    {
                        game.sprite = new RightSprite(pos);
                        pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else if (framesForRight == 19)
                    {
                        framesForRight = 0;
                    }
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
                    game.shoot = new BlueArrowDown(pos);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 20, pos.Y));
                    game.shoot = new BlueArrowLeft(pos);

                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.shoot = new BlueArrowUp(pos);

                }
                else if (direc == 'd')
                {
                    p.Y = pos.Y;
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.shoot = new BlueArrowRight(pos);

                    p.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }
            else if (userInput.IsKeyDown(Keys.NumPad2) || userInput.IsKeyDown(Keys.D2))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.shoot = new GreenArrowDown(pos);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 20, pos.Y));
                    game.shoot = new GreenArrowLeft(pos);

                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.shoot = new GreenArrowUp(pos);

                }
                else if (direc == 'd')
                {
                    p.Y = pos.Y;
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.shoot = new GreenArrowRight(pos);

                    p.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }
            else if (userInput.IsKeyDown(Keys.NumPad6) || userInput.IsKeyDown(Keys.D6))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 20, pos.Y));
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'd')
                {
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new ThrowFire(pos, direc);
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

            if (userInput.IsKeyDown(Keys.R))
            {
                pos.X = 0;
                pos.Y = 0;
                //press = 0;
                game.sprite = new RSprite(pos, direc);
                //game.healthbar = new FullHealthbar(press);
            }
            if (timer <= 0f)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.P))
                {
                    enemyIndex++;
                    if (enemyIndex == 0)
                    {
                        game.enemy = new DragonSprite1(enemyStartPos);
                    }
                    else if (enemyIndex == 1)
                    {
                        game.enemy = new SkeletonSprite1(enemyStartPos);
                    }
                    else if (enemyIndex == 2)
                    {
                        game.enemy = new BatSprite1(enemyStartPos);
                        enemyIndex = -1;
                    }
                    timer = delayTime;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.O))
                {
                    enemyIndex++;
                    if (enemyIndex == 0)
                    {
                        game.enemy = new DragonSprite1(enemyStartPos);
                    }
                    else if (enemyIndex == 1)
                    {
                        game.enemy = new SkeletonSprite1(enemyStartPos);
                    }
                    else if (enemyIndex == 2)
                    {
                        game.enemy = new BatSprite1(enemyStartPos);
                        enemyIndex = -1;
                    }
                    timer = delayTime;
                }

            }


        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(i, p, blueArrow, Color.White);
        }

    }
}