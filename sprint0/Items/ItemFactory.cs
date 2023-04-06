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


        public IItem CreateItem(int item, Vector2 pos)
        {
            switch (item)
            {
                case 1: // arrow
                    return new Arrow(pos);
                case 2: // can
                    return new Can(pos);
                case 3: // clock
                    return new Clock(pos);
                case 4: // diamonds
                    return new Diamonds(pos);
                case 5: // fire
                    return new Fire(pos);
                case 6: // hearts
                    return new Hearts(pos);
                case 7: // hearts w/ boarder
                    return new HeartwithBoarder(pos);
                case 8: // key
                    return new Key(pos);
                case 9: // lady item
                    return new LadyItem(pos);
                case 10: // triangle
                    return new Triangle(pos);
                default:
                    return null;
            }
        }
    }
}