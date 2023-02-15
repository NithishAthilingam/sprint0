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
        public bool fd;
        public bool fu;
        public bool fr;
        public bool fl;
        public RSprite(Vector2 posi, bool facingDown, bool facingUp, bool facingRight, bool facingLeft)
        {
            thisPos = posi;
            fd = facingDown;
            fu = facingUp;
            fr = facingRight;
            fl = facingLeft;
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
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            pos = thisPos;
            if (fd)
            {
                source1 = new Rectangle(0, 0, 20, 20);
            }
            else if (fu)
            {
                source1 = new Rectangle(60, 30, 20, 20);
            }
            else if (fr)
            {
                source1 = new Rectangle(90, 30, 20, 20);
            }
            else if (fl)
            {
                source1 = new Rectangle(30, 0, 20, 20);
            }
            else
            {
                source1 = new Rectangle(0, 0, 20, 20);
            }
            

            spriteBatch.Draw(AnimationType[4],pos, source1, Color.White,0,new Vector2(0,0),new Vector2(3,3),0,0);


        }

    }
}
