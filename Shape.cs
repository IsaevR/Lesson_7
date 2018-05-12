﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{
    abstract class Shape : IShape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public abstract void Draw(IRender render);

        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
