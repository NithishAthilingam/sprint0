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
        Rectangle ladyD;
        private Vector2 thisPos;
        Texture2D ladyDraw;

        public LadyItem(Texture2D ladySprite, Vector2 pos)
        {
            lady = new Rectangle(150, 30, 24, 25);
            ladyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            thisPos = pos;
            ladyDraw = ladySprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ladyDraw, ladyD, lady, Color.White);

        }
    }
}

