using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace sprint0
{
    public class MouseController
    {
        int rectangleXLeft, rectangleYLeft,rectangleWidthLeft,rectangleHeightLeft;
        int rectangleXRight, rectangleYRight, rectangleWidthRight, rectangleHeightRight;
        int rectangleXTop, rectangleYTop, rectangleWidthTop, rectangleHeightTop;
        int rectangleXBottom, rectangleYBottom, rectangleWidthBottom, rectangleHeightBottom;
        Rectangle top,bottom,left, right;
        Point mousePosition;


        Rectangle rectangle;

        public MouseController()
        {
            mousePosition = new Point(Mouse.GetState().X, Mouse.GetState().Y);

            rectangleXTop = 348;
            rectangleYTop = 34;
            rectangleWidthTop = 101;
            rectangleHeightTop = 54;

            top = new Rectangle(rectangleXTop, rectangleYTop, rectangleWidthTop, rectangleHeightTop);

            rectangleXBottom = 348;
            rectangleYBottom = 41;
            rectangleWidthBottom = 106;
            rectangleHeightBottom = 66;

            bottom = new Rectangle(rectangleXBottom, rectangleYBottom, rectangleWidthBottom, rectangleHeightBottom);

            rectangleXLeft = 35;
            rectangleYLeft = 200;
            rectangleWidthLeft = 63;
            rectangleHeightLeft = 99;

            left = new Rectangle(rectangleXLeft, rectangleYLeft, rectangleWidthLeft, rectangleHeightLeft);


            rectangleXRight = 756;
            rectangleYRight = 204;
            rectangleWidthRight = 62;
            rectangleHeightRight = 95;

            right = new Rectangle(rectangleXRight, rectangleYRight, rectangleWidthRight, rectangleHeightRight);


        }
        public void Update(GameTime gameTime)
        {
            MouseController.CheckMouseStateRight();
            MouseController.CheckMouseStateLeft();

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
