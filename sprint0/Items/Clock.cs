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
        Texture2D clockDraw;

        public Clock(Texture2D clockSprite, Vector2 pos)
		{
            clock = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
            clockDraw = clockSprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(clockDraw, thisPos, clock, Color.White);

        }

    }
}

