using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
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
        private Texture2D room;
        private Game1 game1;



        public Rooms(Texture2D r, Game1 game)
		{
            game1 = game;

            room = r;

            //entrance to dungeon
            source1 = new Rectangle(508, 840, 257, 168);

            //two doors 4 squares
            source2 = new Rectangle(770, 336, 257, 168);

            //one door 4 squares
            source3 = new Rectangle(764, 503, 257, 168);

            //one door 2 six block clusters
            source4 = new Rectangle(763, 840, 257, 168);

            //one door lots of blocks everywhere
            source5 = new Rectangle(1020, 336, 257, 168);

            //two doors and blocks clustered by locked door
            source6 = new Rectangle(1023, 168, 257, 168);

            //treasure room
            source7 = new Rectangle(1278, 168, 257, 168);

            //top
            salma1 = new Rectangle(257, 0, 257, 168);

            //black and grey
            salma2 = new Rectangle(257, 168, 255, 152);

            //bottom
            salma3 = new Rectangle(256, 840, 257, 168);

            //w/fire
            salma4 = new Rectangle(0, 336, 257, 168);

            //one block 
            salma5 = new Rectangle(257, 336, 257, 168);

            //one large block 
            salma6 = new Rectangle(255, 504, 257, 168);

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
            //outer
            spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), salma6, Color.White);

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

