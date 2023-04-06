using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace sprint0
{
    public interface Icontroller
    {
        public void Update(GameTime gameTime);
        public Vector2 GetLinkPos();
        public void SetLinkPos(Vector2 newPos);
        public void ModifyLinkPos(Vector2 mod);
    }
}
