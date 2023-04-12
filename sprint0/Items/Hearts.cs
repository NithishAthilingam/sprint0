﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using sprint0.HealthBar;
using System.Reflection;

namespace sprint0
{
	public class Hearts : IItem
    {
        Rectangle [] hearts;
        private Vector2 thisPos;
        Rectangle heartsD;

        float delayTime;
        float timer;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;
        Texture2D heartDraw;



        public Hearts(Texture2D heartSprite,Vector2 pos)
        {
            heartDraw = heartSprite;
            hearts = new Rectangle[3];
            hearts[0] = new Rectangle(230, 185, 30, 30);
            hearts[1] = new Rectangle(260, 185, 30, 30);
            hearts[2] = new Rectangle(230, 185, 30, 30);
            heartsD= new Rectangle((int)pos.X, (int)pos.Y, 50, 50); ;
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
            spriteBatch.Draw(heartDraw, heartsD, hearts[currentA], Color.White);

        }

    }
}

