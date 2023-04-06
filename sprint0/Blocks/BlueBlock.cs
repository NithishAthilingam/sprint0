using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class BlueBlock : IBlock
	{


        Rectangle blue;
        private Vector2 thisPos;

        public BlueBlock(Vector2 pos)
		{
            blue = new Rectangle(353, 80, 16, 16);
            thisPos = pos;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[8], thisPos, blue, Color.White);
        }
    }
}

