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
    public class RSprite : Isprite
    {
        public RSprite()
        {
        }
#pragma warning disable CS0414 // The field 'RSprite.currentFrame' is assigned but its value is never used
        private int currentFrame = 0;
#pragma warning restore CS0414 // The field 'RSprite.currentFrame' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'RSprite.totalFrames' is assigned but its value is never used
        private int totalFrames = 45;
#pragma warning restore CS0414 // The field 'RSprite.totalFrames' is assigned but its value is never used
        private Vector2 location = new Vector2(220, 100);

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType)
        {
            spriteBatch.Draw(AnimationType[0], new Vector2(220, 100), Color.White);

        }

    }
}
