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
    public class Blocks : IItem
    {
        Rectangle[] recs;

        int currentImageIndex;
        private Texture2D b;

        float delayTime;
        float timer;
        Rectangle source2;
        Rectangle des;



        public Blocks(Texture2D blocks)
        {
            currentImageIndex = 0;
            b = blocks;
            recs = new Rectangle[13];

            delayTime = 500f;
            timer = 0f;

            recs = new Rectangle[8];

            recs[0] = new Rectangle(0, 0, 160, 165);

            recs[1] = new Rectangle(160, 0, 160, 160);

            recs[2] = new Rectangle(320, 0, 160, 160);

            recs[3] = new Rectangle(480, 0, 160, 160);


            recs[4] = new Rectangle(0, 160, 160, 160);

            recs[5] = new Rectangle(160, 160, 160, 160);

            recs[6] = new Rectangle(320, 160, 160, 160);

            recs[7] = new Rectangle(480, 160, 160, 160);








            des = new Rectangle(100, 400, 50, 50);



        }

        public void Update(GameTime gameTime)
        {

            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer <= 0f)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Y))
                {
                    currentImageIndex++;
                    if (currentImageIndex >= recs.Length)
                    {
                        currentImageIndex = recs.Length - 1;
                    }
                    timer = delayTime;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.T))
                {
                    currentImageIndex--;
                    if (currentImageIndex < 0)
                    {
                        currentImageIndex = 0;
                    }
                    timer = delayTime;
                }
            }



         

        }

        public void Draw(SpriteBatch spriteBatch)
        {
        spriteBatch.Draw(b, des, recs[currentImageIndex], Color.White);
        }

        }
    }

