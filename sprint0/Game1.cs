using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using sprint0;
//using Microsoft.Xna.Framework.Net;
//using Microsoft.Xna.Framework.Storage;


namespace sprint0
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public Isprite sprite;
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[4];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        //hello testing to see if i can commit
        
        //:))))
        private SpriteFont font;
        private Isprite TextSprite;

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
            base.Initialize();
        }

        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteA = Content.Load<Texture2D>("a");
            Animate[0] = spriteA;
            spriteB = Content.Load<Texture2D>("b");
            Animate[1] = spriteB;
            spriteC = Content.Load<Texture2D>("c");
            Animate[2] = spriteC;
            spriteC = Content.Load<Texture2D>("d");
            Animate[3] = spriteC;
            sprite = new RSprite();

            font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();

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
                controller.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate);

            TextSprite.Draw(spriteBatch, font);

            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}