using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace sprint0
{
    public class ThrowingItemDown : Isprite
    {
        public Vector2 thisPos;

        public ThrowingItemDown(Vector2 posi)
        {
            thisPos = posi;
        }

        private int currentFrame = 0;
        private int totalFrames = 45;
        private Vector2 location = new Vector2(220, 100);




        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source2 = new Rectangle(0, 60, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], pos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
    }
}