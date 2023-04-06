using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;

namespace sprint0
{
	public class LadyItem : IItem
    {


        Rectangle lady;
        private Vector2 thisPos;

        public LadyItem(Vector2 pos)
        {
            lady = new Rectangle(150, 30, 24, 25);
            thisPos = pos;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
            spriteBatch.Draw(animate[9], thisPos, lady, Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}

