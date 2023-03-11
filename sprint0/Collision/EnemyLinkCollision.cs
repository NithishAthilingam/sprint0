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
        public void Update(GameTime gameTime, Game1 game)
        {
            //char x = CollisionDetection.GetDirection(NULL, NULL);
            frame++;
            if (game.EnemyPos.X - game.linkPos.X  < 20 )
            {
                game.sprite = new DamagedSprite(game.linkPos);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
