using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Interfaces
{
    public  interface ICollision
    {
        //use rectangle.intersect()
        public void Update(GameTime gameTime, Game1 game);

        public void Draw(SpriteBatch spriteBatch);
        
    }
}
