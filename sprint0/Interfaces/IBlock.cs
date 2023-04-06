using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
	public interface IBlock
	{

        public void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate);

    }
}



