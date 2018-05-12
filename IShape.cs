using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{   // интерфейс который устанавливает координаты для x и y
    interface IShape
    {
        int X { get; set; }

        int Y { get; set; }

        void Draw(IRender render);
    }
}
