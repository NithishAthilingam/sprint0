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
        Texture2D blockDraw;

        public BlueBlock(Texture2D blockSprite, Vector2 pos)
        {
            blue = new Rectangle(353, 80, 16, 16);
            thisPos = pos;
            blockDraw = blockSprite;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, thisPos, blue, Color.White);

        }
    }
}

