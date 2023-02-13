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
        private Texture2D zelda;
        private Texture2D charcater;
        private int currentFrame = 0;
        private int totalFrames = 10;
        private Vector2 location = new Vector2(220, 100);
        //:))))
        private SpriteFont font;
        private Isprite TextSprite;
        Rectangle[] recs;
        int currentA;
        int previousA;
        float s;
        float speed;
        float timer;
        Vector2 p;






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
            zelda = Content.Load<Texture2D>("sprites-link");

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

            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);
            Rectangle source1 = new Rectangle(0, 0, 20, 20);
            Rectangle dest1 = new Rectangle(100, 100, 40, 40);

            Rectangle source2 = new Rectangle(0, 1, 20, 20);
            Rectangle dest2 = new Rectangle(100, 100, 40, 40);

            previousA = 1;
            currentA = 2;
            timer = 0;
            s = 2.0f;
            speed = 200;


            recs[0] = new Rectangle(0, 0, 20, 20);
            recs[1] = new Rectangle(0, 1, 20, 20);

            //middle 2
            //left 0
            //right 1


            p = new Vector2(0, GraphicsDevice.Viewport.Height / 2 + 1);


            if (timer> speed)
            {
                if(currentA == 2)
                {
                    if(previousA == 0)
                    {
                        currentA = 1;
                    }
                    else
                    {
                        currentA = 0;

                    }
                    previousA = currentA;
                }
                else{
                    currentA = 2;
                }
                timer = 0;
            }
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            }

            p.X += s;
            if (p.X > GraphicsDevice.Viewport.Width)
            {
                p.X = 0;
                p.Y = GraphicsDevice.Viewport.Height / 2;
            }

            spriteBatch.Begin();

            spriteBatch.Draw(zelda, p, recs[currentA], Color.White);

            //sprite.Draw(spriteBatch, Animate);

            TextSprite.Draw(spriteBatch, font);

            if (currentFrame == 0)
            {
                spriteBatch.Draw(zelda, dest1, source1, Color.White);
            }
            else if (currentFrame == 5)
            {
                spriteBatch.Draw(zelda, dest2, source2, Color.White);
            }
            spriteBatch.Draw(zelda, dest1, source1, Color.White);




            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}