using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using sprint0;
//using Microsoft.Xna.Framework.Net;
//using Microsoft.Xna.Framework.Storage;

namespace sprint0
{
    public class LoadRectangles
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        IDictionary<int, string> linkAnimate = new Dictionary<int, string>();
        numberNames.Add(1,"One"); //adding a key/value using the Add() method

        protected void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            Rectangle dest1 = new Rectangle(100, 100, 40, 40);

            Rectangle source2 = new Rectangle(0, 1, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 40, 40);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate);

            TextSprite.Draw(spriteBatch, font);

            if (currentFrame == 0)
            {
                spriteBatch.Draw(zelda, dest1, source1, Color.White);
            }
            else if (currentFrame == 5)
            {
                spriteBatch.Draw(zelda, dest2, source2, Color.White);
            }
            spriteBatch.Draw(zelda, dest1, source1, Color.White);

            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
