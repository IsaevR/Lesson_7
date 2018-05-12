using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{
    // этот класс задает координаты и цвет "пикселям" которые формирую космический корабль
    class SpaceShip : Shape
    {
        public ConsoleColor Color { get; set; }

        public SpaceShip(int x, int y, ConsoleColor color) : base(x, y)
        {
            this.Color = color;
        }


        public override void Draw(IRender render)
        {
            render.SetPixel(X, Y, Color);
            render.SetPixel(X - 1, Y, Color);
            render.SetPixel(X + 1, Y, Color);
            render.SetPixel(X, Y - 1, Color);
            render.SetPixel(X, Y + 1, Color);
            render.SetPixel(X, Y - 2, Color);
            render.SetPixel(X + 1, Y + 2, Color);
            render.SetPixel(X + 1, Y + 3, Color);
            render.SetPixel(X + 1, Y + 1, Color);
            render.SetPixel(X + 1, Y + 2, Color);
            render.SetPixel(X + 1, Y + 3, Color);
            render.SetPixel(X - 1, Y + 1, Color);
            render.SetPixel(X - 1, Y + 2, Color);
            render.SetPixel(X - 1, Y + 3, Color);
            render.SetPixel(X + 2, Y + 2, Color);
            render.SetPixel(X + 2, Y + 3, Color);
            render.SetPixel(X - 2, Y + 2, Color);
            render.SetPixel(X - 2, Y + 3, Color);
            render.SetPixel(X, Y + 1, Color);
            render.SetPixel(X, Y + 2, Color);
            render.SetPixel(X, Y + 3, Color);
            render.SetPixel(X - 1, Y + 4, Color);
            render.SetPixel(X + 1, Y + 4, Color);
            render.SetPixel(X + 3, Y + 3, Color);
            render.SetPixel(X - 3, Y + 3, Color);
        }
    }

}
