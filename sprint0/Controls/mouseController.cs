﻿//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Input;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sprint0
//{
//    internal class mouseController:Icontroller
//    {
//        private Game1 game;
//        float delayTime;
//        float timer;
//        public int currentImageIndex;
//        public mouseController(Game1 link) {
//            game = link;
//            currentImageIndex = 0;
//            delayTime = 500f;
//            timer = 0f;
//        }

//        public void Update(GameTime gameTime)
//        {

//            timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
//            if (timer <= 0f)
//            {
//                MouseState mouseState = Mouse.GetState();

//                if (mouseState.RightButton == ButtonState.Pressed)
//                {
//                    game.Exit();
//                }
//            }
//        }
//    }
//}
