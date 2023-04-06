using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;



namespace sprint0
{ 

    public class BlockFactory

    {
        private static BlockFactory instance = new BlockFactory();

        public static BlockFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public BlockFactory() { }


        public IBlock GetBlock(int blockIndex, Vector2 position)
        {
            switch (blockIndex)
            {
                case 1: 
                    return new BlueBlock(position);
                case 2: 
                    return new EdgeBlock(position);
                case 3: 
                    return new WaterBlock(position);
                case 4:
                    return new Room1LeftBlock(position);
                case 5:
                    return new Room1RightBlock(position);
                default:
                    return null;
            }
        }
    }
}