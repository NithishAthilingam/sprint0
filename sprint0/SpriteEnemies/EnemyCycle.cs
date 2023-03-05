using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0.EnemySprites
{
    public class EnemyCycle : Ienemy
    {
        private int EnemyIndex;
        private Game1 game;
        private Vector2 enemyStartPos;

        public EnemyCycle(Game1 link,int enemyIdx)
        {
            game = link;
            enemyStartPos = new Vector2(450, 250);
            EnemyIndex = enemyIdx;

        }

        public void Update(GameTime gametime)
        {
            if (EnemyIndex == 0)
            {
                game.enemy = new DragonSprite1(enemyStartPos);
            }
            else if (EnemyIndex == 1)
            {
                game.enemy = new SkeletonSprite1(enemyStartPos);
            }
            else if (EnemyIndex == 2)
            {
                game.enemy = new BatSprite1(enemyStartPos);
            }
            else if (EnemyIndex == 3)
            {
                game.enemy = new BlueBlob(enemyStartPos);
            }
        } 

        public void Draw(SpriteBatch spriteBatch, Texture2D[] animate, Vector2 pos)
        {

        }
    }


}
