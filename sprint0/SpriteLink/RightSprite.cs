using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;
#pragma warning disable CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace
using Microsoft.Xna.Framework.Graphics;
using sprint0.Content;
using Microsoft.Xna.Framework.Input;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
#pragma warning restore CS0105

namespace sprint0
{
    public class RightSprite : Isprite
    {
        public Vector2 thisPos;
        public Rectangle[] run;
        private int frames = 0;

        private Texture2D z;
        private Texture2D f;
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

        public RightSprite(Vector2 posi)
        {

            thisPos = posi;

            delayTime = 500f;
            timer = 0f;

            previousA = 1;
            currentA = 0;
            tt = 0;
            speed = 50;


            middle = 2;
            left = 0;
            right = 1;

            run = new Rectangle[2];

            run[0] = new Rectangle(90, 0, 20, 20);
            run[1] = new Rectangle(90, 30, 30, 30);

        }

        private int currentFrame = 0;
        private int totalFrames = 45;
        private Vector2 location = new Vector2(220, 100);




        public void Update(GameTime gameTime)
        {
            frames++;

            if (frames <= 20)
            {
                currentA = 1;
            }
            else if (frames <= 40)
            {
                currentA = 0;
            }
            if (frames == 41)
            {
                frames = 0;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            pos = thisPos;
            Rectangle source2 = new Rectangle(90, 0, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 50, 50);
            spriteBatch.Draw(AnimationType[4], pos, run[currentA], Color.White, 0, new Vector2(0, 0), new Vector2(3, 3), 0, 0);

        }
    }
    
}

