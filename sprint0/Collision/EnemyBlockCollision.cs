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
        int frame =0;
        char x;
        float timer = 0f;
        float delayTime = 500f;
        Rectangle block;
        Rectangle enemy;
        Rectangle intersect;
        Vector4 enemyInfo;
        public Health h;



        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom, int enemyID)
        {
            game.currentRoomsRoom.enemiesD.TryGetValue(enemyID, out enemyInfo);
            game.currentRoomsRoom.enemiesD.Remove(enemyID);

            enemy = new Rectangle((int)enemyInfo.X, (int)enemyInfo.Y, (int)enemyInfo.Z, (int)enemyInfo.W);

            foreach (KeyValuePair<int, Vector4> blockEntry in currentRoomsRoom.blocksD)
            {
                block = new Rectangle((int)blockEntry.Value.X, (int)blockEntry.Value.Y, 50, 50);
                    
                x = CollisionDetection.GetDirection(enemy, block);

                if (x != 'o')
                {
                intersect = Rectangle.Intersect(enemy, block);
                currentRoomsRoom.enemiesD.Remove(enemyID);
                    //game.sprite = new DamagedSprite(game.linkPos);
                    if (x == 'w')
                    {
                            
                        enemyInfo.Y -= intersect.Height;
                    }
                    else if (x == 'a')
                    {
                        enemyInfo.X -= intersect.Width;
                    }
                    else if (x == 's')
                    {
                        enemyInfo.Y += intersect.Height;
                    }
                    else if (x == 'd')
                    {
                        enemyInfo.X += intersect.Width;

                    }
                    currentRoomsRoom.enemiesD.Add(enemyID, enemyInfo);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
