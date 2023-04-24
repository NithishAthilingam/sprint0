﻿using Microsoft.Xna.Framework.Graphics;
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
    public class DragonSprite1 : Ienemy
    {
        public Vector2 thisPos;
        Rectangle source2;

        Vector4 value;
        int id;

        private int frames = 0;
        Rectangle[] dragonProjectile;
        Rectangle[] drago;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;
        Vector2 posBallTop;
        Vector2 posBallMid;
        Vector2 posBallBtm;

        Texture2D sprite;
        Texture2D sprite2;
        private Vector2 enemyPos;

        public DragonSprite1(int enemyID, Texture2D enemiesSprite, Texture2D enemiesSprite2, Vector2 pos)
        {
            sprite = enemiesSprite;
            sprite2 = enemiesSprite2;
            thisPos = pos;

            id = enemyID;

            posBallTop = thisPos;
            posBallMid = thisPos;
            posBallBtm = thisPos;

            drago = new Rectangle[4];
            drago[0] = new Rectangle(0, 0, 30, 35);
            drago[1] = new Rectangle(45, 0, 30, 35);
            drago[2] = new Rectangle(90, 0, 30, 35);
            drago[3] = new Rectangle(135, 0, 30, 35);
            source2 = drago[0];

            dragonProjectile = new Rectangle[3];
            dragonProjectile[0] = new Rectangle(330, 0, 20, 20);
            dragonProjectile[1] = new Rectangle(360, 0, 20, 20);
            dragonProjectile[2] = new Rectangle(360, 30, 20, 20);
            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 200;

            middle = 2;
            left = 0;
            right = 1;

        }

        public DragonSprite1(Vector2 enemyPos)
        {
            this.enemyPos = enemyPos;
        }

        public void Update(GameTime gameTime, Game1 game)
        {

            posBallTop.X -= 3;
            posBallTop.Y -= 1;
            posBallMid.X -= 3;
            posBallBtm.X -= 3;
            posBallBtm.Y += 1;



            if (thisPos.X > 0)
            {
                frames++;
                if ((frames % 20 == 0) && (source2 == drago[0] || source2 == drago[3]))
                {
                    source2 = drago[1];
                }
                else if ((frames % 20 == 0) && (source2 == drago[1] || source2 == drago[2]))
                {
                    source2 = drago[0];
                }
                if (frames <= 160)
                {
                    thisPos.X += 1;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 320)
                {
                    thisPos.X -= 1;
                    game.EnemyPos.X = thisPos.X;


                }

                if (frames == 321)
                {
                    frames = 0;
                    posBallTop = thisPos;
                    posBallMid = thisPos;
                    posBallBtm = thisPos;
                    if (source2 == drago[0])
                    {
                        source2 = drago[3];
                    }
                    else
                    {
                        source2 = drago[2];
                    }
                }
            }

            else
            {
                thisPos.X = 0;
            }

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

            if (game.currentRoomsRoom.enemiesD.ContainsKey(id))
            {
                game.currentRoomsRoom.enemiesD.TryGetValue(id, out value);
                value.X = thisPos.X;
                value.Y = thisPos.Y;
                value.Z = 90;
                value.W = 100;
                game.currentRoomsRoom.enemiesD.Remove(id);
                game.currentRoomsRoom.enemiesD.Add(id, value);

            }


        }

        //public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType)
        //{
        //    Rectangle dest2 = new Rectangle(100, 100, 50, 50);

        //    spriteBatch.Draw(AnimationType[7], posBallTop, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //    spriteBatch.Draw(AnimationType[7], posBallMid, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //    spriteBatch.Draw(AnimationType[7], posBallBtm, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);


        //    spriteBatch.Draw(AnimationType[6], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //}

        //public void Draw(SpriteBatch spriteBatch, Texture2D animate)
        //{
        //    spriteBatch.Draw(sprite, posBallTop, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //    spriteBatch.Draw(sprite, posBallMid, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //    spriteBatch.Draw(sprite, posBallBtm, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        //    spriteBatch.Draw(sprite2, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        //}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, posBallTop, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            spriteBatch.Draw(sprite, posBallMid, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            spriteBatch.Draw(sprite, posBallBtm, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

            spriteBatch.Draw(sprite2, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
 
    }
    }
}

