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
    public class Hand : Ienemy
    {
        public Vector2 thisPos;
        private int frames = 0;
        Rectangle[] hand;
        Rectangle source2;

        Texture2D sprite;

        public Hand(Texture2D enemiesSprite,Vector2 pos)
        {

            sprite = enemiesSprite;
            thisPos = pos;

            thisPos.Y -= 100;

            hand = new Rectangle[2];
            hand[0] = new Rectangle(270, 0, 22, 22);
            hand[1] = new Rectangle(270, 25, 22, 22);
            source2 = hand[0];
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            if (thisPos.X > 0)
            {
                frames++;
                if((frames%20 == 0) && source2 == hand[0])
                {
                    source2 = hand[1];
                }
                else if ((frames % 20 == 0) && source2 == hand[1])
                {
                    source2 = hand[0];
                }

                if (frames <= 75)
                {
                    thisPos.Y -= 1;
                    game.EnemyPos.Y = thisPos.Y;

                }
                else if (frames <= 150) {
                    thisPos.X -= 1;
                    game.EnemyPos.X = thisPos.X;
                }

                if (frames == 151)
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

        public void Draw(SpriteBatch spriteBatch, Texture2D animate, Vector2 pos)
        {
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, thisPos, source2, Color.White, 0, new Vector2(0, 0), new Vector2(2, 2), 0, 0);

        }

    }
}
