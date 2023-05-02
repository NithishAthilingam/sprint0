using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;

namespace sprint0
{
    public class SkeletonSprite1 : Ienemy
    {
        public Vector2 thisPos;
        private int frames = 0;
        Rectangle[] skele;
        Rectangle source2;
        int currentA;
        int previousA;
        int skeletonHealth;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;
        Boolean stopDraw;

        int[] value;
        int id;

        Dictionary<int, int[]> enemies;

        //int posChangeY;
        //int posChangeX;
        int posChangeY;
        int posChangeX;
        float timer;
        float delayTime;
        Texture2D sprite;
        Random random;

        public SkeletonSprite1(int enemyID, Texture2D enemiesSprite,Vector2 pos)
        {
            enemies = new Dictionary<int, int[]>();

            sprite = enemiesSprite;
            thisPos = pos;
            value = new int[6];
            id = enemyID;
            delayTime = 1000f;
            timer = 0f;

            skele = new Rectangle[2];
            skele[0] = new Rectangle(420, 118, 20, 20);
            skele[1] = new Rectangle(420, 148, 20, 20);
            source2 = skele[0];

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 200;
            stopDraw = false;

            middle = 2;
            left = 0;
            right = 1;

            posChangeY = 3;
            posChangeX = 3;

            random = new Random();
            delayTime = 0;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                enemies = game.currentRoomsRoom.enemiesD;
                frames++;
                
                if ((frames % 10 == 0) && source2 == skele[0])
                {
                    source2 = skele[1];
                }
                else if ((frames % 10 == 0) && source2 == skele[1])
                {
                    source2 = skele[0];
                }

                int next = random.Next(0, 3);
                
                if ((thisPos.X >= 90 && thisPos.X <= 665) && (thisPos.Y >= 60 && thisPos.Y <= 372))
                {
                    if (timer <= 0f &&  next == 0)
                    {
                        thisPos.Y += 3;
                        timer = delayTime;
                    }
                    else if (timer <= 0f && next == 1)
                    {
                        thisPos.Y -= 3;
                        timer = delayTime;
                    }
                    else if (timer <= 0f &&  next == 2)
                    {
                        thisPos.X += 3;
                        timer = delayTime;
                    }
                    else if (timer <= 0f &&  next == 3)
                    {
                        thisPos.X -= 3;
                        timer = delayTime;
                    }
                }
                else
                {
                    if (thisPos.X < 90)
                    {
                        thisPos.X += 3;
                    }
                    else if (thisPos.X > 665)
                    {
                        thisPos.X -= 3;
                    }
                    else if (thisPos.Y < 60)
                    {
                        thisPos.Y += 3;
                    }
                    else if (thisPos.Y > 372)
                    {
                        thisPos.Y -= 3;
                    }
                }
                if (frames == 301)
                {
                    frames = 0;
                }


                //projectile
                if (tt > speed)
                {
                    if (currentA == middle)
                    {
                        if (previousA == left)
                        {
                            currentA = right;
                        }
                        else
                        {
                            currentA = left;
                        }
                        previousA = currentA;
                    }
                    else
                    {
                        currentA = middle;
                    }
                    tt = 0;
                }
                else
                {
                    tt += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                }

                if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
                {
                    game.currentRoomsRoom.enemiesD.TryGetValue(id, out value);
                    value[0] = (int)thisPos.X;
                    value[1] = (int)thisPos.Y;
                    value[2] = 40;
                    value[3] = 40;
                    skeletonHealth = value[5];
                    game.currentRoomsRoom.enemiesD.Remove(id);
                    game.currentRoomsRoom.enemiesD.Add(id, value);

                    game.collideB.Update(gameTime, game, game.currentRoomsRoom, id);
                    game.currentRoomsRoom.enemiesD.TryGetValue((int)id, out value);
                    thisPos.X = value[0];
                    thisPos.Y = value[1];

                    if(skeletonHealth == 0)
                    {
                        stopDraw = true;
                    }
                }
            }

        }


        //public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        //{
        //    spriteBatch.Draw(AnimationType[7], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        //}


        //public void Draw(SpriteBatch spriteBatch, Texture2D animation, Vector2 pos)
        //{
        //    spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        //}

        public void Draw(SpriteBatch spriteBatch)
        {
            if (enemies.ContainsKey(id))
            {
                spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
        }

    }
}
