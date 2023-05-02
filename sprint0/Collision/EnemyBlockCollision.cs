using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sprint0.Interfaces;
using sprint0.HealthBar;

namespace sprint0.Collision
{
    internal class EnemyBlockCollision : ICollision
    {
        char x;
        Rectangle block;
        Rectangle enemy;
        Rectangle intersect;
        int[] enemyInfo;



        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom, int enemyID)
        {
            enemyInfo = new int[6];
            game.currentRoomsRoom.enemiesD.TryGetValue(enemyID, out enemyInfo);

            enemy = new Rectangle((int)enemyInfo[0], (int)enemyInfo[1], (int)enemyInfo[2], (int)enemyInfo[3]);

            foreach (KeyValuePair<int, Vector4> blockEntry in currentRoomsRoom.blocksD)
            {
                block = new Rectangle((int)blockEntry.Value.X, (int)blockEntry.Value.Y, 50, 50);
                    
                x = CollisionDetection.GetDirection(enemy, block);

                if (x != 'o')
                {
                intersect = Rectangle.Intersect(enemy, block);
                currentRoomsRoom.enemiesD.Remove(enemyID);
                    
                    if (x == 'w')
                    {

                        enemyInfo[1] -= intersect.Height;
                    }
                    else if (x == 'a')
                    {
                        enemyInfo[0] -= intersect.Width;
                    }
                    else if (x == 's')
                    {
                        enemyInfo[1] += intersect.Height;
                    }
                    else if (x == 'd')
                    {
                        enemyInfo[0] += intersect.Width;

                    }
                    currentRoomsRoom.enemiesD.Add(enemyID, enemyInfo);
                }
                else
                {

                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
