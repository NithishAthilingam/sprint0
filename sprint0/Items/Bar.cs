using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
    public class Bar : IItem

    {
        Rectangle barS;
        Rectangle barD;
        Texture2D barDraw;
            
            public Bar(Texture2D arrowSprite, Vector2 pos)
            {
                barS = new Rectangle(268, 253, 30, 30);
                barD = new Rectangle((int)pos.X, (int)pos.Y, 75, 75);

                barDraw = arrowSprite;

            }

            public void Update(GameTime gameTime)
            {

            }


            public void Draw(SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(barDraw, barD, barS, Color.White);
            }

<<<<<<< HEAD
        public void Update(GameTime gameTime, Game1 game)
        {
=======
        void IItem.Update(GameTime gameTime, Game1 game)
        {
            throw new NotImplementedException();
>>>>>>> c5af5dddb38dd8d375f78ae240cb0a90b1401072
        }
    }
    }

	
