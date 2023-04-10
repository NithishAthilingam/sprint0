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


        public IBlock GetBlock(Texture2D blockSprite, int blockIndex, Vector2 position)
        {
            switch (blockIndex)
            {
                case 1: 
                    return new BlueBlock(blockSprite,position);
                case 2: 
                    return new EdgeBlock(blockSprite,position);
                case 3: 
                    return new WaterBlock(blockSprite,position);
                case 4:
                    return new Room1LeftBlock(blockSprite,position);
                case 5:
                    return new Room1RightBlock(blockSprite,position);
                default:
                    return null;
            }
        }
    }
}