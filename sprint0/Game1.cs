using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
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
using static System.Formats.Asn1.AsnWriter;
using Vector2 = Microsoft.Xna.Framework.Vector2;
using System.Threading;
using sprint0.Sound;

namespace sprint0
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public Isprite sprite;
        public Isprite throwFire;
        public Ienemy enemy;
        public Content.IShoot shoot;
        public IDisplay healthbar;
        public IDisplay keys;
        public ICollision collide;
        public ICollision collideA;
        public ICollision collideB;
        public ICollision collideC;
        public List<Icontroller> controller;
        public Texture2D[] Animate = new Texture2D[18];
        private Texture2D spriteA;
        private Texture2D spriteB;
        private Texture2D spriteC;
        private Texture2D spriteD;
        private Texture2D spriteX;
        private Texture2D spriteBoss;
        private Texture2D zelda;
        private Texture2D nes;
        private Texture2D room;
        private KeyboardState user;
        private KeyboardState prev;
        public int healthNum;

        private Texture2D health;

        private MouseController MouseController;

        private Texture2D dungeon;

        public Vector2 linkPos;
        public Vector2 EnemyPos;

        private Texture2D deathEffect;
        private Texture2D boomerang;
        private Texture2D b;
        private Texture2D spritesEnemies;
        private Texture2D spritesItems;

        private Rectangle banana;

        public bool facingDown;
        public bool facingUp;
        public bool facingRight;
        public bool facingLeft;

        private char direc = 'd';
        public Vector2 pos;
        public Vector2 pos0;
        public Vector2 healthPos;
        public Dictionary<int, int> inventory = new Dictionary<int,int>();
        private Isprite TextSprite;
        public Content.IShoot items;
        private Projectiles projectiles;
        private DoorCollision doorEnter;
        public RoomsRoom currentRoomsRoom;
        public String keyCountInventory;
        IRoom currentRoom;
        public List<RoomsRoom> ListOfRooms = new List<RoomsRoom>();

        private Song backgroundMusic;
        private Texture2D victory;
        private Texture2D gameover;
        private SpriteFont pause;
        private SpriteFont keyCount;

        private Texture2D linktri;
        public PlaySoundEffects soundEffects;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            user = Keyboard.GetState();
            prev = user;
            controller = new List<Icontroller>();
            controller.Add(new keyboardController(Animate[7], Animate[6], this));
            pos = new Vector2(220, 100);
            healthNum = 6;
            healthbar = new Health(healthNum);
            keys = new InventoryKey();
            soundEffects = new PlaySoundEffects(Content);
            base.Initialize();

            for (int i = 1; i < 18; i++)
            {
                string path = $"rooms/r{i}.xml";
                RoomGenerator roomGenerator = new RoomGenerator(path);
                RoomsRoom c = roomGenerator.GenerateRooms(Animate[7], Animate[6], Animate[4], Animate[9], Animate[12], Animate[11], Animate[8], Animate[14]);
                ListOfRooms.Add(c);
            }

            // set the current room to the first room in the list
            currentRoomsRoom = ListOfRooms[0];

        }



        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            pause = Content.Load<SpriteFont>("paused");
            keyCount = Content.Load<SpriteFont>("key");

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
            gameover = Content.Load<Texture2D>("gameover");
            dungeon = Content.Load<Texture2D>("Dungeon");
            Animate[14] = dungeon;

            Animate[8] = b;

            Animate[9] = spritesItems;

            Animate[10] = deathEffect;

            Animate[11] = boomerang;
            linktri = Content.Load<Texture2D>("linktriforce");
            Animate[12] = spritesEnemies;
            EnemyPos = new Vector2(550, 250);
            sprite = new RSprite(pos, direc);
            enemy = new DragonSprite1(EnemyPos);
            shoot = new initial();
            collide = new BlockCollision();
            collideA = new EnemyLinkCollision();
            collideB = new EnemyBlockCollision();
            collideC = new SwordLinkCollision();
            MouseController = new MouseController();

            room = Content.Load<Texture2D>("rooms");
            Animate[13] = boomerang;

            health = Content.Load<Texture2D>("HealthHearts");
            Animate[15] = health;

            victory = Content.Load<Texture2D>("victory");
            Animate[16] = victory;
            Animate[17] = room;

            doorEnter = new DoorCollision(dungeon, this);

            TextSprite = new TextSprite();

            throwFire = new InitialFire();

            projectiles = new Projectiles(this, spritesItems, pos, direc);
            backgroundMusic = Content.Load<Song>("dungeonmusic");
            MediaPlayer.Play(backgroundMusic);
            MediaPlayer.IsRepeating = true;
            MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChanged;
            soundEffects.LoadContent();
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
            

            currentRoomsRoom = (RoomsRoom)currentRoom;
            //Access currentRoomsRoom's blocks list
            List<IBlock> currentBlocks = currentRoomsRoom.blocks;
            //Access currentRoomsRoom's enemies list
            List<Ienemy> currentEnemies = currentRoomsRoom.enemies;
            //Access currentRoomsRoom's items list
            List<IItem> currentItems = currentRoomsRoom.items;

            enemy.Update(gameTime, this);
            doorEnter.Update(gameTime, this);
            projectiles.Update(gameTime);
            shoot.Update(gameTime);
            collide.Update(gameTime, this, currentRoomsRoom, 1);
            collideA.Update(gameTime, this, currentRoomsRoom, 1);
            healthbar = new Health(healthNum);
            MouseController.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            banana = new Rectangle(128, 0, 7, 10);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            doorEnter.Draw(spriteBatch);
            doorEnter.DrawOpenDoor(spriteBatch);
            throwFire.Draw(spriteBatch, Animate, pos);

            currentRoomsRoom.Draw(spriteBatch);

            shoot.Draw(spriteBatch, Animate, pos);

            projectiles.Draw(spriteBatch);

            sprite.Draw(spriteBatch, Animate, pos);

            doorEnter.DrawFade(spriteBatch);
            healthbar.Draw(spriteBatch, health);
            keys.Draw(spriteBatch, zelda);
            
            spriteBatch.DrawString(keyCount, "x " + keyCountInventory, new Vector2(750,30), Color.White);
            if (Keyboard.GetState().GetPressedKeys().Contains(Keys.RightShift) || GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Start))
            {
                //spriteBatch.DrawString(pause, );
            }

            if (healthNum == 0)
            {  
                spriteBatch.Draw(gameover, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
                soundEffects.LinkDeath();
            }
            if (inventory.ContainsKey(10))
            {
                spriteBatch.Draw(victory, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
                spriteBatch.Draw(linktri, new Rectangle(350, 140, 35, 40), Color.White);

            }
            spriteBatch.End();

            base.Draw(gameTime);


        }
    }
}