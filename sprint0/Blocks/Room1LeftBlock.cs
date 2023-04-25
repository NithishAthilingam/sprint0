using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Collision;

namespace sprint0
{
    public class Room1LeftBlock : IBlock
    {


        Rectangle leftS;
        Rectangle leftD;
        int thisPosx;
        int thisPosy;
        Rectangle link;
        char x;

        Texture2D blockDraw;


        public Room1LeftBlock(Texture2D blockSprite,Texture2D blockRoom1, Vector2 pos)
        {

            leftS = new Rectangle(653, 888, 16, 16);
            leftD = new Rectangle((int)pos.X, (int)pos.Y, 47, 47);
            //leftS = new Rectangle(652, 887, 18, 18);
            //leftD = new Rectangle((int)pos.X, (int)pos.Y, 55, 55);

            thisPosx = (int)pos.X;
            thisPosy = (int)pos.Y;


            blockDraw = blockRoom1;



            Console.WriteLine("posX : " + thisPosx.ToString() + "posY : " + thisPosy.ToString());

        }

        public void Update(GameTime gameTime,Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            Rectangle intersect = Rectangle.Intersect(link,leftD);
            x = CollisionDetection.GetDirection(link, leftD);
 
            if (x != 'o')
            {
                if (x == 'w')
                {
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(0, -intersect.Height));
                }
                else if (x == 'a')
                {
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(-intersect.Width, 0));
                }
                else if (x == 's')
                {
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(0, intersect.Height));
                }
                else if (x == 'd')
                {
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(intersect.Width, 0));
                }
            }
            }



        public void Draw(SpriteBatch spriteBatch)
        {
           //spriteBatch.Draw(blockDraw, leftD, leftS, Color.White);
        }

    }
}




