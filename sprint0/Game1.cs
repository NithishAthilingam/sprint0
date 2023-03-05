using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
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
using static System.Formats.Asn1.AsnWriter;
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
        public Rooms rooms;
        public IHealthBar healthbar;
        private List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[14];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D spriteD;
        private Texture2D spriteX;
        private Texture2D spriteBoss;
        private Texture2D zelda;
        private Texture2D nes;
        private Texture2D room;
<<<<<<< HEAD
      

=======
        public Vector2 linkPos;
        public Vector2 DragonPos;
        RenderTarget2D renderTarget;
        Rectangle des1;
        Rectangle des2;
>>>>>>> 1c1c8f78905f0019505621ce346210b11c5f5913




        private Texture2D deathEffect;
        private Texture2D boomerang;
        private Texture2D b;
        private Texture2D spritesEnemies;
        private Texture2D spritesItems;

        private Rectangle banana;

        private float angle;
        private float scale;


        private SpriteFont font;

        public bool facingDown;
        public bool facingUp;
        public bool facingRight;
        public bool facingLeft;

        private char direc = 'd';
        //private int press;
        public Vector2 pos;
        public Vector2 pos0;
        public Vector2 healthPos;
        private Isprite TextSprite;
        public Content.IShoot item;
        private Blocks blocks;
        private Projectiles projectiles;
        private keyboardController keyboardController;

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
            b = Content.Load<Texture2D>("blocks2");
            spritesItems= Content.Load<Texture2D>("sprites-items");
            deathEffect = Content.Load<Texture2D>("death-effects");
            nes = Content.Load<Texture2D>("NES - The Legend of Zelda - Items & Weapons");
            boomerang = Content.Load<Texture2D>("boomerang");

          
            Animate[8] = b;

            Animate[9] = spritesItems;

            Animate[10] = deathEffect;

            Animate[11] = boomerang;

            Animate[12] = spritesEnemies;

            sprite = new RSprite(pos, direc);
            enemy = new DragonSprite1(new Vector2(550, 250));
            shoot = new initial();

            room = Content.Load<Texture2D>("rooms");
            Animate[13] = boomerang;




            rooms = new Rooms(room,this);


            font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();

            item = new Item(zelda, spritesEnemies, spritesItems);

            throwFire = new InitialFire();
           // item = new Item(zelda, spritesEnemies, spritesItems);
            blocks = new Blocks(b);
            projectiles = new Projectiles(this, spritesItems,pos,direc);
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
            enemy.Update(gameTime, this);

            item.Update(gameTime);
            blocks.Update(gameTime);
            projectiles.Update(gameTime);
            shoot.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            banana = new Rectangle(128, 0, 7, 10);

            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            
            sprite.Draw(spriteBatch, Animate, pos);
            throwFire.Draw(spriteBatch, Animate, pos);

            angle = (float)Math.PI / 2.0f;  // 90 degrees
            scale = 1.0f;

            shoot.Draw(spriteBatch, Animate, pos);
            TextSprite.Draw(spriteBatch, font);

            enemy.Draw(spriteBatch, Animate, pos);

            item.Draw(spriteBatch);
            blocks.Draw(spriteBatch);
            projectiles.Draw(spriteBatch);
            rooms.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);


        }
    }
}
