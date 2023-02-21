using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Content;

namespace sprint0
{
	public class ThrowFire : Content.IShoot
	{
		Texture2D thisFire;
        Rectangle[] fire;
        Vector2 thisPos;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;

        public ThrowFire(Texture2D fireTex, Vector2 pos)
		{
            thisPos = pos;
			thisFire = fireTex;
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

            spriteBatch.Draw(thisFire, thisPos, fire[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
	}
}

