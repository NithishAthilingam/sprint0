using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sprint0.Content;

namespace sprint0.Items
{
    internal class FlyingSwordRight : IShoot
    {
        private Vector2 thisPos;
        private Vector2 originalPos;
        private int frame;
        private Boolean draw;
        private Boolean drawExplode;
        Rectangle[] explode;


        public FlyingSwordRight(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            thisPos.Y -= 10;
            thisPos.X += 5;
            originalPos = arrowPos;
            frame = 0;
            draw = true;
            drawExplode = false;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(90, 220, 20, 25);
            explode[1] = new Rectangle(200, 270, 30, 30);
        }

        public void Update(GameTime gameTime)
        {
            frame++;
            //thisPos.X += 2;
            if (thisPos.X - 150 > originalPos.X)
            {
                drawExplode = true;
            }
            else
            {
                thisPos.X += 2;
            }
            if(frame > 82)
            {
                draw = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {
            if (draw)
            {
                if (!drawExplode)
                {
                    spriteBatch.Draw(animate[4], thisPos, explode[0], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
                else
                {
                    spriteBatch.Draw(animate[4], new Vector2(thisPos.X-15, thisPos.Y -25), explode[1], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
            }
        }
    }
}
