using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Collision;

namespace sprint0
{
    public class Room1RightBlock : IBlock
    {


        Rectangle rightD;
        Rectangle rightS;


        int thisPosx;
        int thisPosy;
        Rectangle link;
        char x;

        Texture2D blockDraw;

        public Room1RightBlock(Texture2D blockSprite,Texture2D blockRoom1, Vector2 pos)
        {
            rightS = new Rectangle(557, 888, 16, 16);
            rightD = new Rectangle((int)pos.X, (int)pos.Y, 47, 47);
            //collisionBox = rightD;

            //rightS = new Rectangle(556, 887, 18, 18);
            //rightD= new Rectangle((int)pos.X, (int)pos.Y, 55, 55);

            blockDraw = blockRoom1;



            thisPosx = (int)pos.X;
            thisPosy = (int)pos.Y;


            Console.WriteLine("posX : " + thisPosx.ToString() + "posY : " + thisPosy.ToString());

        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 47, 47);
            Rectangle intersect = Rectangle.Intersect(link, rightD);
            x = CollisionDetection.GetDirection(link, rightD);

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
          //spriteBatch.Draw(blockDraw, rightD, rightS, Color.White);


        }

    }
}




