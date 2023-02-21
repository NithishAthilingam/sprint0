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
    internal class BlueArrowLeft : IShoot
    {
        private Vector2 thisPos;
        private Vector2 originalPos;
        Rectangle arrow;
        Rectangle smoke;
        Rectangle[] explode;
        private int current;

        public BlueArrowLeft(Vector2 arrowPos)
        {
            thisPos = arrowPos;
            originalPos = arrowPos;
            current = 0;
            explode = new Rectangle[2];
            explode[0] = new Rectangle(140, 250, 30, 20);
            explode[1] = new Rectangle(200, 270, 30, 30);
        }

        public void Update(GameTime gameTime)
        {
            thisPos.X -= 2;
            if (originalPos.X - thisPos.X>150)
            {
                current = 1;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {
            spriteBatch.Draw(animate[4], thisPos, explode[current], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
    }
}
