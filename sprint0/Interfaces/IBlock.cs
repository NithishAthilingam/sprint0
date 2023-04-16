﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
	public interface IBlock
	{

        public void Update(GameTime gameTime, Game1 game);

        public void Draw(SpriteBatch spriteBatch);

    }
}



