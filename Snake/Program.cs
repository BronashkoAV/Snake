using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height;
            Console.SetBufferSize(width = Console.WindowWidth, height = Console.WindowHeight);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, width-1, 1, '+');
            HorizontalLine downLine = new HorizontalLine(0, width-1, height-2, '+');
            VerticalLine leftLine = new VerticalLine(0, 1, height-3, '+');
            VerticalLine rightLine = new VerticalLine(width-1, 1, height-3, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadKey();
        }

    }
}
