using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace sprint0
{
    public class MouseController
    {
        public MouseController()
        {

        }

        public static bool CheckMouseStateLeft()
        {
            bool LeftMouse = false;

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                LeftMouse = true;
            }

            return LeftMouse;
        }



        public static bool CheckMouseStateRight()
        {
            bool RightMouse = false;

            if (Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                RightMouse = true;
            }

            return RightMouse;
        }

    }
}
