using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
    public class Boomerang : Isprite
    {
        Rectangle boomerang;
        Vector2 thisPos;

        public Boomerang(Vector2 pos, char direc)
        {
            thisPos = pos;

            boomerang = new Rectangle(129, 3, 6, 12);
        }

		public void Update(GameTime gameTime)
		{

        }
    

		public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
		{
            spriteBatch.Draw(animate[11], thisPos, boomerang, Color.White, 2.0f, new Vector2(18, 36), new Vector2(3, 3), 0, 0);
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D animate, Vector2 pos)
        {

        }
    }
}

