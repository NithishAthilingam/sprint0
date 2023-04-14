using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0;


namespace sprint0
{

    public class Blocks : IBlock
    {
        Rectangle[] recs;

        int currentImageIndex;
        private Texture2D b;
        private Texture2D d;

        float delayTime;
        float timer;
        Rectangle des;

        public Blocks(Texture2D blocks, Texture2D dungeon)
        {
            currentImageIndex = 0;
            b = blocks;
            d = dungeon;

            recs = new Rectangle[13];

            delayTime = 500f;
            timer = 0f;

            recs[0] = new Rectangle(24, 31, 123, 123);
            recs[1] = new Rectangle(160, 5, 160, 160);
            recs[2] = new Rectangle(339, 0, 160, 160);
            recs[3] = new Rectangle(480, 0, 160, 160);
            recs[4] = new Rectangle(0, 173, 130, 152);
            recs[5] = new Rectangle(169, 172, 149, 149);
            recs[6] = new Rectangle(330, 179, 146, 146);
            recs[7] = new Rectangle(496, 173, 143, 147);

            des = new Rectangle(100, 400, 50, 50);
        }

        public void Update(GameTime gameTime)
        {
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer <= 0f)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Y))
                {
                    currentImageIndex++;
                    if (currentImageIndex >= recs.Length)
                    {
                        currentImageIndex = recs.Length - 1;
                    }
                    timer = delayTime;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.T))
                {
                    currentImageIndex--;
                    if (currentImageIndex < 0)
                    {
                        currentImageIndex = 0;
                    }
                    timer = delayTime;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(b, new Rectangle((int)position.X, (int)position.Y, 50, 50), recs[currentImageIndex], Color.White);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate)
        {
        }
    }
}
