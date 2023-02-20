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
	public class MovingDownSprite : Isprite
    {
        public Vector2 thisPos;
        private int currentFrame = 0;

        public MovingDownSprite(Vector2 posi)
        {
            thisPos = posi;
        }

        public void Update(GameTime gameTime, int characterFrame)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source3 = new Rectangle(0, 40, 20, 20);
            Rectangle dest3 = new Rectangle(100, 100, 50, 50);
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            Rectangle dest1 = new Rectangle(100, 100, 50, 50);

            if (currentFrame % 5 == 0)
            {
                spriteBatch.Draw(AnimationType[4], pos, source1, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
            else
            {
                spriteBatch.Draw(AnimationType[4], pos, source3, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
            }
            currentFrame++;
            

        }
    }
}

