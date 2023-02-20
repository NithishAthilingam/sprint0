using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Reflection;

namespace sprint0
{
    public class LeftSprite : Isprite
    {
        public Vector2 thisPos;

        int threshold;
        float timer;
        byte previousA;
        byte currentA;
        
        Rectangle[] animated;

        public LeftSprite(Vector2 posi)
        {
            thisPos = posi;
        }

        public void Update(GameTime gameTime)
        {
            threshold = 250;
            timer = 0;

            animated = new Rectangle[3];
            animated[0] = new Rectangle(0, 30, 20, 20);
            animated[1] = new Rectangle(30, 30, 20, 20);
            animated[2] = new Rectangle(0, 30, 20, 20);

            previousA = 2;
            currentA = 1;

            if(timer > threshold)
            {
                if (currentA == 1)
                {
                    if(previousA == 0)
                    {
                        currentA = 2;
                    }
                    else
                    {
                        currentA = 0;
                    }
                    previousA = currentA;
                }
                else
                {
                    currentA = 2;
                }
                timer = 0;
            }
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source2 = new Rectangle(30, 30, 20, 20);
            //Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], pos, animated[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
    }
}


