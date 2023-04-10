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
        Texture2D arrowDraw;

        public Arrow(Texture2D arrowSprite,Vector2 pos)
        {
           arrow = new Rectangle(350, 250, 30, 30);
           thisPos = pos;
            arrowDraw = arrowSprite;
		}

        public void Update(GameTime gameTime)
        {
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(arrowDraw, thisPos, arrow, Color.White);
        }
    }
}

