using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Collision;

namespace sprint0
{
    public class WaterBlock : IBlock
    {


        Rectangle waterS;
        Rectangle waterD;

        //private Vector2 thisPos;
        Texture2D blockDraw;
        Rectangle link;
        char x;


        public WaterBlock(Texture2D blockSprite, Texture2D blockRoom, Vector2 pos)
        {
            waterS = new Rectangle(545, 200, 16, 16);
            waterD = new Rectangle((int)pos.X, (int)pos.Y, 47, 47);

            blockDraw = blockRoom;
        }


        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 47, 47);
            Rectangle intersect = Rectangle.Intersect(link, waterD);
            x = CollisionDetection.GetDirection(link, waterD);

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
            //spriteBatch.Draw(blockDraw, waterD, waterS, Color.White);

        }
    }
}

