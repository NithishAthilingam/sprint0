using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace sprint0
{
    public class Rooms
    {

        float delayTime;
        float timer;
        Rectangle des;
        int currentA;
        int previousA;
        float speed;
        float tt;
        private int middle;
        private int left;
        private int right;
        int currentImageIndex;
        private Texture2D room;
        private Game1 game1;
        Rectangle[] rooms;

        public Rooms(Texture2D r, Game1 game)
        {

            game1 = game;
            room = r;
            currentImageIndex = 0;
            delayTime = 500f;
            timer = 0f;

            rooms = new Rectangle[18];
            //enter
            rooms[0] = new Rectangle(510, 840, 256, 168);
            //l
            rooms[1] = new Rectangle(254, 840, 256, 168);
            //r
            rooms[2] = new Rectangle(765, 840, 256, 168);
            //f
            rooms[3] = new Rectangle(511, 672, 256, 168);
            //ff
            rooms[4] = new Rectangle(511, 504, 256, 168);
            //ffr
            rooms[5] = new Rectangle(765, 504, 256, 168);
            //ffl
            rooms[6] = new Rectangle(254, 504, 256, 168);
            //fflf
            rooms[7] = new Rectangle(254, 336, 256, 168);
            //fflfl
            rooms[8] = new Rectangle(0, 336, 256, 168);
            //fflfr
            rooms[9] = new Rectangle(510, 336, 256, 168);
            //fflfrr
            rooms[10] = new Rectangle(767, 336, 256, 168);
            //fflfrrr
            rooms[11] = new Rectangle(1022, 336, 256, 168);
            //fflfrrrf
            rooms[12] = new Rectangle(1022, 168, 256, 168);
            //fflfrrrfr
            rooms[13] = new Rectangle(1279, 168, 256, 168);
            //fflfrf
            rooms[14] = new Rectangle(513, 168, 256, 168);
            //fflfrff
            rooms[15] = new Rectangle(513, 0, 256, 168);
            //fflfrffl
            rooms[16] = new Rectangle(257, 0, 256, 168);
            //fflfrfflb
            rooms[17] = new Rectangle(257, 168, 255, 152);

        }

        public void Update(GameTime gameTime)
        {
            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (timer <= 0f)
            {
                MouseState mouseState = Mouse.GetState();
                if (MouseController.CheckMouseStateRight())
                {
                    currentImageIndex++;
                    if (currentImageIndex >= rooms.Length)
                        currentImageIndex = 0;
                    timer = delayTime;
                }
                else if (MouseController.CheckMouseStateLeft())
                {
                    currentImageIndex--;
                    if (currentImageIndex < 0)
                        currentImageIndex = rooms.Length - 1;
                    timer = delayTime;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            //if (currentImageIndex < rooms.Length)
            //{
                spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[currentImageIndex], Color.White);
                //currentImageIndex++;

            spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[currentImageIndex], Color.White);

            //    if (currentImageIndex == 1)
            //    {
            //        spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[1], Color.White);
            //    }
            //    if (currentImageIndex == 2)
            //    {
            //        spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[2], Color.White);
            //    }
            //    if (currentImageIndex == 5)
            //    {
            //        spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[5], Color.White);
            //    }
            //    if (currentImageIndex == 11)
            //    {
            //        spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[11], Color.White);
            //    }
            //    else
            //        spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[currentImageIndex], Color.White);
            //}
        }
    }
}


