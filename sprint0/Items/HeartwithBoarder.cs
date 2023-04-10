using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class HeartwithBoarder : IItem
    {

        Rectangle heart;
        private Vector2 thisPos;
        Texture2D heartDraw;

        public HeartwithBoarder(Texture2D heartBorderSprite, Vector2 pos)
		{
            heartDraw = heartBorderSprite;
            heart = new Rectangle(290, 185, 30, 30);
            thisPos = pos;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[4], thisPos, heart, Color.White);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heartDraw, thisPos, heart, Color.White);

        }
    }
}

