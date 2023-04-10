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
        Texture2D canDraw;

        public Can(Texture2D canSprite, Vector2 pos)
        {
            can = new Rectangle(350, 250, 30, 30);
            thisPos = pos;
            canDraw = canSprite;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(canDraw, thisPos, can, Color.White);
        }

    }
}

