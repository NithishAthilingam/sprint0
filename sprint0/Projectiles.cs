using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
	public class Projectiles : IItem

    {
        private Game1 game1;
        private Texture2D i;
        Rectangle blueArrow;
        Rectangle greenArrow;
        Rectangle smoke;

        Rectangle des;
        Rectangle des1;

        Vector2 p;
        private float s;
        private bool arrow;

        float delayTime;
        float timer;


        public Projectiles(Game1 myGame,Texture2D items, Vector2 position)
		{
			i = items;
            game1 = myGame;

            blueArrow = new Rectangle(0, 120, 20, 15);
            greenArrow = new Rectangle(0, 40, 20, 15);

            smoke = new Rectangle(314, 40, 20, 15);

            s = 2.0f;

            p = position;

            des = new Rectangle(296, 136, 55, 40);
            des1 = new Rectangle(296, 117, 55, 40);

            delayTime = 500f;
            timer = 0f;



        }


        public void Update(GameTime gameTime)
        {

            p.X += s;
                if (p.X > game1.GraphicsDevice.Viewport.Width / 2)
                {

                    //p.X = game1.GraphicsDevice.Viewport.Width / 4;

                    p.Y = game1.GraphicsDevice.Viewport.Height / 4;
            }


        }



        public void Draw(SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(i, p, blueArrow, Color.White);


            if (p.Y == game1.GraphicsDevice.Viewport.Height / 4)
            {
                spriteBatch.Draw(i, new Vector2(game1.GraphicsDevice.Viewport.Width / 2, game1.GraphicsDevice.Viewport.Height / 4), smoke, Color.White);
            }
            spriteBatch.Draw(i,p, blueArrow, Color.White);

        }


    }
    }

