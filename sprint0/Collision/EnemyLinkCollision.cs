using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sprint0.Interfaces;
using sprint0.HealthBar;

namespace sprint0.Collision
{
    internal class EnemyLinkCollision : ICollision
    {
        int frame =0;
        char x;
        Rectangle link;
        Rectangle enemy;
        Rectangle intersect;
        public Health h;



        public void Update(GameTime gameTime, Game1 game, RoomsRoom currentRoomsRoom)
        {

            link = new Rectangle((int)game.controller[0].GetLinkPos().X, (int)game.controller[0].GetLinkPos().Y, 60, 60);
            foreach (KeyValuePair<int, Vector2> entry in currentRoomsRoom.enemiesD)
            {
                enemy = new Rectangle((int)entry.Value.X, (int)entry.Value.Y, 60, 60);
                intersect = Rectangle.Intersect(link, enemy);
                x = CollisionDetection.GetDirection(link, enemy);
            }
            
            frame++;
            if (x!='o')
            {
                //game.sprite = new DamagedSprite(game.linkPos);
                if(x == 'w')
                {
                    //game.sprite = new UpSprite(game.linkPos);
                    //game.linkPos.Y -= intersect.Height;
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(0, -intersect.Height));
                    //game.controller[0].ModifyLinkPos(new Vector2(0, -intersect.Height));
                }
                else if(x == 'a')
                {
                    //game.sprite = new LeftSprite(game.linkPos);
                    //game.linkPos.X -= intersect.Width;
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(-intersect.Width, 0));
                    //game.controller[0].ModifyLinkPos(new Vector2(-intersect.Width, 0));

                }
                else if (x == 's')
                {
                    //game.sprite = new DownSprite(game.linkPos);
                    //game.linkPos.Y += intersect.Height;
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(0, intersect.Height));
                    //game.controller[0].ModifyLinkPos(new Vector2(0, intersect.Height));

                }
                else if (x == 'd')
                {
                    //game.sprite = new RightSprite(game.linkPos);
                    //game.linkPos.X += intersect.Width;
                    game.controller[0].SetLinkPos(game.controller[0].GetLinkPos() + new Vector2(intersect.Width, 0));
                    //game.controller[0].ModifyLinkPos(new Vector2(intersect.Width, 0));

                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
