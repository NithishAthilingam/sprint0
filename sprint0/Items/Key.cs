using System;
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
        Texture2D keyDraw;
        Rectangle link;
        Boolean intersect;

        public Key(Texture2D keySprite, Vector2 pos)
        {
            key = new Rectangle(350, 250, 30, 30);
            keyD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

            keyDraw = keySprite;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
 
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(keyD))
            {
                intersect = true;
            }
            if (intersect && game.currentRoomsRoom.roomItem[8] > 0)
            {
                Debug.WriteLine("room key before:" + game.currentRoomsRoom.roomItem[8]);
                game.currentRoomsRoom.roomItem[8] = game.currentRoomsRoom.roomItem[8] - 1;
                Debug.WriteLine("room key after:" + game.currentRoomsRoom.roomItem[8]);
                if (game.inventory.ContainsKey(8))
                {
                    game.inventory[8] = game.inventory[8] + 1;
                }
                else
                {
                    game.inventory.Add(8, 1);
                    Debug.WriteLine("inventory key:" + game.inventory[8]);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersect)
            {
                spriteBatch.Draw(keyDraw, keyD, key, Color.White);
            }
        }
    }
}



