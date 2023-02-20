using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
#pragma warning disable CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace
using Microsoft.Xna.Framework.Graphics;
#pragma warning restore CS0105 // The using directive for 'Microsoft.Xna.Framework.Graphics' appeared previously in this namespace

namespace sprint0
{
    public class RSprite : Isprite
    {
        public Vector2 thisPos;
        public char direc;
        public RSprite(Vector2 posi, char direction)
        {
            thisPos = posi;
            direc = direction;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D[] AnimationType, Vector2 pos)
        {
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            pos = thisPos;
            if (direc == 's')
            {
                source1 = new Rectangle(0, 0, 20, 20);
            }
            else if (direc == 'w')
            {
                source1 = new Rectangle(60, 30, 20, 20);
            }
            else if (direc == 'd')
            {
                source1 = new Rectangle(90, 30, 20, 20);
            }
            else if (direc == 'a')
            {
                source1 = new Rectangle(30, 0, 20, 20);
            }
            else
            {
                source1 = new Rectangle(0, 0, 20, 20);
            }
            

            spriteBatch.Draw(AnimationType[4],pos, source1, Color.White,0,new Vector2(0,0),new Vector2(3,3),0,0);


        }

    }
}
