using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;


namespace sprint0
{
    public class RightSprite : Isprite
    {
        public Vector2 thisPos;
        private Vector2 location = new Vector2(220, 100);

        public RightSprite(Vector2 posi)
        {

            thisPos = posi;

        }


        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
                Rectangle source2 = new Rectangle(90, 0, 20, 20);
                Rectangle dest2 = new Rectangle(100, 100, 50, 50);
                spriteBatch.Draw(AnimationType[4], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

            }
        }
    }
      