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
        public Health h;



        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom)
        {
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //push
            foreach (KeyValuePair<int, Vector4> entry in currentRoomsRoom.enemiesD)
            {
                enemy = new Rectangle((int)entry.Value.X, (int)entry.Value.Y, 40, 40);
                foreach (KeyValuePair<int, Vector4> blockEntry in currentRoomsRoom.blocksD)
                {
                    block = new Rectangle((int)blockEntry.Value.X, (int)blockEntry.Value.Y, 50, 50);
                    intersect = Rectangle.Intersect(enemy, block);
                    x = CollisionDetection.GetDirection(enemy, block);


                    if (x != 'o')
                    {
                        //game.sprite = new DamagedSprite(game.linkPos);
                        if (x == 'w')
                        {
                            currentRoomsRoom.enemiesD.Remove(1);
                            float num = (entry.Value.Y) - (intersect.Height);
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
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
