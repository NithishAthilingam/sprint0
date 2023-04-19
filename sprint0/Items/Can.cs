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
        Texture2D canDraw;

        public Can(Texture2D canSprite, Vector2 pos)
        {
            canS = new Rectangle(375, 250, 30, 30);
            canD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            canDraw = canSprite;


        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(canDraw, canD, canS, Color.White);
        }

    }
}

