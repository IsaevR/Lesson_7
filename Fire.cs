using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{
    // этот клас рисует анимированное плямя 
    class Fire :Shape
    {
        public ConsoleColor Color { get; set; }

        public Fire(int x, int y, ConsoleColor color) : base(x, y)
        {
            this.Color = color;
        }

        private void Frame1(IRender render)
        {
            render.SetPixel(X, Y, Color);
            render.SetPixel(X - 1, Y, Color);
            render.SetPixel(X + 1, Y, Color);
            render.SetPixel(X, Y - 1, Color);
            render.SetPixel(X, Y + 1, Color);
        }

        private void Frame2(IRender render)
        {
            render.SetPixel(X, Y, Color);
            render.SetPixel(X - 1, Y + 1, Color);
            render.SetPixel(X + 1, Y + 1, Color);
        }

        public override void Draw(IRender render)
        {
            if (render.Frame % 2 == 0)
            {
                this.Frame1(render);
            }
            else
            {
                this.Frame2(render);
            }
        }
    }
}
