using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class BlueBlock : IBlock
    {


        Rectangle blueS;
        Rectangle blueD;

        private Vector2 thisPos;
        Texture2D blockDraw;

        public BlueBlock(Texture2D blockSprite, Texture2D blockRoom, Vector2 pos)
        {
            blueS = new Rectangle(365, 567, 18, 18);
            blueD = new Rectangle((int)pos.X, (int)pos.Y, 18, 18);

            blockDraw = blockRoom;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, blueD, blueS, Color.White);

        }
    }
}

