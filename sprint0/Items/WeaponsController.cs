using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace sprint0.Items
{
	public class WeaponsController : Icontroller
	{
        private Game1 game;
        private char direc;
        public Vector2 pos;
        private float speed;
        Vector2 p;

        public WeaponsController(Game1 link, char dir)
		{
            game = link;
            speed = 200f;
            direc = dir;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.NumPad1) || userInput.IsKeyDown(Keys.D1))
            {

                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.shoot = new FlyingSwordDown(pos);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 20, pos.Y));
                    game.shoot = new FlyingSwordLeft(pos);

                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.shoot = new FlyingSwordUp(pos);

                }
                else if (direc == 'd')
                {
                    p.Y = pos.Y;
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.shoot = new FlyingSwordRight(pos);

                    p.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }
            else if (userInput.IsKeyDown(Keys.NumPad2) || userInput.IsKeyDown(Keys.D2))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.shoot = new GreenArrowDown(pos);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 20, pos.Y));
                    game.shoot = new GreenArrowLeft(pos);

                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.shoot = new GreenArrowUp(pos);

                }
                else if (direc == 'd')
                {
                    p.Y = pos.Y;
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.shoot = new GreenArrowRight(pos);

                    p.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }
            else if (userInput.IsKeyDown(Keys.NumPad4) || userInput.IsKeyDown(Keys.D4))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.throwFire = new ThrowFire(pos, direc);
                }
                else if (direc == 'd')
                {
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new ThrowFire(pos, direc);
                }
            }
            else if (userInput.IsKeyDown(Keys.NumPad3) || userInput.IsKeyDown(Keys.D3))
            {
                if (direc == 's')
                {
                    game.sprite = new ThrowingItemDown(pos);
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'a')
                {
                    game.sprite = new ThrowingItemLeft(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'w')
                {
                    game.sprite = new ThrowingItemUp(pos);
                    game.throwFire = new Bomb(pos, direc);
                }
                else if (direc == 'd')
                {
                    game.sprite = new ThrowingItemRight(new Vector2(pos.X - 15, pos.Y));
                    game.throwFire = new Bomb(pos, direc);
                }
            }
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

