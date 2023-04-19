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

        Rectangle link;

        private Vector2 thisPos;
        Texture2D clockDraw;
        Boolean intersect;

        public Clock(Texture2D clockSprite, Vector2 pos)
		{
            clockS = new Rectangle(380, 160, 30, 30);
            clockD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            clockDraw = clockSprite;
            intersect = false;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            intersect = link.Intersects(clockD);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersect)
            {
                spriteBatch.Draw(clockDraw, clockD, clockS, Color.White);
            }

        }

    }
}

