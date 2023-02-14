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
	public class FullHealthbar : IHealthBar
	{
        public int press;
		public FullHealthbar(int pressed)
		{
            press = pressed;
		}

		public void Draw(SpriteBatch spriteBatch, Texture2D bar)
		{
            Rectangle source2 = new Rectangle(30, 50, 192, 50);
            Rectangle dest2 = new Rectangle(30, 40, 192, 50);
            if (press == 0)
            {
                source2 = new Rectangle(30, 50, 192, 50);
            }
            else if (press == 1)
            {
                source2 = new Rectangle(252, 50, 192, 50);
            }
            else if (press == 2)
            {
                source2 = new Rectangle(252, 150, 192, 50);
            }
            else
            {
                source2 = new Rectangle(252, 260, 192, 50);
            }
            spriteBatch.Draw(bar, dest2, source2, Color.White);
        }
    }
}

