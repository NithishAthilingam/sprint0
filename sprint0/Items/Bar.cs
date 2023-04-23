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
<<<<<<< HEAD
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

        public void Update(GameTime gameTime, Game1 game)
        {
        
            }
        }
    }
    
=======
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

        void IItem.Update(GameTime gameTime, Game1 game)
        {
            throw new NotImplementedException();
        }
    }
}
>>>>>>> 3931131652d4569495fe3687d1958483e465128b

	
