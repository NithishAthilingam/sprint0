using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Can : IItem
	{

        Rectangle canS;
        Rectangle canD;

        private Vector2 thisPos;
        Texture2D canDraw;

        public Can(Texture2D canSprite, Vector2 pos)
        {
            canS = new Rectangle(375, 250, 30, 30);
            thisPos = pos;
            canDraw = canSprite;
            canD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

        }

        public void Update(GameTime gameTime, Game1 game)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(canDraw, canD, canS, Color.White);
        }

    }
}

