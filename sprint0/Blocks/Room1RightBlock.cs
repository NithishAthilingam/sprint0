using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class Room1RightBlock : IBlock
    {


        Rectangle right;
        private Vector2 thisPos;

        public Room1RightBlock(Vector2 pos)
        {
            right = new Rectangle(1358, 248, 16, 16);
            thisPos = pos;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[8], thisPos, right, Color.White);

        }
    }
}




