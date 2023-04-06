using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
	public class Key : IItem
	{
	
        Rectangle key;
        private Vector2 thisPos;

        public Key(Vector2 pos)
        {
            key = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, key, Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}



