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

        public EdgeBlock(Vector2 pos)
        {
            edge = new Rectangle(1358, 248, 16, 16);
            thisPos = pos;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[8], thisPos, edge, Color.White);

        }
    }
}



