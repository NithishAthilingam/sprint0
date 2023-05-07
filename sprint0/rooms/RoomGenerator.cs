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
        public Dictionary<int, int[]> enemiesD;
        public Dictionary<int, Vector4> blocksD;
        public Dictionary<int, int> roomItem;
        private int i = 0;
        private int j = 0;
        private int enemyWidth = 0;
        private int enemyHeight = 0;
        private int enemyHealth = 1;


        public RoomGenerator(string fileName)
        {
            file = fileName;

        }

        public RoomsRoom GenerateRooms(Texture2D enemiesSprite, Texture2D enemiesSprite2, Texture2D itemsSprite, Texture2D ladySprite, Texture2D fireSprite, Texture2D boom, Texture2D blockSprite, Texture2D blockRoom)
        {
            enemies = new List<Ienemy>();
            items = new List<IItem>();
            blocks = new List<IBlock>();
            enemiesD = new Dictionary<int, int[]>();
            roomItem = new Dictionary<int, int>();
            blocksD = new Dictionary<int, Vector4>();
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
                                    j++;
                                    blocksD.Add(j, new Vector4(blockPosition1, blockPosition2, 1, 1));
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
                                    if (roomItem.ContainsKey(itemVersion))
                                    {
                                        roomItem[itemVersion] = roomItem[itemVersion] + 1;
                                    }
                                    else
                                    {
                                        roomItem.Add(itemVersion, 1);
                                    }
                                Console.WriteLine("item : " + itemVersion.ToString() + "itemX:" + itemPosition1.ToString() + "itemY:" + itemPosition2.ToString());
                                break;

                                case "Enemy":
                                    reader.ReadToFollowing("type");
                                    int enemyVersion = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("x");
                                    int enemyPosition1 = int.Parse(reader.ReadElementContentAsString());
                                    reader.ReadToFollowing("y");
                                    int enemyPosition2 = int.Parse(reader.ReadElementContentAsString());
                                    i++;
                                    Ienemy newEnemy = EnemiesFactor.Instance.CreateEnemy(enemiesSprite, enemiesSprite2, enemyVersion, new Vector2(enemyPosition1, enemyPosition2), i);
                                    enemies.Add(newEnemy);
                                if (enemyVersion == 3) { enemyHealth = 5; }
                                else if (enemyVersion == 4) { enemyHealth = 2; }
                                else { enemyHealth = 1; }
                                    enemiesD.Add(i, new int[] { enemyPosition1, enemyPosition2, enemyWidth, enemyHeight, enemyVersion, enemyHealth });

                                Console.WriteLine("enemy : " + enemyVersion.ToString() + "enemyX:" + enemyPosition1.ToString() + "enemyY:" + enemyPosition2.ToString());
                                    break;
                            }
                        }
                    }
                }

                return new RoomsRoom(enemies, blocks, items, enemiesD, blocksD, roomItem);
            }
        }
    }
