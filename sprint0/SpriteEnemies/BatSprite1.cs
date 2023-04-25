using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;
using System.Diagnostics;

namespace sprint0
{
    public class BatSprite1 : Ienemy
    {
        public Vector2 thisPos;
        Vector4 value;
        private int frames = 0;
        Rectangle[] bat;
        Rectangle source2;
        int currentA;
        int previousA;
        int posChangeY;
        int posChangeX;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;
        Texture2D sprite;
        int id;
        Random rand;

        public BatSprite1(int enemyID, Texture2D enemiesSprite, Vector2 pos)
        {
            sprite = enemiesSprite;
            thisPos = pos;
            id = enemyID;

            thisPos.Y -= 100;
            value.X = pos.X;
            value.Y = pos.Y;


            bat = new Rectangle[2];
            bat[0] = new Rectangle(230, 270, 20, 20);
            bat[1] = new Rectangle(258, 270, 20, 20);
            source2 = bat[0];

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 200;

            middle = 2;
            left = 0;
            right = 1;
            posChangeY = 2;
            posChangeX = 2;
            rand = new Random();
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            int next = rand.Next(4);
            if ((thisPos.X >= 90 && thisPos.X <= 665) && (thisPos.Y >= 60 && thisPos.Y <= 372))
            {
                if (thisPos.Y <= 60 || next == 0)
                {
                    posChangeY = 2;
                }
                else if (thisPos.Y >= 372 || next == 1)
                {
                    posChangeY = -2;
                }
                else if (thisPos.X <= 90 || next == 2)
                {
                    posChangeX = 2;
                }
                else if (thisPos.X >= 665 || next == 3)
                {
                    posChangeX = -2;
                }
            }

            else
            {
                if (thisPos.X < 90)
                {
                    posChangeX = 4;
                }
                else if(thisPos.X > 665)
                {
                    posChangeX = -4;
                }
                else if(thisPos.Y < 60)
                {
                    posChangeY = 4;
                }
                else if(thisPos.Y > 372)
                {
                    posChangeY = -4;
                }
            }

            frames++;
            if ((frames % 10 == 0) && source2 == bat[0])
            {
                source2 = bat[1];
            }
            else if ((frames % 10 == 0) && source2 == bat[1])
            {
                source2 = bat[0];
            }

            if (frames == 301)
            {
                frames = 0;
            }

            thisPos.X += posChangeX;
            thisPos.Y += posChangeY;

            //projectile
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
            //game.currentRoomsRoom.enemiesD.
            if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                game.currentRoomsRoom.enemiesD.TryGetValue(id, out value);
                value.X = thisPos.X;
                value.Y = thisPos.Y;
                value.Z = 40;
                value.W = 40;
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);
                game.collideB.Update(gameTime, game, game.currentRoomsRoom, id);
                game.currentRoomsRoom.enemiesD.TryGetValue((int)id, out value);
                thisPos.X = value.X;
                thisPos.Y = value.Y;

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        }
    }
}
