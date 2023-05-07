using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace sprint0
{
	public class LadyItem : IItem
    {


        Rectangle lady;
        Rectangle ladyD;
        Texture2D ladyDraw;
        Rectangle link;
        Boolean intersect;
        bool intersectDraw;

        public LadyItem(Texture2D ladySprite, Vector2 pos)
        {
            lady = new Rectangle(150, 30, 24, 25);
            ladyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            intersectDraw = false;
            ladyDraw = ladySprite;
            intersect = false;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(ladyD))
            {
                intersect = true;
                intersectDraw = true;

            }
            else
            {
                intersect = false;
            }
            if (intersect)
            {
                //game.currentRoomsRoom.roomItem[9] = game.currentRoomsRoom.roomItem[9] - 1;
                if (game.inventory.ContainsKey(9))
                {
                    game.inventory[9] = game.inventory[9] + 1;
                    game.keyCountInventory = game.inventory[9].ToString();
                }
                else
                {
                    game.inventory.Add(9, 1);
                    game.keyCountInventory = game.inventory[9].ToString();
                }
                Debug.WriteLine("sound played");
                game.soundEffects.ItemPickup();

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(ladyDraw, ladyD, lady, Color.White);
            }

        }
    }
}

