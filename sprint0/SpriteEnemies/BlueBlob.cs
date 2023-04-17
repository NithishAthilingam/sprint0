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

                if (frames <= 75)
                {
                    thisPos.X += 1;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 150)
                {
                    thisPos.Y += 1;
                    game.EnemyPos.Y = thisPos.Y;

                }
                else if (frames <= 225)
                {
                    thisPos.X -= 1;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 300)
                {
                    thisPos.Y -= 1;
                    game.EnemyPos.Y = thisPos.Y;

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
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);

            }
        }

        //public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        //{
        //    spriteBatch.Draw(AnimationType[7], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        //}

        //public void Draw(SpriteBatch spriteBatch, Texture2D animate, Vector2 pos)
        //{
        //    spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);

        //}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);

        }
    }
}