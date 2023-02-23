using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
    public class ThrowFire : Isprite
    {
        Texture2D thisFire;
        Rectangle[] fire;
        Vector2 thisPos;
        char thisDirec;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;

        public ThrowFire(Vector2 pos, char direc)
        {
            thisPos = pos;
            //thisFire = fireTex;
            thisDirec = direc;
            fire = new Rectangle[3];
            fire[0] = new Rectangle(290, 0, 30, 30);
            fire[1] = new Rectangle(290, 30, 30, 30);
            fire[2] = new Rectangle(290, 0, 30, 30);

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

            if (thisDirec == 's')
            {
                thisPos.Y += 3;
            }
            else if (thisDirec == 'a')
            {
                thisPos.X -= 3;
            }
            else if (thisDirec == 'w')
            {
                thisPos.Y -= 3;
            }
            else if (thisDirec == 'd')
            {
                thisPos.X += 3;
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
    

		public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
		{
            spriteBatch.Draw(animate[7], thisPos, fire[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
	}
}

