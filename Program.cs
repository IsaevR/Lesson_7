using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t ДO ЗАПУСКА ОСТАЛОСЬ ");
            DisplayTimer();       // метод - таймер
           
            // создаем список в котором хранятся звезды с координатами, космический корабль и реактивная плазма
            var shapes = new List<IShape>();
            shapes.Add(new BackGrStar(5, 5));
            shapes.Add(new BackGrStar(9, 2));
            shapes.Add(new BackGrStar(6, 9));
            shapes.Add(new BackGrStar(14, 30));
            shapes.Add(new BackGrStar(15, 18));
            shapes.Add(new BackGrStar(30, 26));
            shapes.Add(new BackGrStar(14, 18));
            shapes.Add(new BackGrStar(13, 27));
            shapes.Add(new BackGrStar(21, 19));
            shapes.Add(new BackGrStar(14, 15));
            shapes.Add(new BackGrStar(12, 4));
            shapes.Add(new BackGrStar(14, 15));
            shapes.Add(new BackGrStar(37, 30));
            shapes.Add(new BackGrStar(40, 18));
            shapes.Add(new BackGrStar(35, 26));
            shapes.Add(new BackGrStar(48, 18));
            shapes.Add(new BackGrStar(51, 13));
            shapes.Add(new BackGrStar(49, 19));
            shapes.Add(new BackGrStar(62, 15));
            shapes.Add(new BackGrStar(57, 4));
            shapes.Add(new BackGrStar(43, 15));
           
            shapes.Add(new SpaceShip(25, 25, ConsoleColor.Yellow)); //  записываем в List космический корабыль

            shapes.Add(new Fire(25, 30, ConsoleColor.Blue));  // записываем в List реактивную плазму

            var engine = new Render();
            engine.Draw(shapes);       


            Console.ReadKey();
        }
        // Метод показывает таймер с обратным отсчетом
        static void DisplayTimer()
        {
            for (int i = 9; i >= 0; --i)
            {
                int l = Console.CursorLeft;
                int t = Console.CursorTop;
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t {0} ", i);
                Console.CursorLeft = l;
                Console.CursorTop = t;
                Thread.Sleep(1000);
            }
        }
    }
    
    
}