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

        Texture2D sprite;
        Random random;


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
            random = new Random();
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

                //if (frames <= 75)
                //{
                //    thisPos.X += 3;
                //    game.EnemyPos.X = thisPos.X;
                //}
                //else if (frames <= 150) {
                //    thisPos.Y += 3;
                //    game.EnemyPos.Y = thisPos.Y;

                //}
                //else if (frames <= 225)
                //{
                //    thisPos.X -= 3;
                //    game.EnemyPos.X = thisPos.X;

                //}
                //else if (frames <= 300)
                //{
                //    thisPos.Y -= 3;
                //    game.EnemyPos.Y = thisPos.Y;

                //}

                int direction = random.Next(4);

                // Move the bat in the chosen direction
                switch (direction)
                {
                    case 0:
                        thisPos.Y -= 2;
                        break;
                    case 1:
                        thisPos.Y += 2;
                        break;
                    case 2:
                        thisPos.X -= 2;
                        break;
                    case 3:
                        thisPos.X += 2;
                        break;
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
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);

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
