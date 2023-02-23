using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
    public class Bomb : Isprite
    {
        Rectangle bomb;
        Rectangle explosion;
        Vector2 thisPos;
        char thisDirec;
        int frame;
        bool drawExplode;
        bool stopDraw;

        public Bomb(Vector2 pos, char direc)
        {
            thisPos = pos;
            thisPos.Y += 10;
            frame = 0;
            stopDraw = false;
            drawExplode = false;
            //thisFire = fireTex;
            thisDirec = direc;
            explosion = new Rectangle(100, 0, 30, 30);
            bomb = new Rectangle(360, 230, 30, 20);
            

            
        }

        public void Update(GameTime gameTime)
        {
            frame++;

            if (frame < 50)
            {

                if (thisDirec == 's')
                {
                    thisPos.Y += 3;
                }
                else if (thisDirec == 'a')
                {
                    thisPos.X -= 3;
                }
                else if (thisDirec == 'w')
                {
                    thisPos.Y -= 3;
                }
                else if (thisDirec == 'd')
                {
                    thisPos.X += 3;
                }
            }
            if (frame > 90)
            {
                drawExplode = true;
            }
            if(frame > 95)
            {
                stopDraw = true;
            }
                

        }


        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {
            if(!drawExplode)
            {
                spriteBatch.Draw(animate[4], thisPos, bomb, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
            else
            {
                if(!stopDraw)
                {
                    spriteBatch.Draw(animate[10], new Vector2(thisPos.X-25,thisPos.Y-25), explosion, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
            }
        }
    }
}

