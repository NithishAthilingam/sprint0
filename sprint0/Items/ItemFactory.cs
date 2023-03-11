using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0
{
	public class ItemFactory
	{
		private Item[] items = new Item[11];

		public ItemFactory(Texture2D zelda, Texture2D fireTex, Texture2D items)
		{
            this.items[0] = new Item(zelda, fireTex, items, new Rectangle(270, 225, 30, 30));
            this.items[1] = new Item(zelda, fireTex, items, new Rectangle(270, 225, 20, 20));
            this.items[2] = new Item(zelda, fireTex, items, new Rectangle(380, 160, 30, 30));
            this.items[3] = new Item(zelda, fireTex, items, new Rectangle(415, 250, 17, 30));
            this.items[4] = new Item(zelda, fireTex, items, new Rectangle(350, 225, 30, 30));
            this.items[5] = new Item(zelda, fireTex, items, new Rectangle(290, 185, 30, 30));
            this.items[6] = new Item(zelda, fireTex, items, new Rectangle(350, 250, 30, 30));
            this.items[7] = new Item(zelda, fireTex, items, new Rectangle(150, 30, 24, 25));
            this.items[8] = new Item(zelda, fireTex, items, new Rectangle(375, 250, 30, 30));
            this.items[9] = new Item(zelda, fireTex, items, new Rectangle(350, 275, 30, 30));
            this.items[10] = new Item(zelda, fireTex, items, new Rectangle(290, 0, 30, 30));

        }

        public Item GetItem(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and " + (items.Length - 1));
            }
            return items[index];
        }
    }
}

