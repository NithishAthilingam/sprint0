using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Items;

namespace sprint0
{
	public class Key : IItem
	{
	
        Rectangle key;
        Rectangle keyD;
        Rectangle firstDes;
        Rectangle middleDes;
        Rectangle lastDes;
        Texture2D keyDraw;
        Texture2D keyDraw2;
        Rectangle link;
        Boolean intersect;
        int inc;
        Boolean hasKey;
        Game1 game1;

        public Key(Texture2D keySprite, Vector2 pos)
        {
            key = new Rectangle(350, 250, 30, 30);
            keyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);
            firstDes = new Rectangle(0, -3, 35, 35);
            middleDes = new Rectangle(30, -3, 35, 35);
            lastDes = new Rectangle(60, -3, 35, 35);
            keyDraw = keySprite;
            keyDraw2 = keySprite;
            hasKey = false;
            inc = 0;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            game1 = game;
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(keyD))
            {
                intersect = true;

            }
            if (intersect && game.currentRoomsRoom.roomItem.ContainsKey(8))
            { 
                Debug.WriteLine("room key before:" + game.currentRoomsRoom.roomItem[8]);
                game.currentRoomsRoom.roomItem[8] = game.currentRoomsRoom.roomItem[8] - 1;
                Debug.WriteLine("room key after:" + game.currentRoomsRoom.roomItem[8]);
                if (game.inventory.ContainsKey(8))
                {
                    game.inventory[8] = game.inventory[8] + 1;
                    Debug.WriteLine("inventory key:" + game.inventory[8]);
                }
                else
                {
                    game.inventory.Add(8, 1);
                    Debug.WriteLine("inventory key:" + game.inventory[8]);
                }
                hasKey = true;
                inc++;
                //Debug.WriteLine("inventory key:" + game.inventory[8]);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersect)
            {
                spriteBatch.Draw(keyDraw, keyD, key, Color.White);
            }
            if (game1.inventory.ContainsKey(8))
            {
                spriteBatch.Draw(keyDraw2, firstDes, key, Color.White);
            }
            if (inc == 1)
            {
                spriteBatch.Draw(keyDraw2, firstDes, key, Color.White);
            }
            else if(inc == 2)
            {
                spriteBatch.Draw(keyDraw2, firstDes, key, Color.White);
                spriteBatch.Draw(keyDraw2, middleDes, key, Color.White);
            }
            else if (inc == 3)
            {
                spriteBatch.Draw(keyDraw2, firstDes, key, Color.White);
                spriteBatch.Draw(keyDraw2, middleDes, key, Color.White);
                spriteBatch.Draw(keyDraw2, lastDes, key, Color.White);
            }
        }
    }
}



