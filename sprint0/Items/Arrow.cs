using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace sprint0
{
	public class Arrow : IItem
    {
        Rectangle arrowS;
        Rectangle arrowD;
        Texture2D arrowDraw;

        public Arrow(Texture2D arrowSprite,Vector2 pos)
        {
            arrowS = new Rectangle(205, 250, 30, 30);
            arrowD = new Rectangle((int)pos.X, (int)pos.Y, 100, 100);

            arrowDraw = arrowSprite;

        }

        public void Update(GameTime gameTime)
        {
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(arrowDraw, arrowD, arrowS, Color.White);
        }
    }
}

