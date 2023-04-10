using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Diagnostics;

using System.Threading;

using Microsoft.Xna.Framework.Graphics;
using sprint0.Items;

namespace sprint0
{
    public interface Icontroller
    {
        public void Update(GameTime gameTime);
        public Vector2 GetLinkPos();
        public void SetLinkPos(Vector2 newPos);
        public void ModifyLinkPos(Vector2 mod);
        public void setLink(char setter);
    }
}
