using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;

namespace sprint0
{
	public class Arrow : IItem
    {
        Rectangle arrow;
        private Vector2 thisPos;

        public Arrow(Vector2 pos)
        {
           arrow = new Rectangle(350, 250, 30, 30);
           thisPos = pos;
		}

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, arrow, Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}

