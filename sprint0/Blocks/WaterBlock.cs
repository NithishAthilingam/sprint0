using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class WaterBlock : IBlock
	{


        Rectangle waterS;
        Rectangle waterD;

        private Vector2 thisPos;
        Texture2D blockDraw;

        public WaterBlock(Texture2D blockSprite, Texture2D blockRoom, Vector2 pos)
        {
            waterS = new Rectangle(545, 200, 18, 18);
            waterD = new Rectangle((int)pos.X, (int)pos.Y, 18, 18);

            blockDraw = blockRoom;
        }


        public void Update(GameTime gameTime, Game1 game)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, waterD, waterS, Color.White);

        }
    }
}

