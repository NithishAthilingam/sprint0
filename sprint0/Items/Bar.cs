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

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(barDraw, barD, barS, Color.White);
        }

        public void Update(GameTime gameTime, Game1 game)
        {
        
            }
        }
    }
