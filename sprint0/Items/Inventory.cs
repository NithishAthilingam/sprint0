using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Items
{
    class Inventory : IItem
    {
        public Dictionary<int,int> inventory = new Dictionary<int,int>();
        public void Draw(SpriteBatch spriteBatch)
        {
        }

        public void Update(GameTime gameTime, Game1 game)
        {
        }
    }
}
