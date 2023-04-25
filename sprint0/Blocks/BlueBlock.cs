using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Collision;

namespace sprint0
{
    public class BlueBlock : IBlock
    {


        Rectangle blueS;
        Rectangle blueD;
        Rectangle link;

        char x;
        Texture2D blockDraw;

        public BlueBlock(Texture2D blockSprite, Texture2D blockRoom, Vector2 pos)
        {
            blueS = new Rectangle(366, 568, 16, 16);
            blueD = new Rectangle((int)pos.X, (int)pos.Y, 47, 47);

            blockDraw = blockRoom;
        }

        public void Update(GameTime gameTime,Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 30, 30);
            Rectangle intersect = Rectangle.Intersect(link, blueD);
            x = CollisionDetection.GetDirection(link, blueD);

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
           // spriteBatch.Draw(blockDraw, blueD, blueS, Color.White);

        }
    }
}

