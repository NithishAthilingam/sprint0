using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Collision
{

    public class BlockCollision : ICollision
    {
        int frame = 0;
        char x;
        Rectangle link;
        Rectangle block;


        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom, int id)
        {
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 60, 60);
            block = new Rectangle((int)game.EnemyPos.X, (int)game.EnemyPos.Y, 55, 55);
            Rectangle intersect = Rectangle.Intersect(link, block);
            x = CollisionDetection.GetDirection(link, block);
            frame++;

            /*foreach (var rect in roomsBLock[0])
            {
                if(rect.Intersects(game.linkBound))
                {
                    game.linkPos = initialpos;
                    game.sprite = new DamagedSprite(game.linkPos);

                }
            } */
            /*if(EnemyBound.Intersects(game.linkBound))
            {
                game.sprite = new DamagedSprite(game.linkPos);
            }*/
            if (new Rectangle(0,0,0,0).Intersects(new Rectangle(0,0,0,0)))
            {
                game.sprite = new DamagedSprite(game.linkPos);
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
