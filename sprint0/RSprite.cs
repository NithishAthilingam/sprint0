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
        public Vector2 thisPos;
        public RSprite(Vector2 posi)
        {
            thisPos = posi;
        }
#pragma warning disable CS0414 // The field 'RSprite.currentFrame' is assigned but its value is never used
        int currentFrame = 0;
#pragma warning restore CS0414 // The field 'RSprite.currentFrame' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'RSprite.totalFrames' is assigned but its value is never used
        private int totalFrames = 45;
#pragma warning restore CS0414 // The field 'RSprite.totalFrames' is assigned but its value is never used
        private Vector2 location = new Vector2(220, 100);

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            Rectangle dest1 = new Rectangle(100, 100, 50, 50);

            spriteBatch.Draw(AnimationType[4],pos, source1, Color.White,0,new Vector2(0,0),new Vector2(3,3),0,0);


        }

    }
}
