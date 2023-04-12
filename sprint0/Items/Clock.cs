using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Clock: IItem
    {
        Rectangle clockS;
        Rectangle clockD;

        private Vector2 thisPos;
        Texture2D clockDraw;

        public Clock(Texture2D clockSprite, Vector2 pos)
		{
            clockS = new Rectangle(380, 160, 30, 30);
            clockD = new Rectangle((int)pos.X, (int)pos.Y, 50, 50);

            thisPos = pos;
            clockDraw = clockSprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(clockDraw, clockD, clockS, Color.White);

        }

    }
}

