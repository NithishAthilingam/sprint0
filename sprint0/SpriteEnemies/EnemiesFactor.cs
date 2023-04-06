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
        public Ienemy CreateEnemy(int enemy, Vector2 pos)
        {
            switch (enemy)
            {
                case 1: // bat sprite
                    return new BatSprite1(pos);
                case 2: // blue blob
                    return new BlueBlob(pos);
                case 3: // hand
                    return new DragonSprite1(pos);
                case 4: // skeleton
                    return new SkeletonSprite1(pos);
                default:
                    return null;
            }
        }
    }
}