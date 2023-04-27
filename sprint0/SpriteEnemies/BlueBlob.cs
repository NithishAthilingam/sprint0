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

namespace sprint0
{
    public class BlueBlob : Ienemy
    {
        public Vector2 thisPos;
        Vector4 value;
        int id;
        private int frames = 0;
        Rectangle[] blob;
        Rectangle source2;

        Texture2D sprite;
        Random random;

        public BlueBlob(int enemyID, Texture2D enemiesSprite, Vector2 pos)
        {
            id = enemyID;
            sprite = enemiesSprite;
            thisPos = pos;

            thisPos.Y -= 100;

            blob = new Rectangle[2];
            blob[0] = new Rectangle(404, 184, 10, 10);
            blob[1] = new Rectangle(404, 213, 10, 10);
            source2 = blob[0];
            random = new Random();
        }

        public void Update(GameTime gameTime, Game1 game)
        {

            if (thisPos.X > 0)
            {
                frames++;
                if ((frames % 20 == 0) && source2 == blob[0])
                {
                    source2 = blob[1];
                }
                else if ((frames % 20 == 0) && source2 == blob[1])
                {
                    source2 = blob[0];
                }

                int next = random.Next(0, 3);

                if ((thisPos.X >= 90 && thisPos.X <= 665) && (thisPos.Y >= 60 && thisPos.Y <= 372))
                {
                    if (thisPos.Y <= 60 || next == 0)
                    {
                        thisPos.Y += 2;
                        game.EnemyPos.Y = thisPos.Y;
                    }
                    else if (thisPos.Y >= 372 || next == 1)
                    {
                        thisPos.Y -= 2;
                        game.EnemyPos.Y = thisPos.Y;

                    }
                    else if (thisPos.X <= 90 || next == 2)
                    {
                        thisPos.X += 2;
                        game.EnemyPos.X = thisPos.X;

                    }
                    else if (thisPos.X >= 665 || next == 3)
                    {
                        thisPos.X -= 2;
                        game.EnemyPos.X = thisPos.X;
                    }
                }
                else
                {
                    if (thisPos.X < 90)
                    {
                        thisPos.X += 3;
                    }
                    else if (thisPos.X > 665)
                    {
                        thisPos.X -= 3;
                    }
                    else if (thisPos.Y < 60)
                    {
                        thisPos.Y += 3;
                    }
                    else if (thisPos.Y > 372)
                    {
                        thisPos.Y -= 3;
                    }
                }

                if (frames == 301)
                {
                    frames = 0;
                }
            }
            else
            {
                thisPos.X = 0;
            }
            if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                game.currentRoomsRoom.enemiesD.TryGetValue(id, out value);
                value.X = thisPos.X;
                value.Y = thisPos.Y;
                value.Z = 20;
                value.W = 20;
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