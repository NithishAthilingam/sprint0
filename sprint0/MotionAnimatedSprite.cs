using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
#pragma warning disable CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace
using Microsoft.Xna.Framework.Graphics;
#pragma warning restore CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace

namespace sprint0
{
    public class MotionAnimatedSprite : Isprite
    {
        public MotionAnimatedSprite()
        {
        }

        private Texture2D charcater;
        private int currentFrame = 0;
        private int totalFrames = 45;
        private Vector2 location = new Vector2(220, 100);

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

            if (location.X <= 0)
            {
                location.X = 800;
            }
            else
            {
                location.X -= 5;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            if (currentFrame == 0)
            {
                charcater = AnimationType[1];
            }
            else if (currentFrame == 10)
            {
                charcater = AnimationType[2];
            }
            else if (currentFrame == 20)
            {
                charcater = AnimationType[3];
            }
            spriteBatch.Draw(charcater, location, Color.White);

        }
    }
}
