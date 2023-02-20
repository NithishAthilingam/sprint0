using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;


namespace sprint0
{
    public class RightSprite : Isprite
    {
        public Vector2 thisPos;
        public Rectangle[] run;
        private int totalFrames = 30;
        private int cF;
        private Rectangle character;
        private Vector2 location = new Vector2(220, 100);

        public RightSprite(Vector2 posi)
        {

            thisPos = posi;

            run = new Rectangle[2];

            run[0] = new Rectangle(90, 0, 20, 20);
            run[1] = new Rectangle(90, 30, 30, 30);

        }


        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            if (cF <= 30)
            {
                character = run[0];
            }
            else if (cF <= 60)
            {
                character = run[1];
            }
            Rectangle source2 = new Rectangle(90, 0, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], pos, character, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
    }
    
}

      