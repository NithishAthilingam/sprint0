using System;
using System.Reflection;
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
<<<<<<< HEAD
        Rectangle des1;

        Vector2 p;
        private float s;
        private bool arrow;

        float delayTime;
        float timer;

=======
        Rectangle[] fire;
        Vector2 p;
        int currentA;
        int previousA;
        float speed;
        float tt;
        float timer;
        private int middle;
        private int left;
        private int right;
        int currentImageIndex;
        private Texture2D f;
>>>>>>> 6730054a71b21bd65df47834d86d67af7950d157


        public Projectiles(Game1 myGame,Texture2D items, Texture2D fires, Vector2 position)
		{
			i = items;
            f = fires;
            game1 = myGame;

            timer = 0f;

            previousA = 1;
            currentA = 2;
            tt = 0;
            speed = 10;

            middle = 2;
            left = 0;
            right = 1;

            blueArrow = new Rectangle(0, 120, 20, 15);
            greenArrow = new Rectangle(0, 40, 20, 15);

<<<<<<< HEAD
            smoke = new Rectangle(0, 40, 20, 15);

            s = 2.0f;
=======
            fire = new Rectangle[3];

            fire[0] = new Rectangle(290, 0, 30, 30);
            fire[1] = new Rectangle(290, 30, 30, 30);
            fire[2] = new Rectangle(290, 0, 30, 30);
>>>>>>> 6730054a71b21bd65df47834d86d67af7950d157

            p = position;

            des = new Rectangle(296, 136, 55, 40);
            des1 = new Rectangle(296, 136, 55, 40);

            delayTime = 500f;
            timer = 0f;



        }


        public void Update(GameTime gameTime)
        {

            p.X += s;
            if (p.X > 0)
            {
                if (p.X > game1.GraphicsDevice.Viewport.Width / 2)
                {

                    //p.X = game1.GraphicsDevice.Viewport.Width / 4;

                    p.Y = game1.GraphicsDevice.Viewport.Height / 4;
<<<<<<< HEAD

                }
            }
=======
            }

            if (tt > speed)
            {
                if (currentA == middle)
                {
                    if (previousA == left)
                    {
                        currentA = right;
                    }
                    else
                    {
                        currentA = left;
                    }
                    previousA = currentA;
                }
                else
                {
                    currentA = middle;
                }
                tt = 0;
            }
            else
            {
                tt += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }
        
>>>>>>> 6730054a71b21bd65df47834d86d67af7950d157


            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer <= 0f)
            {
                arrow = true;

                timer = delayTime;
               
            }

        }

    


    public void Draw(SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(i, p, blueArrow, Color.White);
<<<<<<< HEAD


            if (arrow == true)
            {
                spriteBatch.Draw(i, new Vector2(game1.GraphicsDevice.Viewport.Width / 2, game1.GraphicsDevice.Viewport.Height / 4), smoke, Color.White);

            }

=======
            spriteBatch.Draw(f, des, fire[currentA], Color.White);
>>>>>>> 6730054a71b21bd65df47834d86d67af7950d157
        }

 
    }
    }

