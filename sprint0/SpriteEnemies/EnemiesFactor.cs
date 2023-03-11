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
		public EnemiesFactor()
		{

		}

		public static Ienemy CreateEnemy(int enemy, Vector2 pos)
		{
            //bat sprite 
			if(enemy == 1)
			{
                return new BatSprite1(pos);
			}

            //blue blob  
            if (enemy == 2)
            {
                return new BlueBlob(pos);
            }

            //hand
            if (enemy == 3)
            {
                return new DragonSprite1(pos);
            }

            //skeleton
            if (enemy == 4)
            {
                return new SkeletonSprite1(pos);

            }

            return null;
        }



    }
}

