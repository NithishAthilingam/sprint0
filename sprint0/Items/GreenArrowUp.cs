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
    internal class GreenArrowUp : IShoot
    {
        private Vector2 thisPos;
        private Vector2 originalPos;
        private int frame;
        private Boolean draw;
        private Boolean drawExplode;
        Rectangle[] explode;
        

        public GreenArrowUp(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            thisPos.Y -= 40;
            originalPos = arrowPos;
            frame = 0;
            draw = true;
            drawExplode = false;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(180, 190, 20, 20);
            explode[1] = new Rectangle(118, 282, 18, 21);
        }

        public void Update(GameTime gameTime)
        {
            frame++;
            /*thisPos.Y -= 2;*/
            if (originalPos.Y - thisPos.Y > 250)
            {
                drawExplode = true;
            }
            else
            {
                thisPos.Y -= 2;
            }
            if (frame > 120)
            {
                draw = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {
            if(draw)
            {
                if (!drawExplode)
                {
                    spriteBatch.Draw(animate[4], thisPos, explode[0], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
                else
                {
                    spriteBatch.Draw(animate[4], new Vector2(thisPos.X-5 , thisPos.Y ), explode[1], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
                }
            }
        }
    }
}
