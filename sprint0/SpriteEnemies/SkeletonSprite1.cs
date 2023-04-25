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
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;

        Vector4 value;
        int id;

        //int posChangeY;
        //int posChangeX;
        int delayTime;
        Texture2D sprite;
        Random random;
        Random rand;

        public SkeletonSprite1(int enemyID, Texture2D enemiesSprite,Vector2 pos)
        {

            sprite = enemiesSprite;
            thisPos = pos;

            id = enemyID;

            skele = new Rectangle[2];
            skele[0] = new Rectangle(420, 118, 20, 20);
            skele[1] = new Rectangle(420, 148, 20, 20);
            source2 = skele[0];

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 200;

            middle = 2;
            left = 0;
            right = 1;

            //posChangeY = 2;
            //posChangeX = 2;

            random = new Random();
            rand = new Random();
            delayTime = 0;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            if (thisPos.X > 0)
            {
                frames++;
                if((frames % 10 == 0) && source2 == skele[0])
                {
                    source2 = skele[1];
                }
                else if ((frames % 10 == 0) && source2 == skele[1])
                {
                    source2 = skele[0];
                }

                int next = random.Next(0, 3);

                if (frames <= 75)
                {
                    if(next == 2)
                    {
                        thisPos.X += 3;
                        game.EnemyPos.X = thisPos.X;
                    }
                }
                else if (frames <= 150)
                {
                    if (next == 0)
                    {
                        thisPos.Y += 3;
                        game.EnemyPos.Y = thisPos.Y;
                    }

                }
                else if (frames <= 225)
                {
                    if (next == 3)
                    {
                        thisPos.X -= 3;
                        game.EnemyPos.X = thisPos.X;
                    }

                }
                else if (frames <= 300)
                {
                    if (next == 1)
                    {
                        thisPos.Y -= 3;
                        game.EnemyPos.Y = thisPos.Y;
                    }
                }

                if (frames == 301)
                {
                    frames = 0;
                }

            }
            else
            {
                thisPos.X = 0;
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
                value.X = thisPos.X;
                value.Y = thisPos.Y;
                value.Z = 40;
                value.W = 40;
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);

                game.collideB.Update(gameTime, game, game.currentRoomsRoom, id);
                game.currentRoomsRoom.enemiesD.TryGetValue((int)id, out value);
                thisPos.X = value.X;
                thisPos.Y = value.Y;
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
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);

        }

    }
}
