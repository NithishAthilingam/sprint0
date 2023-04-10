using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;
using Microsoft.Xna.Framework.Input;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


using sprint0.Items;

namespace sprint0.Collision
{
	public class DoorCollision : ICollision
	{
       

        float delayTime;
        float timer;
        int currentImageIndex;
        private Texture2D room;
        private Game1 game1;
        Rectangle[] rooms;
        Dictionary<int, int[]> myRooms;
        Color cal = Color.White;
        KeyboardState keyboard;

        public DoorCollision(Texture2D r, Game1 game)
		{
            game1 = game;
            room = r;
            currentImageIndex = 0;
            delayTime = 500f;
            timer = 0f;

            rooms = new Rectangle[18];
            //enter
            rooms[0] = new Rectangle(509, 840, 256, 168);
            //l
            rooms[1] = new Rectangle(254, 840, 256, 168);
            //r
            rooms[2] = new Rectangle(765, 840, 256, 168);
            //f
            rooms[3] = new Rectangle(511, 672, 256, 168);
            //ff
            rooms[4] = new Rectangle(510, 504, 256, 168);
            //ffr
            rooms[5] = new Rectangle(766, 504, 256, 168);
            //ffl
            rooms[6] = new Rectangle(254, 504, 256, 168);
            //fflf
            rooms[7] = new Rectangle(256, 336, 256, 168);
            //fflfl
            rooms[8] = new Rectangle(0, 336, 256, 168);
            //fflfr
            rooms[9] = new Rectangle(511, 336, 256, 168);
            //fflfrr
            rooms[10] = new Rectangle(767, 336, 256, 168);
            //fflfrrr
            rooms[11] = new Rectangle(1022, 336, 256, 168);
            //fflfrrrf
            rooms[12] = new Rectangle(1023, 168, 256, 168);
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

            myRooms = new Dictionary<int, int[]>()
            {
                {0, new int[] {3,1,0,2} },
                {1, new int[] {0,0,0,0} },
                {2, new int[] {0,0,0,0} },
                {3, new int[] {4,0,0,0} },
                {4, new int[] {0,6,3,5} },
                {5, new int[] {0,4,0,0} },
                {6, new int[] {7,0,0,4} },
                {7, new int[] {0,8,6,9} },
                {8, new int[] {0,0,0,7} },
                {9, new int[] {14,7,0,10} },
                {10, new int[] {0,9,0,11} },
                {11, new int[] {12,10,0,0} },
                {12, new int[] {0,0,11,13} },
                {13, new int[] {0,12,0,0} },
                {14, new int[] {15,0,9,0} },
                {15, new int[] {0,16,14,0} },
                {16, new int[] {0,0,17,15} },
                {17, new int[] {16,0,0,0} }

            };
        }

		public void Update(GameTime gameTime, Game1 game)
		{
            // if (game.linkPos.Y > 300)
            
            if (game.controller[0].GetLinkPos().Y > 425)
            {
                char setter = 'u';
                Debug.WriteLine("Change room down");
                int[] x = myRooms[currentImageIndex];
                currentImageIndex = x[2];
                timer = delayTime;
                game.controller[0].SetLinkPos(new Vector2(375, 400));
                game.controller[0].setLink(setter);

            }

            if (game.controller[0].GetLinkPos().X > 725)
            {
                Debug.WriteLine("Change room right");
                int[] x = myRooms[currentImageIndex];
                currentImageIndex = x[3];
                timer = delayTime;
                game.controller[0].SetLinkPos(new Vector2(200, 400));
            }

            if (game.controller[0].GetLinkPos().X < 75)
            {
                Debug.WriteLine("Change room left");
                int[] x = myRooms[currentImageIndex];
                currentImageIndex = x[1];
                timer = delayTime;
                game.controller[0].SetLinkPos(new Vector2(200, 400));
            }

        }

        public void Draw(SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(room, new Rectangle(0, 0, game1.GraphicsDevice.Viewport.Width, game1.GraphicsDevice.Viewport.Height), rooms[currentImageIndex], cal);
        }
	}
}

