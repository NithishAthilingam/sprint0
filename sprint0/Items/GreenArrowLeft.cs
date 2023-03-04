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
        Rectangle[] explode;
        private int current;

        public GreenArrowLeft(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            thisPos.Y -= 10;
            thisPos.X -= 55;
            originalPos = arrowPos;
            current = 0;
            frame = 0;
            draw = true;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(140, 190, 30, 20);
            explode[1] = new Rectangle(118, 282, 18, 18);
            //136, 302
        }

        public void Update(GameTime gameTime)
        {
            frame++;
            /*thisPos.X -= 2;*/
            if (originalPos.X - thisPos.X > 250)
            {
                current = 1;
            }
            else
            {
                thisPos.X -= 2;
            }
            if (frame > 110)
            {
                draw = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {
            if (draw)
            {
                spriteBatch.Draw(animate[4], thisPos, explode[current], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
        }
    }
}
