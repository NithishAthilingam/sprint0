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
    public class BlueBlob : Ienemy
    {
        public Vector2 thisPos;
        private int frames = 0;
        Rectangle[] blob;
        Rectangle source2;


        public BlueBlob(Vector2 pos)
        {
            thisPos = pos;

            thisPos.Y -= 100;

            blob = new Rectangle[2];
            blob[0] = new Rectangle(404, 184, 10, 10);
            blob[1] = new Rectangle(404, 213, 10, 10);
            source2 = blob[0];
        }

        public void Update(GameTime gameTime, Game1 game)
        {

            if (thisPos.X > 0)
            {
                frames++;
                if((frames%20 == 0) && source2 == blob[0])
                {
                    source2 = blob[1];
                }
                else if ((frames % 20 == 0) && source2 == blob[1])
                {
                    source2 = blob[0];
                }

                if (frames <= 75)
                {
                    thisPos.X += 1;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 150) {
                    thisPos.Y += 1;
                    game.EnemyPos.Y = thisPos.Y;

                }
                else if (frames <= 225)
                {
                    thisPos.X -= 1;
                    game.EnemyPos.X = thisPos.X;

                }
                else if (frames <= 300)
                {
                    thisPos.Y -= 1;
                    game.EnemyPos.Y = thisPos.Y;

                }

                if (frames == 301)
                {
                    frames = 0;
                }
            }
            else
            {
                thisPos.X = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            spriteBatch.Draw(AnimationType[7], thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);
        }
    }
}
