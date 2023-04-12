using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
	public interface IRoom
	{
        public void Update(GameTime gameTime);
        public void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime, Game1 game);
        

    }
}

