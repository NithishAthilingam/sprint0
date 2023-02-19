using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
#pragma warning disable CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace
using Microsoft.Xna.Framework.Graphics;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
#pragma warning restore CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace
namespace sprint0
{
    public class Item : IItem
    {
        Rectangle[] recs;
        Rectangle[] hearts;
        Rectangle[] diamonds;
        Rectangle[] tri;
        Rectangle[] fire;

        int currentImageIndex;
        private Texture2D z;
        private Texture2D f;
        //Rectangle currentSourceRectangle;
        //Rectangle destinationRectangle;
        float delayTime;
        float timer;
        //Rectangle source2;
        Rectangle des;

        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;

        public Item(Texture2D zelda, Texture2D fireTex)
        {
            currentImageIndex = 0;
            z = zelda;
            f = fireTex;
            recs = new Rectangle[13];

            delayTime = 500f; 
            timer = 0f;

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 50;

            middle = 2;
            left = 0;
            right = 1;

            recs = new Rectangle[12];

            //blue dimond
            recs[0] = new Rectangle(270, 225, 30, 30);
            recs[3] = new Rectangle(270, 250, 30, 30);
            //key
            recs[4] = new Rectangle(350, 250, 30, 30);
            //heart w/ boarder
            recs[6] = new Rectangle(290, 185, 30, 30);
            //can thing
            recs[7] = new Rectangle(375, 250, 30, 30);
            //clock
            recs[8] = new Rectangle(380, 160, 30, 30);
            //arrow
            recs[9] = new Rectangle(415, 250, 17, 30);
            //bomb
            recs[10] = new Rectangle(350, 225, 30, 30);
            //blue dimond
            recs[11] = new Rectangle(270, 225, 20, 20);

            hearts = new Rectangle[3];
            hearts[0] = new Rectangle(230, 185, 30, 30);
            hearts[1] = new Rectangle(260, 185, 30, 30);
            hearts[2] = new Rectangle(230, 185, 30, 30);


            diamonds = new Rectangle[3];
            diamonds[0] = new Rectangle(270, 225, 30, 30);
            diamonds[1] = new Rectangle(240, 225, 30, 30);
            diamonds[2] = new Rectangle(270, 225, 30, 30);

            tri = new Rectangle[3];
            tri[0] = new Rectangle(350, 275, 30, 30);
            tri[1] = new Rectangle(350, 275, 30, 30);
            tri[2] = new Rectangle(350, 275, 30, 30);

            fire = new Rectangle[3];
            fire[0] = new Rectangle(290, 0, 30, 30);
            fire[1] = new Rectangle(290, 30, 30, 30);
            fire[2] = new Rectangle(290, 0, 30, 30);

            des = new Rectangle(600, 200, 80, 80);

        }

        public void Update(GameTime gameTime)
        {

            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer <= 0f)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.U))
                {
                    currentImageIndex++;
                    if (currentImageIndex >= recs.Length)
                    {
                        currentImageIndex = recs.Length - 1;
                    }
                    timer = delayTime;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.I))
                {
                    currentImageIndex--;
                    if (currentImageIndex < 0)
                    {
                        currentImageIndex = 0;
                    }
                    timer = delayTime;
                }
            }


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

            if (currentImageIndex == 1)
            {
                spriteBatch.Draw(f, des, fire[currentA], Color.White);
            }

            if (currentImageIndex == 2)
            {
                spriteBatch.Draw(z, des, diamonds[currentA], Color.White);
            }

            if (currentImageIndex == 5)
            {
                spriteBatch.Draw(z, des, hearts[currentA], Color.White);
            }
            else
              spriteBatch.Draw(z, des, recs[currentImageIndex], Color.White);

            }

        }
    }
