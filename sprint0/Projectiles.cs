using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Content;

namespace sprint0
{
    public class Projectiles : Content.IShoot

    {
        private Game1 game1;
        private Texture2D i;
        Rectangle blueArrow;
        Rectangle greenArrow;
        Rectangle smoke;

        Rectangle des;
        Rectangle des1;

        private float s;
        Vector2 position;
        public bool facingDown;
        public bool facingUp;
        public bool facingRight;
        public bool facingLeft;

        private bool up;
        private bool side;

        public Projectiles(Game1 myGame, Texture2D items, Vector2 pos, bool facingDown, bool facingUp, bool facingRight, bool facingLeft)
        {
            i = items;
            game1 = myGame;
            this.facingDown = facingDown;
            this.facingUp = facingUp;
            this.facingRight = facingRight;
            this.facingLeft = facingLeft;

            this.position = pos;

            blueArrow = new Rectangle(0, 120, 20, 15);
            greenArrow = new Rectangle(0, 40, 20, 15);

            smoke = new Rectangle(314, 40, 20, 15);

            s = 2.0f;


            des = new Rectangle(296, 136, 55, 40);
            des1 = new Rectangle(296, 117, 55, 40);


        }


        public void Update(GameTime gameTime)
        {
            if (facingDown == true || facingUp == true)
            {
                position.Y += s;
                up = true;
            }

            if (facingRight == true || facingLeft == true)
            {
                position.X += s;
                side = true;

            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {


            if (up == true && (position.X > position.X + 250))
            {
                
                    spriteBatch.Draw(i, position, blueArrow, Color.White);
                
            }

                if (side == true && (position.Y > position.Y + 250))
                {
                    spriteBatch.Draw(i, position, smoke, Color.White);
                }


            


        }
    }
}

