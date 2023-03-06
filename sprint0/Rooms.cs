﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
namespace sprint0
{
	public class Rooms
	{

      
        Rectangle roomBorder;
        Rectangle leftDoorPos;
        Rectangle topDoorPos;
        Rectangle bottomDoorPos;
        Rectangle rightDoorPos;
        private Texture2D room;
        private Game1 game1;

        Rectangle source2;



        public Rooms(Texture2D r, Game1 game)
		{
            game1 = game;

            room = r;

            roomBorder = new Rectangle(521, 11, 256, 176);
            source2 = new Rectangle(390, 192, 192, 112);
            leftDoorPos = new Rectangle(848, 44, 32, 32);
            topDoorPos = new Rectangle(815, 11, 32, 32);
            bottomDoorPos = new Rectangle(815, 110, 32, 32);
            rightDoorPos = new Rectangle(815, 77, 32, 32);


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //outer
            spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), roomBorder, Color.White);

            //top door
            spriteBatch.Draw(room, new Rectangle(348, 0, 103, 90), topDoorPos, Color.White);

            //left door
            spriteBatch.Draw(room, new Rectangle(0, 195, 103, 90), leftDoorPos, Color.White);

            //bottom door
            spriteBatch.Draw(room, new Rectangle(348, 390, 103, 90), bottomDoorPos, Color.White);

            //right door
            spriteBatch.Draw(room, new Rectangle(700, 195, 103, 90), rightDoorPos, Color.White);

            //room1
            spriteBatch.Draw(room, new Rectangle(97, 83, 603, 312), source2, Color.White);

        }

    }
}

