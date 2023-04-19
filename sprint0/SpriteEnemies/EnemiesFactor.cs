using System;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Reflection;

namespace sprint0
{
	public class EnemiesFactor
	{

        private static EnemiesFactor instance = new EnemiesFactor();

        public static EnemiesFactor Instance
        {
            get
            {
                return instance;
            }
        }

        public EnemiesFactor() {}



        public Ienemy CreateEnemy(Texture2D enemiesSprite, Texture2D enemiesSprite2, int enemy, Vector2 pos, int enemyID)
        {

            switch (enemy)
            {
                case 1: // bat sprite
                    return new BatSprite1(enemyID, enemiesSprite,pos);
                case 2: // blue blob
                    return new BlueBlob(enemyID, enemiesSprite, pos);

                case 3: //dragon
                    return new DragonSprite1(enemyID, enemiesSprite, enemiesSprite2, pos);

                case 4: // skeleton
                    return new SkeletonSprite1(enemyID, enemiesSprite, pos);
                case 5: // hand
                    return new Hand(enemyID, enemiesSprite, pos);
                default:
                    return null;
            }
        }
    }
}