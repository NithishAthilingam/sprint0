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
    public class BatSprite1 : Ienemy
    {
        public Vector2 thisPos;
        Vector3 value;
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


        public BatSprite1(int enemyID, Texture2D enemiesSprite,Vector2 pos)
        {
            sprite = enemiesSprite;
            thisPos = pos;
            id = enemyID;

            thisPos.Y -= 100;
            value.X = pos.X;
            value.Y = pos.Y;



            bat = new Rectangle[2];
            bat[0] = new Rectangle(230, 270, 20, 20);
            bat[1] = new Rectangle(260, 270, 20, 20);
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

        }

        public void Update(GameTime gameTime, Game1 game)
        {
            if (thisPos.Y == 60)
            {
                posChangeY = 2;
            }else if(thisPos.Y == 372)
            {
                posChangeY = -2;
            }else if(thisPos.X == 90)
            {
                posChangeX = 2;
            }else if(thisPos.X == 665)
            {
                posChangeX = -2;
            }


            /*if (thisPos.X > 0 && thisPos.Y>0)
            {*/
                frames++;
                if ((frames % 20 == 0) && source2 == bat[0])
                {
                    source2 = bat[1];
                }
                else if ((frames % 20 == 0) && source2 == bat[1])
                {
                    source2 = bat[0];
                }
                thisPos.X += posChangeX;
                thisPos.Y += posChangeY;
                /*if (frames <= 75)
                {
                    thisPos.X += posChangeX;
                    thisPos.Y += posChangeY;
                    game.EnemyPos.X = thisPos.X;
                    game.EnemyPos.Y = thisPos.Y;

                }
                else if (frames <= 150)
                {
                    thisPos.Y += posChangeY;
                    game.EnemyPos.Y = thisPos.Y ;

                }
                else if (frames <= 225)
                {
                    thisPos.X += posChangeX;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 300)
                {
                    thisPos.Y += posChangeY;
                    game.EnemyPos.Y = thisPos.Y;

                }*/

                if (frames == 301)
                {
                    frames = 0;
                }
            //}
            /*else
            {
                thisPos.X += posChangeX;
                thisPos.Y += posChangeY;
                game.EnemyPos.X = thisPos.X;
                game.EnemyPos.Y = thisPos.Y;

            }*/
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
            if(game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                game.currentRoomsRoom.enemiesD.TryGetValue(id, out value);
                value.X = thisPos.X;
                value.Y = thisPos.Y;
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        }
    }
}
