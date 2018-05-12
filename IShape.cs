using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{
    interface IShape
    {
        int X { get; set; }

        int Y { get; set; }

        void Draw(IRender render);
    }
}
