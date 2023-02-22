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
using sprint0.Content;
using sprint0.Items;
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
        public Isprite throwFire;
        public Ienemy enemy;
        public IShoot shoot;
        //public IItem itemProj;
        public IHealthBar healthbar;
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[8];
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

        public bool facingDown;
        public bool facingUp;
        public bool facingRight;
        public bool facingLeft;

        private char direc = 'd';
        private int characterFrame = 0;
        //private int press;
        public Vector2 pos;
        public Vector2 pos0;
        public Vector2 healthPos;
        private Isprite TextSprite;
        public Content.IShoot item;
        private Blocks blocks;
        private Projectiles projectiles;
        private keyboardController keyboardController;
        private DragonSprite1 DragonSprite1;

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
            pos = new Vector2(220, 100);

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
            spritesEnemies = Content.Load<Texture2D>("sprites-enemies");
            Animate[7] = spritesEnemies;
            //health = Content.Load<Texture2D>("health");
            b = Content.Load<Texture2D>("blocks2");
            spritesItems= Content.Load<Texture2D>("sprites-items");

            sprite = new RSprite(pos, direc);
            enemy = new DragonSprite1(new Vector2(550, 250));
            shoot = new initial();
            //enemy0 = new SkeletonSprite1(new Vector2(550, 250));
            font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();
            throwFire = new ThrowFire(pos, direc);
            item = new Item(zelda, spritesEnemies);
            blocks = new Blocks(b);
            projectiles = new Projectiles(this, spritesItems,pos,facingDown,facingUp,facingRight,facingLeft);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            sprite.Update(gameTime);
            throwFire.Update(gameTime);
            foreach (Icontroller controller in controller)
            {
                controller.Update(gameTime);
            }
            enemy.Update(gameTime);
            //enemy0.Update(gameTime);
            item.Update(gameTime);
            blocks.Update(gameTime);
            projectiles.Update(gameTime);
            shoot.Update(gameTime);

            //DragonSprite1.Update(gameTime);

           // Controller.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            sprite.Draw(spriteBatch, Animate, pos);
            throwFire.Draw(spriteBatch, Animate, pos);


            shoot.Draw(spriteBatch, Animate, pos);
            TextSprite.Draw(spriteBatch, font);

            enemy.Draw(spriteBatch, Animate, pos);
            //enemy0.Draw(spriteBatch, Animate, pos0);
            item.Draw(spriteBatch);
            blocks.Draw(spriteBatch);
            projectiles.Draw(spriteBatch);

            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
