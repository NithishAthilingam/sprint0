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
    public class AnimatedSprite : Isprite
    {
        public AnimatedSprite()
        {
        }

        private Texture2D character;
        private int currentFrame = 0;
        private int totalFrames = 45;

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType)
        {
            if (currentFrame == 0)
            {
                character = AnimationType[1];
            }
            else if (currentFrame == 10)
            {
                character = AnimationType[2];
            }
            else if (currentFrame == 20)
            {
                character = AnimationType[3];
            }
            spriteBatch.Draw(character, new Vector2(220, 100), Color.White);

        }
    }
}
