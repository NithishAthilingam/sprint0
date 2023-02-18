using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
	public class Projectiles : IItem

    {
        private Game1 game1;
        private Texture2D i;
        Rectangle blueArrow;
        Rectangle greenArrow;
        Rectangle des;
        Rectangle[] fire;
        Vector2 p;
        int currentA;
        int previousA;
        float speed;
        float tt;
        float timer;
        private int middle;
        private int left;
        private int right;
        int currentImageIndex;
        private Texture2D f;


        public Projectiles(Game1 myGame,Texture2D items, Texture2D fires, Vector2 position)
		{
			i = items;
            f = fires;
            game1 = myGame;

            timer = 0f;

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 10;

            middle = 2;
            left = 0;
            right = 1;

            blueArrow = new Rectangle(0, 120, 20, 15);
            greenArrow = new Rectangle(0, 40, 20, 15);

            fire = new Rectangle[3];

            fire[0] = new Rectangle(290, 0, 30, 30);
            fire[1] = new Rectangle(290, 30, 30, 30);
            fire[2] = new Rectangle(290, 0, 30, 30);

            p = position;

            des = new Rectangle(100, 200, 80, 80);

        }


        public void Update(GameTime gameTime)
        {

            if (p.X > 0)
            {

                    // if (p.X > game1.GraphicsDevice.Viewport.Width / 4)

                    // p.X = game1.GraphicsDevice.Viewport.Width/4;
                    p.Y = game1.GraphicsDevice.Viewport.Height / 4;
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
            spriteBatch.Draw(i, p, blueArrow, Color.White);
            spriteBatch.Draw(f, des, fire[currentA], Color.White);
        }

 
    }
    }

