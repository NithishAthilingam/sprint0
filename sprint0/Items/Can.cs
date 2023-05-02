using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
	public class Can : IItem
	{

        Rectangle canS;
        Rectangle canD;
        Rectangle link;
        Texture2D canDraw;
        Boolean intersect;

        public Can(Texture2D canSprite, Vector2 pos)
        {
            canS = new Rectangle(375, 250, 30, 30);
            canD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            canDraw = canSprite;
            intersect = false; 


        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(canD))
            {
                intersect = true;

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersect)
            {
                spriteBatch.Draw(canDraw, canD, canS, Color.White);
            }
        }

    }
}

