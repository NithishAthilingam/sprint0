using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace sprint0
{
	public class RightSprite2 : Isprite
	{
        public Vector2 thisPos;
        Rectangle[] run;
        Rectangle source2;
        private Vector2 location = new Vector2(220, 100);
        private int frames = 0;

        public RightSprite2(Vector2 posi)
		{
            thisPos = posi;
		}

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            Rectangle source2 = new Rectangle(90, 30, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
    }
}

