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
        Texture2D blockDraw;

        public WaterBlock(Texture2D blockSprite, Vector2 pos)
        {
            water = new Rectangle(353, 80, 16, 16);
            thisPos = pos;
            blockDraw = blockSprite;
        }


        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, thisPos, water, Color.White);

        }
    }
}

