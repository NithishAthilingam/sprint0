using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sprint0.Interfaces;

namespace sprint0.Collision
{
    internal class EnemyLinkCollision : ICollision
    {
        int frame =0;
        char x;
        Rectangle link;
        Rectangle enemy;

        public void Update(GameTime gameTime, Game1 game)
        {
            link = new Rectangle((int)game.linkPos.X, (int)game.linkPos.Y, 60, 60);
            enemy = new Rectangle((int)game.EnemyPos.X, (int)game.EnemyPos.Y, 90, 105);
            x = CollisionDetection.GetDirection(link, enemy);
            frame++;
            if (x!='o')
            {
                //game.sprite = new DamagedSprite(game.linkPos);
                if(x == 'w')
                {
                    //game.sprite = new UpSprite(game.linkPos);
                    game.linkPos.Y -= 10;
                }
                else if(x == 'a')
                {
                    //game.sprite = new LeftSprite(game.linkPos);
                    game.linkPos.X -= 10;
                }
                else if (x == 's')
                {
                    //game.sprite = new DownSprite(game.linkPos);
                    game.linkPos.Y += 10;
                }
                else if (x == 'd')
                {
                    //game.sprite = new RightSprite(game.linkPos);
                    game.linkPos.X += 10;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
