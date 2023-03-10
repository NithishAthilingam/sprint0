using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.Collision
{
    public static class CollisionDetection
    {
        public static char GetDirection(Rectangle collider, Rectangle victim)
        {
            char colide = 'o';
            Rectangle intersect = Rectangle.Intersect(collider, victim);

            if(intersect.IsEmpty)
            {
                colide = 'o';
            }
            else if(intersect.Height > intersect.Width) { 
                if(collider.X < victim.X)
                {
                    colide = 'd';
                }
                else
                {
                    colide = 'a';
                }
            }
            else
            {
                if(intersect.Y < victim.Y)
                {
                    colide = 'w';
                }
                else
                {
                    colide = 's';
                }
            }

            return colide;
        }
    }
}
