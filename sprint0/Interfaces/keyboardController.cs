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
using sprint0.Items;

namespace sprint0
{
    internal class keyboardController : Icontroller
    {
        private Game1 game;
        public Vector2 pos;
        private float speed;
        private char direc;
        private int enemyIndex = -1;
        private int framesForRight = 0;
        private int framesForLeft = 0;
        private int framesForDown = 0;
        private int framesForUp = 0;

        private float timer;
        private float delayTime;

        private Texture2D i;
        Rectangle blueArrow;
        Vector2 p;
        private Vector2 enemyStartPos;

        public keyboardController(Game1 link)
        {
            game = link;
            pos = new Vector2(220, 100);
            enemyStartPos = new Vector2(450, 250);
            speed = 200f;
            enemyIndex = 0;

            delayTime = 500f;
            timer = 0f;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            game.sprite = new RSprite(pos, direc);

            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //pos.X = game.linkPos.X;
            //pos.Y = game.linkPos.Y;


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
                if (pos.Y > 0 + 60)
                {
                    framesForUp++;
                    if (framesForUp <= 9)
                    {
                        game.sprite = new UpSprite2(pos);
                        pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.Y = pos.Y;
                    }
                    else if (framesForUp <= 18)
                    {
                        game.sprite = new UpSprite(pos);
                        pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.Y = pos.Y;
                    }
                    else if (framesForUp == 19)
                    {
                        framesForUp = 0;
                    }
                }
                else
                {
                    pos.Y = 0 + 60;
                    game.linkPos.Y = pos.Y;
                }

            }
            else if (userInput.IsKeyDown(Keys.Left) || userInput.IsKeyDown(Keys.A))
            {
                direc = 'a';
                game.sprite = new LeftSprite(pos);
                game.sprite.Update(gameTime);
                if (pos.X > 0 + 90)
                {
                    framesForLeft++;
                    if (framesForLeft <= 9)
                    {
                        game.sprite = new LeftSprite2(pos);
                        pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.X = pos.X;
                    }
                    else if (framesForLeft <= 18)
                    {
                        game.sprite = new LeftSprite(pos);
                        pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.X = pos.X;
                    }
                    else if (framesForLeft == 19)
                    {
                        framesForLeft = 0;
                    }
                } else if (pos.Y > 220 && pos.Y < 230)
                {
                    game.sprite = new LeftSprite(pos);

                    pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    game.linkPos.X = pos.X;
                }
                else
                {
                    pos.X = 0 + 90;
                    game.linkPos.X = pos.X;
                }


            }
            else if (userInput.IsKeyDown(Keys.Down) || userInput.IsKeyDown(Keys.S))
            {
                direc = 's';
                game.sprite = new DownSprite(pos);
                game.sprite.Update(gameTime);
                if (pos.Y < (432 - 60))
                {
                    framesForDown++;
                    if (framesForDown <= 9)
                    {
                        game.sprite = new DownSprite2(pos);
                        pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.Y = pos.Y;
                    }
                    else if (framesForDown <= 18)
                    {
                        game.sprite = new DownSprite(pos);
                        pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.Y = pos.Y;
                    }
                    else if (framesForDown == 19)
                    {
                        framesForDown = 0;
                    }
                } else if (pos.X > 350 && pos.X < 395)
                {
                    game.sprite = new DownSprite(pos);

                    pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    game.linkPos.Y = pos.Y;
                }
                else
                {
                    pos.Y = 432 - 60;
                    game.linkPos.Y = pos.Y;
                }

            }
            else if (userInput.IsKeyDown(Keys.Right) || userInput.IsKeyDown(Keys.D))
            {
                direc = 'd';
                game.sprite = new RightSprite(pos);
                if (pos.X < 800 - 45 - 90)
                {
                    framesForRight++;
                    if (framesForRight <= 9)
                    {
                        game.sprite = new RightSprite2(pos);
                        pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.X = pos.X;
                    }
                    else if (framesForRight <= 18)
                    {
                        game.sprite = new RightSprite(pos);
                        pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        game.linkPos.X = pos.X;
                    }
                    else if (framesForRight == 19)
                    {
                        framesForRight = 0;
                    }
                } else if (pos.Y > 220 && pos.Y < 230) {

                    game.sprite = new RightSprite(pos);

                    pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    game.linkPos.X = pos.X;

                }
                else
                {
                    pos.X = 800 - 45 - 90;
                }
                game.linkPos.X = pos.X;
            
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
            else if (userInput.IsKeyDown(Keys.NumPad4) || userInput.IsKeyDown(Keys.D4))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 15, pos.Y));
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
            else if (userInput.IsKeyDown(Keys.NumPad3) || userInput.IsKeyDown(Keys.D3))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'd')
                {
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new Bomb(pos, direc);
                }
            }

            if (userInput.IsKeyDown(Keys.R))
            {
                pos.X = 0;
                pos.Y = 0;
                game.sprite = new RSprite(pos, direc);
            }
            if (timer <= 0f)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.P) || Keyboard.GetState().IsKeyDown(Keys.O))
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
                    }
                    else if (enemyIndex == 3)
                    {
                        game.enemy = new BlueBlob(enemyStartPos);
                    }
                    else if (enemyIndex == 4)
                    {
                        game.enemy = new Hand(enemyStartPos);
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

        public Vector2 GetLinkPos()
        {
            return pos;
        }

        public void SetLinkPos(Vector2 newPos)
        {
            pos = newPos;
        }

        public void ModifyLinkPos(Vector2 mod)
        {
            pos += mod;
        }
    }
}