﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class EdgeBlock : IBlock
    {


        Rectangle edgeS;
        Rectangle edgeD;

        Texture2D blockDraw;

        public EdgeBlock(Texture2D blockSprite, Texture2D blockRoom,Vector2 pos)
        {
            edgeS = new Rectangle(1358, 247, 18, 18);
            edgeD = new Rectangle((int)pos.X, (int)pos.Y, 18, 18);

            blockDraw = blockRoom;
        }

        public void Update(GameTime gameTime, Game1 game)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, edgeD, edgeS, Color.White);

        }

    }
}



