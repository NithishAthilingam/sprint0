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
    internal class SwordLinkCollision : ICollision
    {
        int frame =0;
        char x;
        char direction;
        float timer = 0f;
        float delayTime = 500f;
        Rectangle link;
        Rectangle enemy;
        Rectangle intersect;
        public Health h;
        int key = 9000;
        int enemyHealth;
        int[] enemyInfo;


        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom, int id)
        {
            enemyInfo = new int[6];
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //push
            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 60, 60);
            foreach (KeyValuePair<int, int[]> entry in currentRoomsRoom.enemiesD)
            {
                enemy = new Rectangle((int)entry.Value[0], (int)entry.Value[1], (int)entry.Value[2], (int)entry.Value[3]);
                intersect = Rectangle.Intersect(link, enemy);
                x = CollisionDetection.GetDirection(link, enemy);


                frame++;
                if (x != 'o')
                {
                    key = entry.Key;
                    direction = x;

                }
                else
                {
                    key = 9000;
                }
            }

            game.currentRoomsRoom.enemiesD.TryGetValue(key, out enemyInfo);
            if (key != 9000)
            {
                game.currentRoomsRoom.enemiesD.Remove(key);
                if (direction == 'w')
                {

                    enemyInfo[1] -= intersect.Height;
                }
                else if (direction == 'a')
                {
                    enemyInfo[0] -= intersect.Width;
                }
                else if (direction == 's')
                {
                    enemyInfo[1] += intersect.Height;
                }
                else if (direction == 'd')
                {
                    enemyInfo[0] += intersect.Width;

                }

                enemyHealth = enemyInfo[4];
                if (enemyInfo[4] > 0)
                {
                    //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                    enemyHealth--;
                    enemyInfo[4] = enemyHealth;
                    timer = delayTime;
                    currentRoomsRoom.enemiesD.Add(key, enemyInfo);

                }
                else
                {
                    //dont add back enemy
                }
                
            }


            
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
