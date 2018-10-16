﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Point1
{
    class KiviPala : Pala
    {
        new Texture2D pic = new Texture2D(Game1.Instance.GraphicsDevice, 30, 30);
        public KiviPala(Game game) : base(game)
        {
            pic = iKivi;
            laji = "kivi";
        }
    }
}