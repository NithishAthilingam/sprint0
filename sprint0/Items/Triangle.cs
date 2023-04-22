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
    public class Triangle : IItem
    {
        Rectangle[] triangle;
        Rectangle triangleD;
        Texture2D triDraw;


        int currentA, previousA;
        float speed, tt;
        private int middle, left, right;





        public Triangle(Texture2D triSprite,Vector2 pos)
        {
            triDraw = triSprite;
            triangle = new Rectangle[3];
            triangle[0] = new Rectangle(350, 275, 30, 30);
            triangle[1] = new Rectangle(320, 275, 30, 30);
            triangle[2] = new Rectangle(350, 275, 30, 30);
            triangleD = new Rectangle((int)pos.X, (int)pos.Y, 100, 100);


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
            spriteBatch.Draw(triDraw, triangleD, triangle[currentA], Color.White);

        }
    }
}



