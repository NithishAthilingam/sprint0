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
        public static string GetDirection(Rectangle collider, Rectangle victim)
        {
            string colide = "a";
            Rectangle intersect = Rectangle.Intersect(collider, victim);

            if(intersect.IsEmpty)
            {
                colide = "none";
            }
            else if(intersect.Height > intersect.Width) { 
                if(collider.X < victim.X)
                {
                    colide = "lr";
                }
                else
                {
                    colide = "rl";
                }
            }
            else
            {
                if(intersect.Y < victim.Y)
                {
                    colide = "bt";
                }
                else
                {
                    colide = "tb";
                }
            }

            return colide;
        }
    }
}
