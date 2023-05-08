using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Items;

namespace sprint0
{
	public class Clock: IItem
    {
        Rectangle clockS;
        Rectangle clockD;

        Rectangle link;
        bool intersectDraw;
        Texture2D clockDraw;
        Boolean intersect;

        public Clock(Texture2D clockSprite, Vector2 pos)
		{
            clockS = new Rectangle(330, 160, 30, 30);
            clockD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            intersectDraw = false;
            clockDraw = clockSprite;
            intersect = false;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            Inventory test = new Inventory();
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(clockD))
            {
                intersect = true;
                intersectDraw = true;
            }
            else
            {
                intersect = false;
            }
            if (intersect && game.currentRoomsRoom.roomItem[3] > 0)
            {
                game.currentRoomsRoom.roomItem[3] = game.currentRoomsRoom.roomItem[3] - 1;
                if (game.inventory.ContainsKey(3))
                {
                    game.inventory[3] = game.inventory[3] + 1;
                    game.keyCountInventory = game.inventory[3].ToString();
                }
                else
                {
                    game.inventory.Add(3, 1);
                    game.keyCountInventory = game.inventory[8].ToString();
                }
                //Debug.WriteLine("sound played");
                //game.soundEffects.ItemPickup();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(clockDraw, clockD, clockS, Color.White);
            }

        }

    }
}

