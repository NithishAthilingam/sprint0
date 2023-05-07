using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Items;
using sprint0.Sound;

namespace sprint0
{
	public class Key : IItem
	{
	
        Rectangle key;
        Rectangle keyD;
        Texture2D keyDraw;
        Rectangle link;
        bool intersect;
        bool intersectDraw; 
        bool hasKey;
        Game1 game1;

        public Key(Texture2D keySprite, Vector2 pos)
        {
            key = new Rectangle(350, 250, 30, 30);
            keyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            keyDraw = keySprite;
            intersect = false;
            intersectDraw = false;
            hasKey = false;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            game1 = game;
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(keyD))
            {
                intersect = true;
                intersectDraw = true;
            }
            else
            {
                intersect = false;
            }
            if (intersect && game.currentRoomsRoom.roomItem[8] > 0)
            { 
                game.currentRoomsRoom.roomItem[8] = game.currentRoomsRoom.roomItem[8] - 1;
                if (game.inventory.ContainsKey(8))
                {
                    game.inventory[8] = game.inventory[8] + 1;
                    game.keyCountInventory = game.inventory[8].ToString();
                }
                else
                {
                    game.inventory.Add(8, 1);
                    game.keyCountInventory = game.inventory[8].ToString();
                }
                hasKey = true;
                Debug.WriteLine("sound played");
                game.soundEffects.KeyPickup();

            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(keyDraw, keyD, key, Color.White);
            }

            

        }
    }
}



