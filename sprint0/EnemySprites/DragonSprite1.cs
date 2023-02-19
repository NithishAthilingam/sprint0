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
	public class DragonSprite1 : Ienemy
	{
        public Vector2 thisPos;

        public DragonSprite1(Vector2 pos)
		{

        }

        public void Update(GameTime gameTime)
        {


        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source2 = new Rectangle(0, 0, 30, 35);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[6], pos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);
        }
    }
}

