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
	public class DragonSprite1 : Ienemy
	{
        public Vector2 thisPos;

        private int frames = 0;
        private int framesBall = 0;
        Rectangle[] dragonProjectile;
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



        public DragonSprite1(Vector2 pos)
        {
            thisPos = pos;

            posBallTop.X = thisPos.X;
            posBallTop.Y = thisPos.Y -50;

            posBallMid.X = thisPos.X;
            posBallMid.Y = thisPos.Y;

            posBallBtm.X = thisPos.X;
            posBallBtm.Y = thisPos.Y + 50;
           

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

        public void Update(GameTime gameTime)
        {
                framesBall++;
                if (frames <= 1000)
                {
                    posBallTop.X -=1;
                    posBallTop.Y -= 1;
                    posBallMid.X -= 1;
                    posBallBtm.X -= 1;
                    posBallBtm.Y += 1;

                }




            if (thisPos.X > 0)
            {
                frames++;
                if (frames <= 160)
                {
                    thisPos.X += 1;

                }
                else if (frames <= 320)
                {
                    thisPos.X -= 1;
                }

                if (frames == 321)
                {
                    frames = 0;
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


        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            Rectangle source2 = new Rectangle(0, 0, 30, 35);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);

            if (frames == 0)
            {
                spriteBatch.Draw(AnimationType[7], posBallTop, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                spriteBatch.Draw(AnimationType[7], posBallMid, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                spriteBatch.Draw(AnimationType[7], posBallBtm, dragonProjectile[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
          
            spriteBatch.Draw(AnimationType[6], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
    }
}

