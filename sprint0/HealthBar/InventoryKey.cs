using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace sprint0.HealthBar
{
    public class InventoryKey : IDisplay
    {

        private Rectangle key;
        private Rectangle keyDest;
        
        

        public InventoryKey()
        {
            key = new Rectangle(350, 250, 30, 30);
            keyDest = new Rectangle(700, 20, 50, 50);
            
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D keys)
        {

            spriteBatch.Draw(keys, keyDest, key, Color.White);
        }
    }
}

