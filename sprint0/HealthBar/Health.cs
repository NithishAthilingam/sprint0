using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.HealthBar
{
	public class Health : IHealthBar
	{
        private int thisHealth;
        private Rectangle fullHeart;
        private Rectangle halfHeart;
        private Rectangle emptyHeart;
        private Rectangle firstDes;
        private Rectangle middleDes;
        private Rectangle lastDes;

        public Health(int health)
		{
            thisHealth = health;
            fullHeart = new Rectangle(36, 16, 98, 98);
            halfHeart = new Rectangle(146, 16, 98, 98);
            emptyHeart = new Rectangle(256, 16, 98, 98);
            firstDes = new Rectangle(722, 3, 19, 19);
            middleDes = new Rectangle(744, 3, 19, 19);
            lastDes = new Rectangle(766, 3, 19, 19);
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D bar)
        {

            if(thisHealth == 6)
            {
                spriteBatch.Draw(bar, firstDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, fullHeart, Color.White);
            }
            else if(thisHealth == 5)
            {
                spriteBatch.Draw(bar, firstDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, halfHeart, Color.White);
            }
            else if (thisHealth == 4)
            {
                spriteBatch.Draw(bar, firstDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, emptyHeart, Color.White);
            }
            else if (thisHealth == 3)
            {
                spriteBatch.Draw(bar, firstDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, halfHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, emptyHeart, Color.White);
            }
            else if (thisHealth == 2)
            {
                spriteBatch.Draw(bar, firstDes, fullHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, emptyHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, emptyHeart, Color.White);
            }
            else if (thisHealth == 1)
            {
                spriteBatch.Draw(bar, firstDes, halfHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, emptyHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, emptyHeart, Color.White);
            }
            else if (thisHealth == 0)
            {
                spriteBatch.Draw(bar, firstDes, emptyHeart, Color.White);
                spriteBatch.Draw(bar, middleDes, emptyHeart, Color.White);
                spriteBatch.Draw(bar, lastDes, emptyHeart, Color.White);
            }
        }
    }
}

