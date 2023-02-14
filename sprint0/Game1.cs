using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using sprint0;
using Vector2 = Microsoft.Xna.Framework.Vector2;
//using Microsoft.Xna.Framework.Net;
//using Microsoft.Xna.Framework.Storage;


namespace sprint0
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public Isprite sprite;
        public IHealthBar healthbar;
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[6];
        private Texture2D[] HealthBar = new Texture2D[4];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D spriteD;
        private Texture2D spriteX;
        private Texture2D zelda;
        private Texture2D health;
        private SpriteFont font;
        private bool facingDown;
        private bool facingUp;
        private bool facingRight;
        private bool facingLeft;
        private int press;
        public Vector2 pos;
        public Vector2 healthPos;
        private Isprite TextSprite;
        private Item item;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controller = new List<Icontroller>();
            controller.Add(new keyboardController(this));
            controller.Add(new mouseController(this));
            controller.Add(new HealthController(this));
            base.Initialize();
        }

        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteA = Content.Load<Texture2D>("alec");
            Animate[0] = spriteA;
            spriteB = Content.Load<Texture2D>("afrah");
            Animate[1] = spriteB;
            spriteC = Content.Load<Texture2D>("dawei");
            Animate[2] = spriteC;
            spriteD = Content.Load<Texture2D>("salma");
            Animate[3] = spriteD;
            zelda = Content.Load<Texture2D>("sprites-link");
            Animate[4] = zelda;
            spriteX = Content.Load<Texture2D>("nithish");
            Animate[5] = spriteX;
            health = Content.Load<Texture2D>("health");


            sprite = new RSprite(pos, facingDown, facingUp, facingRight, facingLeft);
            healthbar = new FullHealthbar(press);

            font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();

            item = new Item(zelda);

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            sprite.Update();

            foreach (Icontroller controller in controller)
            {
                controller.Update(gameTime);
            }
            item.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate, pos);

            healthbar.Draw(spriteBatch, health);

            TextSprite.Draw(spriteBatch, font);

            item.Draw(spriteBatch);



            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}