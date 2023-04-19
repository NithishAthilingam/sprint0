using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class Room1LeftBlock : IBlock
    {


        Rectangle leftS;
        Rectangle leftD;
        private Vector2 thisPos;
        int thisPosx;
        int thisPosy;

        Texture2D blockDraw;
        Rectangle collisionBox;


        public Room1LeftBlock(Texture2D blockSprite,Texture2D blockRoom1, Vector2 pos)
        {

            leftS = new Rectangle(653, 888, 16, 16);
            leftD = new Rectangle((int)pos.X, (int)pos.Y, 55, 55);
            collisionBox = new Rectangle((int)pos.X, (int)pos.Y, 55, 55);

            thisPos = pos;
            thisPosx = (int)pos.X;
            thisPosy = (int)pos.Y;


            blockDraw = blockRoom1;



            Console.WriteLine("posX : " + thisPosx.ToString() + "posY : " + thisPosy.ToString());

        }

        public void Update(GameTime gameTime)
        {
        }


        public Rectangle CollisionBox { get { return collisionBox; } }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blockDraw, leftD, leftS, Color.White);

        }

    }
}




