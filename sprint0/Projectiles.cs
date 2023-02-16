using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Projectiles
	{
        private Game1 game1;
        private Texture2D i;
        Rectangle blueArrow;
        Rectangle greenArrow;
        Rectangle des;
        Vector2 p;
        private float s;






        public Projectiles(Game1 myGame,Texture2D items, Vector2 position)
		{
			i = items;
            game1 = myGame;

            blueArrow = new Rectangle(0, 120, 20, 15);
            greenArrow = new Rectangle(0, 40, 20, 15);
            s = 2.0f;

            p = position;

            des = new Rectangle(100, 200, 80, 80);

        }


        public void Update(GameTime gameTime)
		{
           
               p.X += s;
            if (p.X > game1.GraphicsDevice.Viewport.Width/2)
            {
                p.X = 0;
                p.Y = game1.GraphicsDevice.Viewport.Height / 2;
            }
        }

		public void Draw(SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(i, p, blueArrow, Color.White);

        }

    }
    }

