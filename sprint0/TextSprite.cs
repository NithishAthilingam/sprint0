using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
    public class TextSprite : Isprite
    {
        public TextSprite()
        {
        }
#pragma warning disable CS0414 // The field 'TextSprite.currentFrame' is assigned but its value is never used
        private int currentFrame = 0;
#pragma warning restore CS0414 // The field 'TextSprite.currentFrame' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'TextSprite.totalFrames' is assigned but its value is never used
        private int totalFrames = 45;
#pragma warning restore CS0414 // The field 'TextSprite.totalFrames' is assigned but its value is never used
        private Vector2 location = new Vector2(220, 100);

        //credits
        //public void Draw(SpriteBatch spriteBatch, SpriteFont font)
        //{
        //    spriteBatch.DrawString(font, "CREDITS", new Vector2(000, 300), Color.Black);
        //    spriteBatch.DrawString(font, "Program By: Nithish Athilingam", new Vector2(000, 333), Color.Black);
        //    spriteBatch.DrawString(font, "Sprites from: www.mariomayhem.com", new Vector2(000, 366), Color.Black);
        //}
        public void Update()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            //Just standing there
            

        }
    }
}