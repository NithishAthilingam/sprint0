using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class EdgeBlock : IBlock
    {


        Rectangle edge;
        private Vector2 thisPos;
        Texture2D blockDraw;

        public EdgeBlock(Texture2D blockSprite, Vector2 pos)
        {
            edge = new Rectangle(1358, 248, 16, 16);
            thisPos = pos;
            blockDraw = blockSprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, thisPos, edge, Color.White);

        }

    }
}



