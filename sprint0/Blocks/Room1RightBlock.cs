using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0
{
    public class Room1RightBlock : IBlock
    {


        Rectangle rightD;
        Rectangle rightS;

        private Vector2 thisPos;
        int thisPosx;
        int thisPosy;

        Texture2D blockDraw;
        Rectangle collisionBox;

        public Room1RightBlock(Texture2D blockSprite,Texture2D blockRoom1, Vector2 pos)
        {
            rightS = new Rectangle(557, 888, 16, 16);
            rightD = new Rectangle((int)pos.X, (int)pos.Y, 55, 55);
            collisionBox = rightD;


            blockDraw = blockRoom1;


            thisPos = pos;
            thisPosx = (int)pos.X;
            thisPosy = (int)pos.Y;


            Console.WriteLine("posX : " + thisPosx.ToString() + "posY : " + thisPosy.ToString());

        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
           spriteBatch.Draw(blockDraw, rightD, rightS, Color.White);


        }

    }
}




