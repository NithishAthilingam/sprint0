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
        private Vector2 thisPos;

        float delayTime;
        float timer;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;



        public Diamonds(Vector2 pos)
        {

            diamonds = new Rectangle[3];
            diamonds[0] = new Rectangle(270, 225, 30, 30);
            diamonds[1] = new Rectangle(240, 225, 30, 30);
            diamonds[2] = new Rectangle(270, 225, 30, 30);
            thisPos = pos;

            delayTime = 500f;
            timer = 0f;

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


        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, diamonds[currentA], Color.White);
        }
    }
}



