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
    public class Hand : Ienemy
    {
        public Vector2 thisPos;
        private int frames = 0;
        Rectangle[] hand;
        Rectangle source2;

        Dictionary<int, int[]> enemies;

        int[] value;
        int id;

        Texture2D sprite;

        public Hand(int enemyID, Texture2D enemiesSprite,Vector2 pos)
        {
            enemies = new Dictionary<int, int[]>();
            sprite = enemiesSprite;
            thisPos = pos;
            id = enemyID;
            value = new int[6];
            thisPos.Y -= 100;

            hand = new Rectangle[2];
            hand[0] = new Rectangle(270, 0, 22, 22);
            hand[1] = new Rectangle(270, 25, 22, 22);
            source2 = hand[0];
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                enemies = game.currentRoomsRoom.enemiesD;
                if (thisPos.X > 0)
                {
                    frames++;
                    if ((frames % 20 == 0) && source2 == hand[0])
                    {
                        source2 = hand[1];
                    }
                    else if ((frames % 20 == 0) && source2 == hand[1])
                    {
                        source2 = hand[0];
                    }

                    if (frames <= 75)
                    {
                        thisPos.Y -= 1;
                        game.EnemyPos.Y = thisPos.Y;

                    }
                    else if (frames <= 150)
                    {
                        thisPos.X -= 1;
                        game.EnemyPos.X = thisPos.X;
                    }

                    if (frames == 151)
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
                    value[0] = (int)thisPos.X;
                    value[1] = (int)thisPos.Y;
                    value[2] = 44;
                    value[3] = 44;
                    game.currentRoomsRoom.enemiesD.Remove(id);
                    game.currentRoomsRoom.enemiesD.Add(id, value);
                    game.collideB.Update(gameTime, game, game.currentRoomsRoom, id);
                    game.currentRoomsRoom.enemiesD.TryGetValue((int)id, out value);
                    thisPos.X = value[0];
                    thisPos.Y = value[1];
                }

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
            if (enemies.ContainsKey(id))
            {
                spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
            }

        }

    }
}
