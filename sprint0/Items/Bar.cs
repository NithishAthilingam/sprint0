using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class Bar : IItem

    {
        Rectangle barS;
        Rectangle barD;
        Texture2D barDraw;
        Rectangle link;
        Boolean intersect;
        bool intersectDraw;

        public Bar(Texture2D arrowSprite, Vector2 pos)
        {
            barS = new Rectangle(268, 253, 30, 30);
            barD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            barDraw = arrowSprite;
            intersect = false;

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(barDraw, barD, barS, Color.White);
            }
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(barD))
            {
                intersect = true;
                intersectDraw = true;
            }
            else
            {
                intersect = false;
            }
            if (intersect && game.currentRoomsRoom.roomItem[11] > 0)
            {
                game.currentRoomsRoom.roomItem[11] = game.currentRoomsRoom.roomItem[11] - 1;
                if (game.inventory.ContainsKey(11))
                {
                    game.inventory[11] = game.inventory[11] + 1;
                    game.keyCountInventory = game.inventory[11].ToString();
                }
                else
                {
                    game.inventory.Add(11, 1);
                    game.keyCountInventory = game.inventory[8].ToString();
                }
                Debug.WriteLine("sound played");
                game.soundEffects.ItemPickup();

            }
        }
    }
}
