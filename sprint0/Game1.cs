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
        public Ienemy enemy;
        public IHealthBar healthbar;
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[7];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D spriteD;
        private Texture2D spriteX;
        private Texture2D spriteBoss;
        private Texture2D zelda;
        //private Texture2D health;
        private Texture2D b;
        private Texture2D spritesEnemies;
        private Texture2D spritesItems;


        private SpriteFont font;
        private bool facingDown;
        private bool facingUp;
        private bool facingRight;
        private bool facingLeft;
        //private int press;
        public Vector2 pos;
        public Vector2 healthPos;
        private Isprite TextSprite;
        private Item item;
        private Blocks blocks;
        private Projectiles projectiles;
        //private keyboardController keyboardController;

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
            spriteBoss = Content.Load<Texture2D>("sprites-bosses");
            Animate[6] = spriteBoss;
            //health = Content.Load<Texture2D>("health");
            b = Content.Load<Texture2D>("blocks2");
            spritesEnemies= Content.Load<Texture2D>("sprites-enemies");
            spritesItems= Content.Load<Texture2D>("sprites-items");

            sprite = new RSprite(pos, facingDown, facingUp, facingRight, facingLeft);
            enemy = new DragonSprite1(pos);
            font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();

            item = new Item(zelda, spritesEnemies);
            blocks = new Blocks(b);
            projectiles = new Projectiles(this, spritesItems, spritesEnemies, new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2));

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

            enemy.Update(gameTime);
            item.Update(gameTime);
            blocks.Update(gameTime);
            projectiles.Update(gameTime);
            //keyboardController.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate, pos);
<<<<<<< HEAD
            healthbar.Draw(spriteBatch, health);
=======
>>>>>>> 6730054a71b21bd65df47834d86d67af7950d157

            TextSprite.Draw(spriteBatch, font);

            enemy.Draw(spriteBatch, Animate, pos);
            item.Draw(spriteBatch);
            blocks.Draw(spriteBatch);
            projectiles.Draw(spriteBatch);

            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
