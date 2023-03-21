using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.HealthBar
{
	public class Health : IHealthBar
	{
        private int thisHealth;
        private List<Rectangle> hearts;
        private Rectangle fullHeart;
        private Rectangle halfHeart;
        private Rectangle emptyHeart;
        private Rectangle des;

        public Health(int health)
		{
            thisHealth = health;
            hearts = new List<Rectangle>();
            fullHeart = new Rectangle(36, 16, 98, 98);
            halfHeart = new Rectangle(146, 16, 98, 98);
            emptyHeart = new Rectangle(256, 16, 98, 98);
            des = new Rectangle(100, 100, 19, 19);
            hearts.Add(fullHeart);
            hearts.Add(fullHeart);
            hearts.Add(fullHeart);
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D bar)
        {

            if(thisHealth == 3)
            {
                foreach(Rectangle heart in hearts)
                {
                    spriteBatch.Draw(bar, des, heart, Color.White);
                }
            }
            
        }
    }
}

