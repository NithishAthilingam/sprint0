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

        public Room1LeftBlock(Texture2D blockSprite,Texture2D blockRoom1, Vector2 pos)
        {

            leftS = new Rectangle(652, 887, 18, 18);
            leftD = new Rectangle((int)pos.X, (int)pos.Y, 55, 50);

            thisPos = pos;
            thisPosx = (int)pos.X;
            thisPosy = (int)pos.Y;


            blockDraw = blockRoom1;

            Console.WriteLine("posX : " + thisPosx.ToString() + "posY : " + thisPosy.ToString());

        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {


            spriteBatch.Draw(blockDraw, leftD, leftS, Color.White);

        }
    }
}




