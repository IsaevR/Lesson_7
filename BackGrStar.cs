using System;
using System.Collections.Generic;
using System.Text;

namespace GameProj
{
    // этот класс создает  белую точку (в качестве звезды на заднем фоне )
    class BackGrStar: Shape
    {

        public BackGrStar(int x, int y) : base(x, y)
        {

        }

        public override void Draw(IRender render)
        {
            render.SetPixel(X, Y, ConsoleColor.White);

            Y = Y % 80 + 2;
            //base.Draw(render);
        }
    }
}
