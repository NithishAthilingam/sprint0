using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Clock: IItem
    {
        Rectangle clock;
        private Vector2 thisPos;

        public Clock(Vector2 pos)
		{
            clock = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, clock , Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}

