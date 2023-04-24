using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
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


        public IBlock GetBlock(Texture2D blockSprite, Texture2D blockRoom,int blockIndex, Vector2 position)
        {
            switch (blockIndex)
            {
                case 1: 
                    return new BlueBlock(blockSprite, blockRoom,position);
                case 2: 
                    return new EdgeBlock(blockSprite, blockRoom,position);
                case 3: 
                    return new WaterBlock(blockSprite, blockRoom, position);
                case 4:
                    return new Room1LeftBlock(blockSprite, blockRoom,position);
                case 5:
                    return new Room1RightBlock(blockSprite, blockRoom,position);
                case 6:
                    return new Room16center(blockSprite, blockRoom, position);
                default:
                    return null;
            }
        }
    }
}