using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace sprint0
{
    internal class HealthController : Icontroller
    {
        private Game1 game;
        public int pressed;
        public HealthController(Game1 link, int press)
        {
            game = link;
            pressed = press;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            game.healthbar = new FullHealthbar(pressed);
            
        

        }

        public Vector2 GetLinkPos()
        {
            throw new NotImplementedException();
        }

        public void SetLinkPos(Vector2 newPos)
        {
            throw new NotImplementedException();
        }

        public void ModifyLinkPos(Vector2 mod)
        {
            throw new NotImplementedException();
        }
        public void setLink(char setter)
        {
            throw new NotImplementedException();
        }

    }
}