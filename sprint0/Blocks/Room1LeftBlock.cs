using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class Room1LeftBlock : IBlock
    {


        Rectangle left;
        private Vector2 thisPos;
        Texture2D blockDraw;

        public Room1LeftBlock(Texture2D blockSprite, Vector2 pos)
        {
            left = new Rectangle(1358, 248, 16, 16);
            thisPos = pos;
            blockDraw = blockSprite;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, thisPos, left, Color.White);

        }
    }
}




