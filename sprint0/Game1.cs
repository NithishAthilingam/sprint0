using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using sprint0;
using sprint0.Collision;
using sprint0.Content;
using sprint0.Interfaces;
using sprint0.Items;
using sprint0.HealthBar;
using sprint0.Sound;
using static System.Formats.Asn1.AsnWriter;
using Vector2 = Microsoft.Xna.Framework.Vector2;

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
        public ICollision collide;
        public ICollision collideA;
        public List<Icontroller> controller;
        private Texture2D[] Animate = new Texture2D[16];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D spriteD;
        private Texture2D spriteX;
        private Texture2D spriteBoss;
        private Texture2D zelda;
        private Texture2D nes;
        private Texture2D room;
        public int healthNum;

        private Texture2D health;

        private MouseController MouseController;

        private Texture2D dungeon;

        public Vector2 linkPos;
        public Rectangle linkBound;
        public Vector2 EnemyPos;

        //RenderTarget2D renderTarget;
        //Rectangle des1;
        //Rectangle des2;

        private Texture2D deathEffect;
        private Texture2D boomerang;
        private Texture2D b;
        private Texture2D spritesEnemies;
        private Texture2D spritesItems;
        private ItemFactory itemFactory;
        private Key key;
        private Rectangle banana;

        //private float angle;
        //private float scale;

        //private SpriteFont font;

        public bool facingDown;
        public bool facingUp;
        public bool facingRight;
        public bool facingLeft;

        private char direc = 'd';
        public Vector2 pos;
        public Vector2 pos0;
        public Vector2 healthPos;
        private Isprite TextSprite;
        public Content.IShoot items;
        public Item item;
        private Blocks blocks;
        private Projectiles projectiles;
        private keyboardController keyboardController;
        private DoorCollision doorEnter;
        RoomsRoom roomsroom;
        IRoom currentRoom;
        int currentRoomIndex;

        //public List<Ienemy> enemiesList = new List<Ienemy>();
        //public List<IItem> itemsList = new List<IItem>();
        //public List<IBlock> blocksList = new List<IBlock>();


        List<RoomsRoom> ListOfRooms = new List<RoomsRoom>();
       // RoomsRoom currentRoom;

        private Song backgroundMusic;
        private SoundClass sound;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controller = new List<Icontroller>();
            controller.Add(new keyboardController(Animate[7], Animate[6], this));
            pos = new Vector2(220, 100);
            healthNum = 6;
            healthbar = new Health(healthNum);


            base.Initialize();

            //int blockPosition1 = 45;
            //int blockPosition2 = 47;
            //Vector2 blockPos = new Vector2(blockPosition1, blockPosition2);
            //IBlock newBlock = BlockFactory.Instance.GetBlock(Animate[8], 1, blockPos);
            //blocksList.Add(newBlock);

            //roomsroom = new RoomsRoom(enemiesList, blocksList, itemsList);


            for (int i = 1; i < 4; i++)
            {
                string path = $"rooms/r{i}.xml";
                RoomGenerator roomGenerator = new RoomGenerator(path);
                RoomsRoom c = roomGenerator.GenerateRooms(Animate[7], Animate[6], Animate[4], Animate[9], Animate[12], Animate[11], Animate[8], Animate[14]);
                ListOfRooms.Add(c);


                //RoomsRoom roomsroom = new RoomsRoom(this);
                //roomsroom.enemies = roomGenerator.enemies;
                //roomsroom.items = roomGenerator.items;
                //roomsroom.blocks = roomGenerator.blocks;
                //ListOfRooms.Add(roomsroom);

            }

            // set the current room to the first room in the list
            //currentRoom = ListOfRooms[0];
             currentRoom = ListOfRooms[0];
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
            spritesItems = Content.Load<Texture2D>("sprites-items");
            deathEffect = Content.Load<Texture2D>("death-effects");
            nes = Content.Load<Texture2D>("NES - The Legend of Zelda - Items & Weapons");
            boomerang = Content.Load<Texture2D>("boomerang");

            dungeon = Content.Load<Texture2D>("Dungeon");
            Animate[14] = dungeon;

            Animate[8] = b;

            Animate[9] = spritesItems;

            Animate[10] = deathEffect;

            Animate[11] = boomerang;

            Animate[12] = spritesEnemies;
            EnemyPos = new Vector2(550, 250);
            sprite = new RSprite(pos, direc);

            enemy = new DragonSprite1(Animate[7], Animate[6], new Vector2(550, 250));
            //enemy = new DragonSprite1(EnemyPos);
            enemy = new DragonSprite1(Animate[7], Animate[6],new Vector2(550, 250));
            enemy = new DragonSprite1(EnemyPos);

            shoot = new initial();
            collide = new BlockCollision();
            collideA = new EnemyLinkCollision();
            MouseController = new MouseController();

            linkBound = new Rectangle((int)linkPos.X, (int)linkPos.Y, 50, 50);

            room = Content.Load<Texture2D>("rooms");
            Animate[13] = boomerang;

            // health = Content.Load<Texture2D>("Hearts");


           // health = Content.Load<Texture2D>("Hearts");


            health = Content.Load<Texture2D>("HealthHearts");
            Animate[15] = health;


            rooms = new Rooms(dungeon, this);
            doorEnter = new DoorCollision(dungeon, this);


            //font = Content.Load<SpriteFont>("Score");
            TextSprite = new TextSprite();

            item = new Item(zelda, spritesEnemies, spritesItems);


            throwFire = new InitialFire();
            // item = new Item(zelda, spritesEnemies, spritesItems);
            blocks = new Blocks(b, dungeon);
            projectiles = new Projectiles(this, spritesItems, pos, direc);

            backgroundMusic = Content.Load<Song>("dungeonmusic");
            MediaPlayer.Play(backgroundMusic);
            MediaPlayer.IsRepeating = true;
            MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChanged;
        }

        private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
        {
            MediaPlayer.Volume -= 0.1f;
            MediaPlayer.Play(backgroundMusic);
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

            currentRoom = ListOfRooms[doorEnter.currentImageIndex];
            currentRoom.Update(gameTime, this);



            currentRoom = ListOfRooms[doorEnter.currentImageIndex];
            currentRoom.Update(gameTime, this);

            // roomsroom.Update(gameTime, this);

            enemy.Update(gameTime, this);
            rooms.Update(gameTime);
            doorEnter.Update(gameTime, this);

            //ListOfRooms[0].Update(gameTime, this);
            //ListOfRooms[1].Update(gameTime, this);
            //ListOfRooms[2].Update(gameTime, this);

            //currentRoom.Update(gameTime, this);

            item.Update(gameTime);
            blocks.Update(gameTime);
            projectiles.Update(gameTime);
            shoot.Update(gameTime);
            collide.Update(gameTime, this);
            collideA.Update(gameTime, this);
            MouseController.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            banana = new Rectangle(128, 0, 7, 10);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            // roomsroom.Draw(spriteBatch);

            //  rooms.Draw(spriteBatch);
            doorEnter.Draw(spriteBatch);


            throwFire.Draw(spriteBatch, Animate, pos);

            healthbar.Draw(spriteBatch, health);

            //angle = (float)Math.PI / 2.0f;  // 90 degrees
            //scale = 1.0f;

            //  shoot.Draw(spriteBatch, Animate, pos);
            //TextSprite.Draw(spriteBatch, font);

            // enemy.Draw(spriteBatch, Animate, pos);



            //ListOfRooms[0].Draw(spriteBatch);
            //ListOfRooms[1].Draw(spriteBatch);
            //ListOfRooms[2].Draw(spriteBatch);


            currentRoom.Draw(spriteBatch);
            //item.Draw(spriteBatch);
            blocks.Draw(spriteBatch);
            //projectiles.Draw(spriteBatch);

            sprite.Draw(spriteBatch, Animate, pos);



            spriteBatch.End();

            base.Draw(gameTime);


        }
    }
}