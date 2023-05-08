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
        bool intersectDraw;

        public Can(Texture2D canSprite, Vector2 pos)
        {
            canS = new Rectangle(375, 250, 30, 30);
            canD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            canDraw = canSprite;
            intersect = false;
            intersectDraw = false;

        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(canD))
            {
                intersect = true;
                intersectDraw = true;
            }
            else
            {
                intersect = false;
            }
            if (intersect && game.currentRoomsRoom.roomItem.ContainsKey(2))
            {
                game.currentRoomsRoom.roomItem[2] = game.currentRoomsRoom.roomItem[2] - 1;
                if (game.inventory.ContainsKey(2))
                {
                    game.inventory[2] = game.inventory[2] + 1;
                }
                else
                {
                    game.inventory.Add(2, 1);
                }
                //game.soundEffects.ItemPickup();
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(canDraw, canD, canS, Color.White);
            }
        }

    }
}

