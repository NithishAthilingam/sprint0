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
    internal class GreenArrowLeft : IShoot
    {
        private Vector2 thisPos;
        private Vector2 originalPos;
        private int frame;
        private Boolean draw;
        private Boolean drawExplode;
        Rectangle[] explode;

        public GreenArrowLeft(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            thisPos.Y -= 10;
            thisPos.X += 5;
            originalPos = arrowPos;
            frame = 0;
            draw = true;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(140, 190, 30, 20);
            explode[1] = new Rectangle(118, 282, 18, 21);
        }

        public void Update(GameTime gameTime)
        {
            frame++;
            /*thisPos.X += 2;*/
            if (originalPos.X - thisPos.X > 250)
            {
                drawExplode = true;
            }
            else
            {
                thisPos.X -= 2;
            }
            if (frame > 135)
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
                    spriteBatch.Draw(animate[4], new Vector2(thisPos.X-60,thisPos.Y), explode[0], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
                else
                {
                    spriteBatch.Draw(animate[4], new Vector2(thisPos.X - 25, thisPos.Y + 10), explode[1], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
            }
        }
    }
}
