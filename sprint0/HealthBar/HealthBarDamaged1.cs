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
	public class HealthbarDamaged1 : IHealthBar
	{

		public HealthbarDamaged1()
		{
 

		}

		public void Draw(SpriteBatch spriteBatch, Texture2D bar)
		{
            Rectangle source2 = new Rectangle(252, 50, 192, 50);
            Rectangle dest2 = new Rectangle(30, 40, 192, 50);
            spriteBatch.Draw(bar, dest2, source2, Color.White);

		}
    }
}

