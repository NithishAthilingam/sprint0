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



        public SkeletonSprite1(Vector2 pos)
        {
            thisPos = pos;

            thisPos.Y -= 100;




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

        }

        public void Update(GameTime gameTime, Game1 game)
        {



            if (thisPos.X > 0)
            {
                frames++;
                if((frames%20 == 0) && source2 == skele[0])
                {
                    source2 = skele[1];
                }
                else if ((frames % 20 == 0) && source2 == skele[1])
                {
                    source2 = skele[0];
                }

                if (frames <= 75)
                {
                    thisPos.X += 3;
                }
                else if (frames <= 150) {
                    thisPos.Y += 3;
                }
                else if (frames <= 225)
                {
                    thisPos.X -= 3;     
                }
                else if (frames <= 300)
                {
                    thisPos.Y -= 3;
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


        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            spriteBatch.Draw(AnimationType[7], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        }
    }
}
