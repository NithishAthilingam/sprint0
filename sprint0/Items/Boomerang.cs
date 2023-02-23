using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
    public class Boomerang : Isprite
    {
        Texture2D thisFire;
        Rectangle boomerang;
        Vector2 thisPos;
        char thisDirec;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;

        public Boomerang(Vector2 pos, char direc)
        {
            thisPos = pos;
            //thisFire = fireTex;
            thisDirec = direc;

            boomerang = new Rectangle(129, 3, 6, 12);

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 50;

            middle = 2;
            left = 0;
            right = 1;
        }

		public void Update(GameTime gameTime)
		{

        }
    

		public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
		{
            spriteBatch.Draw(animate[11], thisPos, boomerang, Color.White, 2.0f, new Vector2(18, 36), new Vector2(3, 3), 0, 0);
        }
	}
}

