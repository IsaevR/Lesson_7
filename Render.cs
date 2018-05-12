using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameProj
{   
    // класс Render визуализирует объекты в консоли
    class Render : IRender
    {
        public int Frame { get; private set; }

        private void PrepareEnv()
        {
            Console.CursorVisible = false;
        }
        // метод Draw обновляет консоль через каждые 50 м/сек
        public void Draw(IEnumerable<IShape> shapes)
        {
            this.PrepareEnv();
            while (true)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw(this);
                }

                Wait();
                Clear();

                this.Frame++;
            }
        }
        private void Wait()
        {
            Thread.Sleep(50);
        }

        private void Clear()
        {
            Console.Clear();
        }
        // этот метод для установки координат и цвета
        public void SetPixel(int x, int y, ConsoleColor color)
        {
            if (x < 0 || y < 0)
            {
                return;
            }

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("■");
        }
    }
}
