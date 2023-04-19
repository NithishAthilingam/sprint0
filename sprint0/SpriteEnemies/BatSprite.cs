using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;

namespace sprint0
{
    public class BatSprite
    {
        private Texture2D sprite;
        private Vector2 position;
        private Vector2 vel;
        private Random random;
        private Rectangle[] bat;
        private const double FRAME_DURATION = 0.1; // In seconds
        private int currentFrame;
        private double elapsedTime;


        public BatSprite(Texture2D spriteEnemies, Vector2 pos)
        {
            sprite = spriteEnemies;
            position = pos;
            random = new Random();
            vel = new Vector2(1, 1);
            bat = new Rectangle[2];
            bat[0] = new Rectangle(230, 270, 20, 20);
            bat[1] = new Rectangle(260, 270, 20, 20);

            currentFrame = 0;
            elapsedTime = 0;
        }

        public void Update(GameTime gameTime)
        {
            // Randomly choose a direction to move in
            //int direction = random.Next(-5, 6);

            // Move the bat in the chosen direction
            if(gameTime.TotalGameTime.TotalSeconds % 2 == 0)
            {
                vel = new Vector2(random.Next(-5, 6), random.Next(-5, 6));
            }
            position += vel;
            // Make sure the bat stays within the screen boundaries
            if (position.X < 0)
            {
                position.X = 0;
            }
            else if (position.X > 800)
            {
                position.X = 800;
            }
            if (position.Y < 0)
            {
                position.Y = 0;
            }
            else if (position.Y > 480)
            {
                position.Y = 480;
            }

            elapsedTime += gameTime.ElapsedGameTime.TotalSeconds;
            if(elapsedTime >= FRAME_DURATION)
            {
                currentFrame = (currentFrame + 1) % bat.Length;
                elapsedTime = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, bat[currentFrame], Color.White);
        }
        
    }
}
