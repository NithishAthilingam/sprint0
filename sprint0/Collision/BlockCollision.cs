using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Collision
{

    public class BlockCollision
    {
        Dictionary<int, Rectangle[]> roomsBLock;

        public BlockCollision()
        {
            roomsBLock = new Dictionary<int, Rectangle[]>()
            {
                {0,new Rectangle[] {} },
                {1,new Rectangle[] {} },
                {2,new Rectangle[] {} },
                {3,new Rectangle[] {} },

            };
        }
        
    }
}
