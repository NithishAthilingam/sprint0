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
        private Rectangle des;

        public Health(int health)
		{
            thisHealth = health;
            hearts = new List<Rectangle>();
            fullHeart = new Rectangle(0, 190, 154, 137);
            halfHeart = new Rectangle(345, 190, 154, 137);
            des = new Rectangle(100, 100, 19, 17);
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

