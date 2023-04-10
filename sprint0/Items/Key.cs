using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
	public class Key : IItem
	{
	
        Rectangle key;
        private Vector2 thisPos;
        Texture2D keyDraw;

        public Key(Texture2D keySprite, Vector2 pos)
        {
            key = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
            keyDraw = keySprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(keyDraw, thisPos, key, Color.White);

        }
    }
}



