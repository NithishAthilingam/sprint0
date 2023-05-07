using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using sprint0.HealthBar;
using System.Reflection;

namespace sprint0
{
    public class Diamonds : IItem
    {
        Rectangle[] diamonds;
        private Rectangle diamondsD;
        Texture2D diamondDraw;
        Rectangle link;
        bool intersect;
        bool intersectDraw;
        int currentA, previousA;
        float speed, tt;
        private int middle, left, right;

        public Diamonds(Texture2D diamondSprite,Vector2 pos)
        {
            diamondDraw = diamondSprite;
            diamonds = new Rectangle[3];
            diamonds[0] = new Rectangle(270, 225, 20, 20);
            diamonds[1] = new Rectangle(240, 224, 20, 20);
            diamonds[2] = new Rectangle(270, 224, 20, 20);
            diamondsD = new Rectangle((int)pos.X, (int)pos.Y, 50, 50);
            intersectDraw = false;
            intersect = false;

            //delayTime = 500f;
            //timer = 0f;

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 50;

            middle = 2;
            left = 0;
            right = 1;

        }

        public void Update(GameTime gameTime, Game1 game)
        {

            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            if (link.Intersects(diamondsD))
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
                game.soundEffects.ItemPickup();
            }

            if (tt > speed)
            {
                if (currentA == middle)
                {
                    if (previousA == left)
                    {
                        currentA = right;
                    }
                    else
                    {
                        currentA = left;
                    }
                    previousA = currentA;
                }
                else
                {
                    currentA = middle;
                }
                tt = 0;
            }
            else
            {
                tt += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (!intersectDraw)
            {
                spriteBatch.Draw(diamondDraw, diamondsD, diamonds[currentA], Color.White);
            }
        }
    }
}



