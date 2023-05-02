using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;

namespace sprint0
{
	public class LadyItem : IItem
    {


        Rectangle lady;
        Rectangle ladyD;
        Texture2D ladyDraw;
        Rectangle link;
        Boolean intersect;

        public LadyItem(Texture2D ladySprite, Vector2 pos)
        {
            lady = new Rectangle(150, 30, 24, 25);
            ladyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            ladyDraw = ladySprite;
            intersect = false;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(ladyD))
            {
                intersect = true;

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersect)
            {
                spriteBatch.Draw(ladyDraw, ladyD, lady, Color.White);
            }

        }
    }
}

