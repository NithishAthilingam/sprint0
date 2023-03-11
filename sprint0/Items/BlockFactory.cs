using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace sprint0
{
    public class BlockFactory
    {
        private List<Rectangle> blocks;
        private Texture2D b;

        public BlockFactory(Texture2D blocksB)
        {
            this.b = blocksB;
        }



        public Rectangle GetBlock(int blockIndex)

        {


            blocks = new List<Rectangle>()

            {
                //blue 
                new Rectangle(353, 80, 16, 16),

                //water
                new Rectangle(562, 48, 16, 16),

                //edge room tiles
                new Rectangle(1358, 248, 16, 16),

                //room 1 tiles
                new Rectangle(556, 888, 16, 16),

                //room 1 tiles right side
                 new Rectangle(652, 888, 16, 16),

            };

            switch (blockIndex)
            {
                //blue tile
                case 1:
                    return new Rectangle(353, 80, 16, 16);

                //water
                case 2:
                    return new Rectangle(562, 48, 16, 16);

                case 3:
                    return new Rectangle(1358, 248, 16, 16);

                case 4:
                    return new Rectangle(556, 888, 16, 16);

                case 5:
                    return new Rectangle(652, 888, 16, 16);

                default:
                    return Rectangle.Empty;
            }


        }
    }

}
