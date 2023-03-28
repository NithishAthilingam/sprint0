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
        Dictionary<int, Rectangle[]> roomsBLock;

        public BlockCollision()
        {
            roomsBLock = new Dictionary<int, Rectangle[]>()
            {
                {0,new Rectangle[] { new Rectangle(70, 65, 14, 14), new Rectangle(98, 65, 14, 14), new Rectangle(126, 65, 14, 14), new Rectangle(154, 65, 14, 14) } },
                {1,new Rectangle[] {} },
                {2,new Rectangle[] {} },
                {3,new Rectangle[] {} },

            };
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            //char x = CollisionDetection.GetDirection(NULL, NULL);
            Rectangle EnemyBound = new Rectangle((int)game.EnemyPos.X, (int)game.EnemyPos.Y, 30, 35);
            Vector2 initialpos = game.linkPos;
            /*foreach (var rect in roomsBLock[0])
            {
                if(rect.Intersects(game.linkBound))
                {
                    game.linkPos = initialpos;
                    game.sprite = new DamagedSprite(game.linkPos);

                }
            } */
            if(EnemyBound.Intersects(game.linkBound))
            {
                game.sprite = new DamagedSprite(game.linkPos);
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
