﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    public interface IDisplay
    {
        void Draw(SpriteBatch spriteBatch, Texture2D bar);
    }
}
