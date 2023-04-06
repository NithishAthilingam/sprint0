using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Can : IItem
	{

        Rectangle can;
        private Vector2 thisPos;

        public Can(Vector2 pos)
        {
            can = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, can, Color.White);
        }

        public void Update(GameTime gameTime)
        {

        }
    }
}

