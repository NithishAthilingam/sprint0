using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace sprint0
{
	public class ItemFactory
	{

        private static ItemFactory instance = new ItemFactory();

        public static ItemFactory Instance
        {
            get
            {
                return instance;
            }
        }


        public ItemFactory() { }


        public IItem CreateItem(Texture2D itemsSprite, Texture2D ladySprite, Texture2D fireSprite, Texture2D boom, int item, Vector2 pos)
        {
            switch (item)
            {
                case 1: // arrow
                    return new Arrow(itemsSprite,pos);
                case 2: // can
                    return new Can(itemsSprite,pos);
                case 3: // clock
                    return new Clock(itemsSprite,pos);
                case 4: // diamonds
                    return new Diamonds(itemsSprite,pos);
                case 5: // fire
                    return new Fire(fireSprite,pos);
                case 6: // hearts
                    return new Hearts(itemsSprite,pos);
                case 7: // hearts w/ boarder
                    return new HeartwithBoarder(itemsSprite,pos);
                case 8: // key
                    return new Key(itemsSprite,pos);
                case 9: // lady item
                    return new LadyItem(ladySprite,pos);
                case 10: // triangle
                    return new Triangle(itemsSprite,pos);
                case 11: // bar
                    return new Bar(itemsSprite, pos);
                default:
                    return null;
            }
        }
    }
}