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
        Rectangle fireD;
        private Vector2 thisPos;
        Texture2D fireDraw;


        int currentA, previousA;
        float speed, tt;
        private int middle, left, right;



        public Fire(Texture2D fireSprite,Vector2 pos)
        {
          //  Console.WriteLine("draw fire ");

            fireDraw = fireSprite;
            fire = new Rectangle[3];
            fire[0] = new Rectangle(290, 0, 30, 30);
            fire[1] = new Rectangle(290, 30, 30, 30);
            fire[2] = new Rectangle(290, 0, 30, 30);
            fireD= new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            thisPos = pos;

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

        public void Update(GameTime gameTime, Game1 game)
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

            spriteBatch.Draw(fireDraw, fireD, fire[currentA], Color.White);

        }
    }
}




