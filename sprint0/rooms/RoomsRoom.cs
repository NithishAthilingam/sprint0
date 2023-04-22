using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
    public class RoomsRoom : IRoom
    {
        Game1 game;

        public List<Ienemy> enemies = new List<Ienemy>();
        public List<IItem> items = new List<IItem>();
        public List<IBlock> blocks = new List<IBlock>();
        public Dictionary<int, Vector4> enemiesD = new Dictionary<int, Vector4>();
        public Dictionary<int, int> roomItem;

        public RoomsRoom(List<Ienemy> enemies, List<IBlock> blocks, List<IItem> item, Dictionary<int, Vector4> enemiesD,Dictionary<int,int>roomItem)
        {
            this.enemies = enemies;
            this.blocks = blocks;
            this.items = item;
            this.enemiesD = enemiesD;
            this.roomItem = roomItem;
        }
         
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Ienemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);
            }

            foreach (IBlock block in blocks)
            {
                block.Draw(spriteBatch);
            }

            foreach (IItem item in items)
            {
                item.Draw(spriteBatch);
            }
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            foreach (Ienemy enemy in enemies)
            {
                enemy.Update(gameTime, game);
            }

            foreach (IBlock block in blocks)
            {
                block.Update(gameTime,game);
            }

            foreach (IItem item in items)
            {
                item.Update(gameTime,game);
            }
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}