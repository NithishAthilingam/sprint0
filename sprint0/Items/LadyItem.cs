using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;

namespace sprint0
{
	public class LadyItem : IItem
    {


        Rectangle lady;
        private Vector2 thisPos;
        Texture2D ladyDraw;

        public LadyItem(Texture2D ladySprite, Vector2 pos)
        {
            lady = new Rectangle(150, 30, 24, 25);
            thisPos = pos;
            ladyDraw = ladySprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ladyDraw, thisPos, lady, Color.White);

        }
    }
}

