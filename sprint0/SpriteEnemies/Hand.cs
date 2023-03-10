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
    public class Hand : Ienemy
    {
        public Vector2 thisPos;
        private int frames = 0;
        Rectangle[] hand;
        Rectangle source2;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;



        public Hand(Vector2 pos)
        {
            thisPos = pos;

            thisPos.Y -= 100;

            hand = new Rectangle[2];
            hand[0] = new Rectangle(270, 0, 22, 22);
            hand[1] = new Rectangle(270, 25, 22, 22);
            source2 = hand[0];

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 200;

            middle = 2;
            left = 0;
            right = 1;

        }

        public void Update(GameTime gameTime, Game1 game)
        {
            if (thisPos.X > 0)
            {
                frames++;
                if((frames%20 == 0) && source2 == hand[0])
                {
                    source2 = hand[1];
                }
                else if ((frames % 20 == 0) && source2 == hand[1])
                {
                    source2 = hand[0];
                }

                if (frames <= 75)
                {
                    thisPos.Y -= 1;
                    game.EnemyPos.Y = thisPos.Y;

                }
                else if (frames <= 150) {
                    thisPos.X -= 1;
                    game.EnemyPos.X = thisPos.X;
                }

                if (frames == 151)
                {
                    frames = 0;
                }
            }
            else
            {
                thisPos.X = 0;
            }
            //projectile
            //if (tt > speed)
            //{
            //    if (currentA == middle)
            //    {
            //        if (previousA == left)
            //        {
            //            currentA = right;
            //        }
            //        else
            //        {
            //            currentA = left;
            //        }
            //        previousA = currentA;
            //    }
            //    else
            //    {
            //        currentA = middle;
            //    }
            //    tt = 0;
            //}
            //else
            //{
            //    tt += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //}


        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            spriteBatch.Draw(AnimationType[7], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        }
    }
}
