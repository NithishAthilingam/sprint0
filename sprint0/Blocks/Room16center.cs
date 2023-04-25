using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Collision;

namespace sprint0
{
	public class Room16center : IBlock
    {

        Rectangle centerS;
        Rectangle centerD;
        Rectangle link;
        char x;
        Texture2D centerDraw;

        public Room16center(Texture2D blockSprite, Texture2D blockRoom1, Vector2 pos)
        {
            centerS = new Rectangle(386, 81, 16, 16);
            centerD = new Rectangle((int)pos.X, (int)pos.Y, 47, 47);


            centerDraw = blockRoom1;
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            Rectangle intersect = Rectangle.Intersect(link, centerD);
            x = CollisionDetection.GetDirection(link, centerD);

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
            //spriteBatch.Draw(centerDraw, centerD, centerS, Color.White);
        }
    }
}

