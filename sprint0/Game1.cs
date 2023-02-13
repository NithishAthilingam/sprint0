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
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[5];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D zelda;
        private SpriteFont font;
        public Vector2 pos;
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
            zelda = Content.Load<Texture2D>("sprites-link");
            Animate[4] = zelda;
            sprite = new RSprite(pos);

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
                controller.Update(gameTime);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate, pos);

            TextSprite.Draw(spriteBatch, font);



            //vector = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);

            Rectangle r = new Rectangle(300, 185, 30, 30);

            Rectangle c = new Rectangle(270, 225, 30, 30);

            Rectangle b = new Rectangle(230, 225, 30, 30);
            Rectangle j = new Rectangle(230, 185, 30, 30);
            Rectangle jj = new Rectangle(350, 275, 30, 30);
            Rectangle jl = new Rectangle(325, 275, 30, 30);

            Rectangle jm = new Rectangle(260, 185, 30, 30);
            
            Rectangle jf = new Rectangle(270, 250, 30, 30);

            Rectangle f = new Rectangle(350, 250, 30, 30);

            Rectangle ff = new Rectangle(375, 250, 30, 30);

            Rectangle rr = new Rectangle(380, 160, 30, 30);

            Rectangle rs = new Rectangle(415, 250, 16, 30);








            //heart w/ boarder
            //  spriteBatch.Draw(zelda, vector, r, Color.White);
            //blue dimond
            // spriteBatch.Draw(zelda, vector, c, Color.White);
            //yellow dimond
            // spriteBatch.Draw(zelda, vector, b, Color.White);
            //heart
            //spriteBatch.Draw(zelda, vector, j, Color.White);
            //blue triangle
            // spriteBatch.Draw(zelda, vector, jj, Color.White);
            //yelow triangle
            //spriteBatch.Draw(zelda, vector, jl, Color.White);
            //blue heart
            //spriteBatch.Draw(zelda, vector, jm, Color.White);
            //chocolate bar
            // spriteBatch.Draw(zelda, vector, jf, Color.White);
            //key
            //spriteBatch.Draw(zelda, vector, f, Color.White);
            //can thing
            //spriteBatch.Draw(zelda, vector, ff, Color.White);
            //clock
            //spriteBatch.Draw(zelda, vector, rr, Color.White);
            //arrow
            //spriteBatch.Draw(zelda, vector, rs, Color.White);


            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}