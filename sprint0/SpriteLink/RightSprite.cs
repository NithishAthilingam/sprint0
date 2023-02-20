using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace sprint0
{
    public class RightSprite : Isprite
    {
        public Vector2 thisPos;
        public Rectangle[] run;
        private int frames = 0;

        private Texture2D z;
        private Texture2D f;
        float delayTime;
        float timer;
        Rectangle des;

        int currentA;

        public RightSprite(Vector2 posi)
        {

            thisPos = posi;


            currentA = 0;

            run = new Rectangle[2];

            run[0] = new Rectangle(90, 0, 20, 20);
            run[1] = new Rectangle(90, 30, 30, 30);

        }

        private int currentFrame = 0;
        private int totalFrames = 30;
        private Rectangle character;
        private Vector2 location = new Vector2(220, 100);




        public void Update(GameTime gameTime)
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            if (currentFrame == 0)
            {
                character = run[0];
            }
            else if (currentFrame == 15)
            {
                character = run[1];
            }
            Rectangle source2 = new Rectangle(90, 0, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], pos, character, Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
    }
    
}

      