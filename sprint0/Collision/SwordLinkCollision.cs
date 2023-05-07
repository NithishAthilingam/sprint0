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
        char y;
        char direction;
        float timer = 0f;
        float delayTime = 500f;
        Rectangle link;
        Rectangle flyingSword;
        Rectangle enemy;
        Rectangle intersect;
        public Health h;
        int key = 9000;
        int enemyHealth;
        int[] enemyInfo;
        int i;
        Random rand;


        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom, int id)
        {
            rand = new Random();
            i = 0;
            enemyInfo = new int[6];
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //push
            if (id == 1)
            {
                link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y-40, 60, 96);
            }
            else if (id == 2)
            {
                link = new Rectangle((int)game.controller[0].GetLinkPos().X-40, (int)game.controller[0].GetLinkPos().Y-30, 96, 78);
            }
            else if (id == 3)
            {
                link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 60, 96);
            }
            else 
            {
                link = new Rectangle((int)game.controller[0].GetLinkPos().X-5, (int)game.controller[0].GetLinkPos().Y-25, 96, 78);
            }


            foreach (KeyValuePair<int, int[]> entry in game.currentRoomsRoom.enemiesD)
            {
                enemyInfo = entry.Value;
                enemy = new Rectangle((int)enemyInfo[0], (int)enemyInfo[1], (int)enemyInfo[2], (int)enemyInfo[3]);
                
                intersect = Rectangle.Intersect(link, enemy);
                x = CollisionDetection.GetDirection(link, enemy);
                y = CollisionDetection.GetDirection(link, enemy);
                frame++;
                if (x != 'o')
                {
                    key = entry.Key;
                    direction = x;

                }
                else
                {
                    //key = 9000;
                }
            }


            if (game.currentRoomsRoom.enemiesD.ContainsKey(key))
            {


                game.currentRoomsRoom.enemiesD.TryGetValue(key, out enemyInfo);
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
                game.currentRoomsRoom.enemiesD.Add(key, enemyInfo);

                enemyHealth = enemyInfo[5];
                
                    game.currentRoomsRoom.enemiesD.Remove(key);
                if (enemyInfo[5] > 0)
                {
                    if (timer <= 0f)
                    {
                        //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                        enemyHealth--;
                    enemyInfo[5] = enemyHealth;
                    game.currentRoomsRoom.enemiesD.Add(key, enemyInfo);
                    
                        timer = delayTime;
                    }
                }
                else if (enemyInfo[5] == 0)
                {
                    int next = rand.Next(1);
                    if(next== 0) { i = 6; }
                    else { i = 9; }
                    IItem newItem = ItemFactory.Instance.CreateItem(game.Animate[4], game.Animate[9], game.Animate[12], game.Animate[11], 9, new Vector2(enemyInfo[0], enemyInfo[1]));

                    game.currentRoomsRoom.items.Add(newItem);
                }
            }
            


            
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
