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
    public class Fire : IItem
    {
        Rectangle[] fire;
        private Vector2 thisPos;
        Texture2D fireDraw;

        float delayTime;
        float timer;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;



        public Fire(Texture2D fireSprite,Vector2 pos)
        {
            fireDraw = fireSprite;
            fire = new Rectangle[3];
            fire[0] = new Rectangle(350, 275, 30, 30);
            fire[1] = new Rectangle(350, 275, 30, 30);
            fire[2] = new Rectangle(350, 275, 30, 30);

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

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(fireDraw, thisPos, fire[currentA], Color.White);

        }
    }
}




