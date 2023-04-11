using System;
using sprint0.Content;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0
{
    public class RoomGenerator
    {
        private string file;
        private List<IRoom> rooms = new List<IRoom>();
        public List<Ienemy> enemies = new List<Ienemy>();
        public List<IItem> items = new List<IItem>();
        public List<IBlock> blocks = new List<IBlock>();

        public RoomGenerator(string fileName)
        {
            file = fileName;
        }

        public void GenerateRooms(Texture2D enemiesSprite, Texture2D enemiesSprite2, Texture2D itemsSprite, Texture2D ladySprite, Texture2D fireSprite, Texture2D boom, Texture2D blockSprite)
        {
    //        XmlDocument xmlDoc = new XmlDocument();
    //        xmlDoc.Load(file);

    //        foreach (XmlNode roomNode in xmlDoc.DocumentElement.ChildNodes)
    //        {

    //            foreach (XmlNode node in roomNode.ChildNodes)
    //            {
    //                switch (node.SelectSingleNode("description").InnerText)
    //                {
    //                    case "Block":
    //                        int version1 = int.Parse(node.SelectSingleNode("type").InnerText);
    //                        string[] position1 = node.SelectSingleNode("position").InnerText.Split(' ');
    //                        int x1 = int.Parse(position1[0]);
    //                        int y1 = int.Parse(position1[1]);
    //                        Vector2 blockPos = new Vector2(x1, y1);
    //                        IBlock Newblock = BlockFactory.Instance.GetBlock(blockSprite,version1, blockPos);
    //                        blocks.Add(Newblock);
    //                        break;

    //                    case "Item":
    //                        int version2 = int.Parse(node.SelectSingleNode("type").InnerText);
    //                        string[] position2 = node.SelectSingleNode("position").InnerText.Split(' ');
    //                        int x2 = int.Parse(position2[0]);
    //                        int y2 = int.Parse(position2[1]);
    //                        Vector2 itemPos = new Vector2(x2, y2);
    //                        IItem Newitem = ItemFactory.Instance.CreateItem(itemsSprite, ladySprite, fireSprite, boom,version2, itemPos);
    //                        items.Add(Newitem);
    //                        break;

    //                    case "Enemy":
    //                        int version3 = int.Parse(node.SelectSingleNode("type").InnerText);
    //                        string[] position3 = node.SelectSingleNode("position").InnerText.Split(' ');
    //                        int x3 = int.Parse(position3[0]);
    //                        int y3 = int.Parse(position3[1]);
    //                        Vector2 enemyPos = new Vector2(x3, y3);
    //                        Ienemy Newenemy = EnemiesFactor.Instance.CreateEnemy(enemiesSprite, enemiesSprite2,version3, enemyPos);
    //                        enemies.Add(Newenemy);
    //                        break;
    //                }
    //            }
    //        }
        }
    }
}