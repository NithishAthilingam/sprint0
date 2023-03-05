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
        public void Update(GameTime gameTime, Game1 game)
        {
            if(game.linkPos == game.DragonPos)
            {
                //game.sprite;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
