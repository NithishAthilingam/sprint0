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
    
    public class MotionSprite : Isprite
    {
        bool up = true;
        double ver = 0;
        double loc = 0;
        public MotionSprite()
        {

        }

        private Vector2 location = new Vector2(220, 100);

        //wrap around
        public void Update()
        {
            
            ver = 400*Math.Cos(location.Y);
            if (location.Y >= 400)
            {
                location.Y -= 2;
                up = true;
            }
            else if (location.Y <= 000)
            {
                location.Y += 2;
                up = false;
            }
            else if (up == true)
            {
                location.Y -= 2;
            }
            else if(up == false)
            {
                location.Y += 2;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType)
        {
            spriteBatch.Draw(AnimationType[0], location, Color.White);
        }
    }
}
