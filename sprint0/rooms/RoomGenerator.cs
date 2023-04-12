using System;
using sprint0.Content;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static System.Reflection.Metadata.BlobBuilder;
using MonoGame.Framework.Utilities.Deflate;

namespace sprint0
{
    public class RoomGenerator
    {
        private string file;
        public List<Ienemy> enemies = new List<Ienemy>();
        public List<IItem> items = new List<IItem>();
        public List<IBlock> blocks = new List<IBlock>();


        public RoomGenerator(string fileName)
        {
            file = fileName;

        }

        public RoomsRoom GenerateRooms(Texture2D enemiesSprite, Texture2D enemiesSprite2, Texture2D itemsSprite, Texture2D ladySprite, Texture2D fireSprite, Texture2D boom, Texture2D blockSprite, Texture2D blockRoom)
        {
            enemies = new List<Ienemy>();
            items = new List<IItem>();
            blocks = new List<IBlock>();

            using (XmlReader reader = XmlReader.Create(file))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement() && reader.Name == "description")
                    {
                        reader.Read();
                            
                            switch (reader.Value.Trim())
                            {
                                case "Block":
                                    reader.ReadToFollowing("type");
                                    int blockVersion = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("x");
                                    int blockPosition1 = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("y");
                                    int blockPosition2 = int.Parse(reader.ReadElementContentAsString());
                                    IBlock newBlock = BlockFactory.Instance.GetBlock(blockSprite, blockRoom, blockVersion, new Vector2(blockPosition1, blockPosition2));
                                    blocks.Add(newBlock);
                                    Console.WriteLine("block : " + blockVersion.ToString() + "blockX:" + blockPosition1.ToString() + "blockY:"  + blockPosition2.ToString());
                                    break;

                                case "Item":
                                    reader.ReadToFollowing("type");
                                    int itemVersion = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("x");
                                    int itemPosition1 = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("y");
                                    int itemPosition2 = int.Parse(reader.ReadElementContentAsString());
                                    IItem newItem = ItemFactory.Instance.CreateItem(itemsSprite, ladySprite, fireSprite, boom, itemVersion, new Vector2(itemPosition1, itemPosition2));
                                    items.Add(newItem);
                                Console.WriteLine("item : " + itemVersion.ToString() + "itemX:" + itemPosition1.ToString() + "itemY:" + itemPosition2.ToString());
                                break;

                                case "Enemy":
                                    reader.ReadToFollowing("type");
                                    int enemyVersion = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("x");
                                    int enemyPosition1 = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("y");
                                    int enemyPosition2 = int.Parse(reader.ReadElementContentAsString());
                                    Ienemy newEnemy = EnemiesFactor.Instance.CreateEnemy(enemiesSprite, enemiesSprite2, enemyVersion, new Vector2(enemyPosition1, enemyPosition2));
                                    enemies.Add(newEnemy);
                                    Console.WriteLine("enemy : " + enemyVersion.ToString() + "enemyX:" + enemyPosition1.ToString() + "enemyY:" + enemyPosition2.ToString());
                                    break;
                            }
                        }
                    }
                }

                return new RoomsRoom(enemies, blocks, items);
            }
        }
    }
