﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace sprint0
{
	public class Rooms
	{

        Rectangle source2;
        Rectangle source1;
        Rectangle source3;
        Rectangle source4;
        Rectangle source5;
        Rectangle source6;

        Rectangle source7;
        Rectangle salma1;
        Rectangle salma2;
        Rectangle salma3;
        Rectangle salma4;
        Rectangle salma5;
        Rectangle salma6;
        Rectangle salma7;
        Rectangle salma8;
        Rectangle salma9;
        Rectangle salma10;





        private Texture2D room;
        private Game1 game1;


        // Declare a new list of rectangles
        List<Rectangle> rectList = new List<Rectangle>();


        public Rooms(Texture2D r, Game1 game)
		{
            game1 = game;

            room = r;

            // Add some rectangles to the list
            rectList.Add(new Rectangle(0, 0, 50, 50));
            rectList.Add(new Rectangle(100, 100, 25, 25));


            //entrance to dungeon
            //one
            source1 = new Rectangle(508, 840, 257, 168);
            //left of one
            //two
            salma3 = new Rectangle(256, 840, 257, 168);
            //right of one
            //three
            source4 = new Rectangle(763, 840, 257, 168);
            //top of one
            //four
            salma7 = new Rectangle(511, 672, 256, 165);
            //top of four
            //five 
            source2 = new Rectangle(770, 336, 257, 168);
            //left of five
            //six
            source3 = new Rectangle(764, 503, 257, 168);
            //right of five
            //seven
            salma6 = new Rectangle(255, 504, 257, 168);
            //top of seven
            //eight
            salma5 = new Rectangle(257, 336, 257, 168);
            //left of eight
            //nine
            salma4 = new Rectangle(0, 336, 257, 168);
            //right of nine
            //ten
            salma8 = new Rectangle(514, 336, 257, 168);
            //top of ten
            //eleven
            salma9 = new Rectangle(514, 168, 255, 168);

            //top of eleven
            //12
            salma10 = new Rectangle(513, 0, 256, 168);



            //one door lots of blocks everywhere
            source5 = new Rectangle(1020, 336, 257, 168);

            //two doors and blocks clustered by locked door
            source6 = new Rectangle(1023, 168, 257, 168);

            //treasure room
            source7 = new Rectangle(1278, 168, 257, 168);

            //top
            salma1 = new Rectangle(257, 0, 257, 168);

            //black and grey
             salma2 = new Rectangle(257, 167, 255, 152);

            //bottom
             salma3 = new Rectangle(257, 840, 255, 152);
            salma2 = new Rectangle(257, 168, 255, 152);

    


     






            ////outer
            //source1 = new Rectangle(521, 11, 256, 176);
            ////room1
            //source2 = new Rectangle(390, 192, 192, 112);
            ////left door
            //source3 = new Rectangle(848, 44, 32, 32);
            ////no door on top  
            //source4 = new Rectangle(815, 11, 32, 32);
            ////no door on bottom 
            //source5 = new Rectangle(815, 110, 32, 32);
            ////right door
            //source6 = new Rectangle(815, 77, 32, 32);


        }

        public void Draw(SpriteBatch spriteBatch)
        {


            spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), salma10, Color.White);

            //outer
            //  spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), source1, Color.White);
           // spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), salma6, Color.White);

            ////top door
            //spriteBatch.Draw(room, new Rectangle(348, 0, 103, 90), source4, Color.White);


            ////left door
            //spriteBatch.Draw(room, new Rectangle(0, 195, 103, 90), source3, Color.White);

            ////bottom door
            //spriteBatch.Draw(room, new Rectangle(348, 390, 103, 90), source5, Color.White);

            ////right door
            //spriteBatch.Draw(room, new Rectangle(700, 195, 103, 90), source6, Color.White);

            ////room1
            //spriteBatch.Draw(room, new Rectangle(97, 83, 603, 312), source2, Color.White);

        }

    }
}

