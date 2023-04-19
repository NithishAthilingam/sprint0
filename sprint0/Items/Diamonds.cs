using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using sprint0.HealthBar;
using System.Reflection;

namespace sprint0
{
    public class Diamonds : IItem
    {
        Rectangle[] diamonds;
        private Rectangle diamondsD;
        Texture2D diamondDraw;


        int currentA, previousA;
        float speed, tt;
        private int middle, left, right;

        public Diamonds(Texture2D diamondSprite,Vector2 pos)
        {
            diamondDraw = diamondSprite;
            diamonds = new Rectangle[3];
            diamonds[0] = new Rectangle(270, 225, 20, 20);
            diamonds[1] = new Rectangle(240, 224, 20, 20);
            diamonds[2] = new Rectangle(270, 224, 20, 20);
            diamondsD = new Rectangle((int)pos.X, (int)pos.Y, 50, 50);
            

            //delayTime = 500f;
            //timer = 0f;

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 50;

            middle = 2;
            left = 0;
            right = 1;

        }

        public void Update(GameTime gameTime)
        {


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


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(diamondDraw, diamondsD, diamonds[currentA], Color.White);

        }
    }
}



