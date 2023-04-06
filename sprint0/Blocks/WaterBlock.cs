using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class WaterBlock : IBlock
	{


        Rectangle water;
        private Vector2 thisPos;

        public WaterBlock(Vector2 pos)
		{
            water = new Rectangle(353, 80, 16, 16);
            thisPos = pos;
        }


        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[8], thisPos, water, Color.White);

        }
    }
}

