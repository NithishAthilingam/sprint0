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
        Rectangle[] explode;
        private int current;

        public GreenArrowUp(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            thisPos.Y -= 40;
            originalPos = arrowPos;
            current = 0;
            frame = 0;
            draw = true;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(180, 190, 20, 20);
            explode[1] = new Rectangle(200, 270, 30, 30);
        }

        public void Update(GameTime gameTime)
        {
            frame++;
            thisPos.Y -= 2;
            if (originalPos.Y - thisPos.Y > 250)
            {
                current = 1;
            }
            if (frame > 120)
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
