using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;

namespace sprint0
{
	public class DragonSprite1 : Ienemy
	{
        public Vector2 thisPos;

        private int frames = 0;
     
        public DragonSprite1(Vector2 pos)
        {
            thisPos = pos;
            thisPos.X += 150;

        }

        public void Update(GameTime gameTime)
        {
            if (thisPos.X > 0)
            {
                frames++;
                if (frames <= 160)
                {
                    thisPos.X+=1;

                }
                else if (frames <= 320)
                {
                    thisPos.X-= 1;
                }

                if (frames == 321)
                {
                    frames = 0;
                }
            }

            else { 
                thisPos.X = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            Rectangle source2 = new Rectangle(0, 0, 30, 35);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[6], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
    }
}

